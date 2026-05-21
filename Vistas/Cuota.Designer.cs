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
            textBox1 = new TextBox();
            lbl_socio = new Label();
            btn_Pagar = new Button();
            btn_Comprobante = new Button();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            btn_Volver = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 0;
            // 
            // lbl_socio
            // 
            lbl_socio.AutoSize = true;
            lbl_socio.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_socio.Location = new Point(109, 74);
            lbl_socio.Name = "lbl_socio";
            lbl_socio.Size = new Size(176, 25);
            lbl_socio.TabIndex = 1;
            lbl_socio.Text = "Ingrese N° de Socio";
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
            // btn_Comprobante
            // 
            btn_Comprobante.ForeColor = Color.SaddleBrown;
            btn_Comprobante.Location = new Point(72, 308);
            btn_Comprobante.Name = "btn_Comprobante";
            btn_Comprobante.Size = new Size(258, 72);
            btn_Comprobante.TabIndex = 3;
            btn_Comprobante.Text = "COMPROBANTE";
            btn_Comprobante.UseVisualStyleBackColor = true;
            btn_Comprobante.Click += btn_Comprobante_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(455, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 153);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(21, 96);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(176, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Tarjeta débito/crédito";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 45);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Efectivo";
            checkBox1.UseVisualStyleBackColor = true;
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
            Controls.Add(btn_Comprobante);
            Controls.Add(btn_Pagar);
            Controls.Add(lbl_socio);
            Controls.Add(textBox1);
            Name = "Cuota";
            Text = "Cobrar Cuota";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label lbl_socio;
        private Button btn_Pagar;
        private Button btn_Comprobante;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btn_Volver;
    }
}