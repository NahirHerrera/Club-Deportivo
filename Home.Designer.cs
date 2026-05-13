namespace Club_Deportivo
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_registrarCliente = new Button();
            btn_CobrarCuota = new Button();
            btn_Listado = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btn_registrarCliente
            // 
            btn_registrarCliente.Location = new Point(267, 25);
            btn_registrarCliente.Name = "btn_registrarCliente";
            btn_registrarCliente.Size = new Size(275, 109);
            btn_registrarCliente.TabIndex = 0;
            btn_registrarCliente.Text = "Registrar Cliente";
            btn_registrarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_CobrarCuota
            // 
            btn_CobrarCuota.Location = new Point(267, 167);
            btn_CobrarCuota.Name = "btn_CobrarCuota";
            btn_CobrarCuota.Size = new Size(275, 109);
            btn_CobrarCuota.TabIndex = 1;
            btn_CobrarCuota.Text = "Cobrar Cuota";
            btn_CobrarCuota.UseVisualStyleBackColor = true;
            // 
            // btn_Listado
            // 
            btn_Listado.Location = new Point(267, 316);
            btn_Listado.Name = "btn_Listado";
            btn_Listado.Size = new Size(275, 109);
            btn_Listado.TabIndex = 2;
            btn_Listado.Text = "Emitir Listado de Deudores";
            btn_Listado.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(668, 25);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btn_Listado);
            Controls.Add(btn_CobrarCuota);
            Controls.Add(btn_registrarCliente);
            ForeColor = SystemColors.ControlText;
            Name = "Home";
            Text = "Ventana principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_registrarCliente;
        private Button btn_CobrarCuota;
        private Button btn_Listado;
        private Button btnSalir;
    }
}