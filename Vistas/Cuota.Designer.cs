namespace Club_Deportivo
{
    partial class Cuota
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
            txt_DNI = new TextBox();
            lbl_socio = new Label();
            btn_Pagar = new Button();
            btn_Carnet = new Button();
            groupBox1 = new GroupBox();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            btn_Volver = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(90, 115);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(224, 27);
            txt_DNI.TabIndex = 0;
            txt_DNI.Text = "32456741";
            txt_DNI.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_socio
            // 
            lbl_socio.AutoSize = true;
            lbl_socio.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_socio.Location = new Point(109, 74);
            lbl_socio.Name = "lbl_socio";
            lbl_socio.Size = new Size(163, 25);
            lbl_socio.TabIndex = 1;
            lbl_socio.Text = "Ingrese N° de DNI";
            // 
            // btn_Pagar
            // 
            btn_Pagar.Location = new Point(72, 194);
            btn_Pagar.Name = "btn_Pagar";
            btn_Pagar.Size = new Size(258, 73);
            btn_Pagar.TabIndex = 2;
            btn_Pagar.Text = "PAGAR";
            btn_Pagar.UseVisualStyleBackColor = true;
            btn_Pagar.Click += btn_Pagar_Click;
            // 
            // btn_Carnet
            // 
            btn_Carnet.ForeColor = Color.SaddleBrown;
            btn_Carnet.Location = new Point(72, 308);
            btn_Carnet.Name = "btn_Carnet";
            btn_Carnet.Size = new Size(258, 72);
            btn_Carnet.TabIndex = 3;
            btn_Carnet.Text = "OBTENER CARNET";
            btn_Carnet.UseVisualStyleBackColor = true;
            btn_Carnet.Click += btn_Carnet_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbTarjeta);
            groupBox1.Controls.Add(rbEfectivo);
            groupBox1.Location = new Point(455, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 153);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(21, 93);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(146, 24);
            rbTarjeta.TabIndex = 7;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta de crédito";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(21, 45);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(83, 24);
            rbEfectivo.TabIndex = 6;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(455, 308);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(255, 72);
            btn_Volver.TabIndex = 5;
            btn_Volver.Text = "VOLVER";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // Cuota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Volver);
            Controls.Add(groupBox1);
            Controls.Add(btn_Carnet);
            Controls.Add(btn_Pagar);
            Controls.Add(lbl_socio);
            Controls.Add(txt_DNI);
            Name = "Cuota";
            Text = "Cobrar Cuota";
            Load += Cuota_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_DNI;
        private Label lbl_socio;
        private Button btn_Pagar;
        private Button btn_Carnet;
        private GroupBox groupBox1;
        private Button btn_Volver;
        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
    }
}