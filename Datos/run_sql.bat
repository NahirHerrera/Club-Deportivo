@echo off
setlocal enabledelayedexpansion
chcp 65001 >nul

REM ==============================================================
REM   run_sql.bat - Ejecuta Club_Deportivo_MODIFICADO.sql
REM   Colocar este script EN LA MISMA CARPETA que el .sql
REM ==============================================================

set "SQL_FILE=%~dp0Club_Deportivo_MODIFICADO.sql"

echo ======================================
echo   Ejecutor: Club_Deportivo_MODIFICADO
echo ======================================
echo.

REM --- Verificar que el .sql existe ---
if not exist "%SQL_FILE%" (
    echo Error: No se encontro el archivo:
    echo    %SQL_FILE%
    echo Asegurate de que el .sql este en la misma carpeta que este .bat.
    pause
    exit /b 1
)

REM --- Detectar mysql.exe: primero en el PATH, si no, en rutas tipicas ---
set "MYSQL_CMD="

where mysql >nul 2>nul
if not errorlevel 1 (
    set "MYSQL_CMD=mysql"
)

if "%MYSQL_CMD%"=="" (
    for %%V in (8.4 8.0 5.7) do (
        if exist "C:\Program Files\MySQL\MySQL Server %%V\bin\mysql.exe" (
            set "MYSQL_CMD=C:\Program Files\MySQL\MySQL Server %%V\bin\mysql.exe"
        )
        if exist "C:\Program Files (x86)\MySQL\MySQL Server %%V\bin\mysql.exe" (
            set "MYSQL_CMD=C:\Program Files (x86)\MySQL\MySQL Server %%V\bin\mysql.exe"
        )
    )
)

if "%MYSQL_CMD%"=="" (
    for /f "delims=" %%F in ('dir "C:\Program Files\MySQL\mysql.exe" /s /b 2^>nul') do (
        set "MYSQL_CMD=%%F"
    )
)

if "%MYSQL_CMD%"=="" (
    echo Error: No se encontro 'mysql.exe' ni en el PATH ni en las rutas tipicas.
    echo Instala MySQL Server o agrega manualmente la carpeta 'bin' de MySQL al PATH.
    pause
    exit /b 1
)

echo Usando MySQL: %MYSQL_CMD%
echo.

REM --- Solicitar la contrasena de root (sin mostrarla en pantalla) ---
echo Ingresa la contrasena del usuario root de MySQL:
for /f "delims=" %%P in ('powershell -Command "$p = Read-Host -AsSecureString; $b = [Runtime.InteropServices.Marshal]::SecureStringToBSTR($p); [Runtime.InteropServices.Marshal]::PtrToStringAuto($b)"') do set "MYSQL_PASS=%%P"
echo.

REM --- Ejecutar el script SQL ---
echo Ejecutando Club_Deportivo_MODIFICADO.sql...
"%MYSQL_CMD%" -u root -p"%MYSQL_PASS%" < "%SQL_FILE%"

if %errorlevel% equ 0 (
    echo.
    echo Base de datos restaurada correctamente.
) else (
    echo.
    echo El script termino con errores ^(codigo: %errorlevel%^).
    echo Verifica la contrasena o el contenido del archivo .sql
)

echo.
pause
endlocal
