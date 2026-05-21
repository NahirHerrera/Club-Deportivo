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
            btn_InscribirSocio = new Button();
            btnSalir = new Button();
            btn_CobrarCuota = new Button();
            btn_ListadoDeudores = new Button();
            SuspendLayout();
            // 
            // btn_InscribirSocio
            // 
            btn_InscribirSocio.Location = new Point(273, 38);
            btn_InscribirSocio.Name = "btn_InscribirSocio";
            btn_InscribirSocio.Size = new Size(254, 101);
            btn_InscribirSocio.TabIndex = 0;
            btn_InscribirSocio.Text = "Inscribir Socio";
            btn_InscribirSocio.UseVisualStyleBackColor = true;
            btn_InscribirSocio.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(655, 38);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btn_CobrarCuota
            // 
            btn_CobrarCuota.Location = new Point(273, 175);
            btn_CobrarCuota.Name = "btn_CobrarCuota";
            btn_CobrarCuota.Size = new Size(254, 101);
            btn_CobrarCuota.TabIndex = 2;
            btn_CobrarCuota.Text = "Cobrar Cuota";
            btn_CobrarCuota.UseVisualStyleBackColor = true;
            btn_CobrarCuota.Click += btn_CobrarCuota_Click;
            // 
            // btn_ListadoDeudores
            // 
            btn_ListadoDeudores.Location = new Point(273, 313);
            btn_ListadoDeudores.Name = "btn_ListadoDeudores";
            btn_ListadoDeudores.Size = new Size(254, 101);
            btn_ListadoDeudores.TabIndex = 3;
            btn_ListadoDeudores.Text = "Emitir listado de deudores";
            btn_ListadoDeudores.UseVisualStyleBackColor = true;
            btn_ListadoDeudores.Click += btn_ListadoDeudores_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ListadoDeudores);
            Controls.Add(btn_CobrarCuota);
            Controls.Add(btnSalir);
            Controls.Add(btn_InscribirSocio);
            Name = "Home";
            Text = "Ventana principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_InscribirSocio;
        private Button btnSalir;
        private Button btn_CobrarCuota;
        private Button btn_ListadoDeudores;
    }
}