namespace Club_Deportivo
{
    partial class Comprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprobante));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lbl_FormaPago = new Label();
            label10 = new Label();
            lbl_Periodo = new Label();
            lbl_Monto = new Label();
            lbl_Apellido = new Label();
            lbl_Nombre = new Label();
            label6 = new Label();
            lbl_NSocio = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lbl = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(117, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_FormaPago);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lbl_Periodo);
            panel1.Controls.Add(lbl_Monto);
            panel1.Controls.Add(lbl_Apellido);
            panel1.Controls.Add(lbl_Nombre);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lbl_NSocio);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lbl);
            panel1.Location = new Point(38, 223);
            panel1.Name = "panel1";
            panel1.Size = new Size(731, 193);
            panel1.TabIndex = 2;
            // 
            // lbl_FormaPago
            // 
            lbl_FormaPago.AutoSize = true;
            lbl_FormaPago.Font = new Font("Lucida Fax", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FormaPago.Location = new Point(481, 103);
            lbl_FormaPago.Name = "lbl_FormaPago";
            lbl_FormaPago.Size = new Size(16, 21);
            lbl_FormaPago.TabIndex = 21;
            lbl_FormaPago.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(338, 103);
            label10.Name = "label10";
            label10.Size = new Size(142, 20);
            label10.TabIndex = 20;
            label10.Text = "Forma de pago:";
            // 
            // lbl_Periodo
            // 
            lbl_Periodo.AutoSize = true;
            lbl_Periodo.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Periodo.Location = new Point(181, 150);
            lbl_Periodo.Name = "lbl_Periodo";
            lbl_Periodo.Size = new Size(15, 20);
            lbl_Periodo.TabIndex = 19;
            lbl_Periodo.Text = "-";
            // 
            // lbl_Monto
            // 
            lbl_Monto.AutoSize = true;
            lbl_Monto.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Monto.Location = new Point(133, 104);
            lbl_Monto.Name = "lbl_Monto";
            lbl_Monto.Size = new Size(15, 20);
            lbl_Monto.TabIndex = 18;
            lbl_Monto.Text = "-";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Apellido.Location = new Point(269, 60);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(15, 20);
            lbl_Apellido.TabIndex = 17;
            lbl_Apellido.Text = "-";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nombre.Location = new Point(214, 60);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(15, 20);
            lbl_Nombre.TabIndex = 16;
            lbl_Nombre.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(358, 86);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 15;
            // 
            // lbl_NSocio
            // 
            lbl_NSocio.AutoSize = true;
            lbl_NSocio.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NSocio.Location = new Point(121, 16);
            lbl_NSocio.Name = "lbl_NSocio";
            lbl_NSocio.Size = new Size(15, 20);
            lbl_NSocio.TabIndex = 14;
            lbl_NSocio.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 150);
            label9.Name = "label9";
            label9.Size = new Size(137, 20);
            label9.TabIndex = 13;
            label9.Text = "Fecha de pago:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(37, 103);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 12;
            label8.Text = "Monto:  $";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 60);
            label7.Name = "label7";
            label7.Size = new Size(179, 20);
            label7.TabIndex = 11;
            label7.Text = "Nombre y apellido: ";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Lucida Fax", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(38, 16);
            lbl.Name = "lbl";
            lbl.Size = new Size(84, 20);
            lbl.TabIndex = 10;
            lbl.Text = "N° Socio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(75, 65);
            label1.Name = "label1";
            label1.Size = new Size(189, 23);
            label1.TabIndex = 5;
            label1.Text = "CLUB DEPORTIVO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 84);
            label3.Name = "label3";
            label3.Size = new Size(154, 23);
            label3.TabIndex = 6;
            label3.Text = "Fitness Center";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 129);
            label2.Name = "label2";
            label2.Size = new Size(305, 23);
            label2.TabIndex = 7;
            label2.Text = "Dirección: Bulnes 456 - CABA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(432, 178);
            label4.Name = "label4";
            label4.Size = new Size(288, 23);
            label4.TabIndex = 8;
            label4.Text = "Teléfono: (011)  4563-7845";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(432, 84);
            label5.Name = "label5";
            label5.Size = new Size(229, 23);
            label5.TabIndex = 9;
            label5.Text = "CUIT: 30-23654878-9";
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(263, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 35);
            panel2.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 5);
            label11.Name = "label11";
            label11.Size = new Size(238, 24);
            label11.TabIndex = 0;
            label11.Text = "COMPROBANTE DE PAGO";
            // 
            // Comprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Comprobante";
            Text = "Comprobante de pago";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label lbl;
        private Label label9;
        private Label lbl_NSocio;
        private Label lbl_Nombre;
        private Label label6;
        private Label lbl_Periodo;
        private Label lbl_Monto;
        private Label lbl_Apellido;
        private Label lbl_FormaPago;
        private Label label10;
        private Panel panel2;
        private Label label11;
    }
}