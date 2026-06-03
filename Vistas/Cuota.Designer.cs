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
            radioButton1 = new RadioButton();
            rbTarjeta6 = new RadioButton();
            rbTarjeta3 = new RadioButton();
            rbEfectivo = new RadioButton();
            btn_Volver = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(297, 68);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(224, 27);
            txt_DNI.TabIndex = 0;
            txt_DNI.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_socio
            // 
            lbl_socio.AutoSize = true;
            lbl_socio.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_socio.Location = new Point(286, 29);
            lbl_socio.Name = "lbl_socio";
            lbl_socio.Size = new Size(244, 25);
            lbl_socio.TabIndex = 1;
            lbl_socio.Text = "Ingrese N° de DNI del Socio";
            // 
            // btn_Pagar
            // 
            btn_Pagar.Location = new Point(309, 355);
            btn_Pagar.Name = "btn_Pagar";
            btn_Pagar.Size = new Size(190, 51);
            btn_Pagar.TabIndex = 2;
            btn_Pagar.Text = "Pagar Cuota";
            btn_Pagar.UseVisualStyleBackColor = true;
            btn_Pagar.Click += btn_Pagar_Click;
            // 
            // btn_Carnet
            // 
            btn_Carnet.ForeColor = Color.SaddleBrown;
            btn_Carnet.Location = new Point(535, 355);
            btn_Carnet.Name = "btn_Carnet";
            btn_Carnet.Size = new Size(205, 51);
            btn_Carnet.TabIndex = 3;
            btn_Carnet.Text = "Obtener Carnet";
            btn_Carnet.UseVisualStyleBackColor = true;
            btn_Carnet.Click += btn_Carnet_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(rbTarjeta6);
            groupBox1.Controls.Add(rbTarjeta3);
            groupBox1.Controls.Add(rbEfectivo);
            groupBox1.Location = new Point(260, 176);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 144);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 104);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(257, 24);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tarj de crédito: 6 cuotas sin interes";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta6
            // 
            rbTarjeta6.AutoSize = true;
            rbTarjeta6.Location = new Point(21, 146);
            rbTarjeta6.Name = "rbTarjeta6";
            rbTarjeta6.Size = new Size(257, 24);
            rbTarjeta6.TabIndex = 8;
            rbTarjeta6.TabStop = true;
            rbTarjeta6.Text = "Tarj de crédito: 6 cuotas sin interes";
            rbTarjeta6.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta3
            // 
            rbTarjeta3.AutoSize = true;
            rbTarjeta3.Location = new Point(21, 74);
            rbTarjeta3.Name = "rbTarjeta3";
            rbTarjeta3.Size = new Size(257, 24);
            rbTarjeta3.TabIndex = 7;
            rbTarjeta3.TabStop = true;
            rbTarjeta3.Text = "Tarj de crédito: 3 cuotas sin interes";
            rbTarjeta3.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(21, 44);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(197, 24);
            rbEfectivo.TabIndex = 6;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo (10% descuento)";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(83, 355);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(189, 51);
            btn_Volver.TabIndex = 5;
            btn_Volver.Text = "Volver";
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
        private RadioButton rbTarjeta3;
        private RadioButton rbTarjeta6;
        private Label label1;
        private RadioButton radioButton1;
    }
}