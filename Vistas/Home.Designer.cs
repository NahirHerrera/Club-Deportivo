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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btn_InscribirSocio = new Button();
            btn_CobrarCuota = new Button();
            btn_ListadoDeudores = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_InscribirSocio
            // 
            btn_InscribirSocio.Location = new Point(365, 57);
            btn_InscribirSocio.Name = "btn_InscribirSocio";
            btn_InscribirSocio.Size = new Size(218, 64);
            btn_InscribirSocio.TabIndex = 0;
            btn_InscribirSocio.Text = "Registrar Cliente";
            btn_InscribirSocio.UseVisualStyleBackColor = true;
            btn_InscribirSocio.Click += button1_Click;
            // 
            // btn_CobrarCuota
            // 
            btn_CobrarCuota.Location = new Point(365, 172);
            btn_CobrarCuota.Name = "btn_CobrarCuota";
            btn_CobrarCuota.Size = new Size(218, 71);
            btn_CobrarCuota.TabIndex = 2;
            btn_CobrarCuota.Text = "Cobrar Cuota/Generar Carnet";
            btn_CobrarCuota.UseVisualStyleBackColor = true;
            btn_CobrarCuota.Click += btn_CobrarCuota_Click;
            // 
            // btn_ListadoDeudores
            // 
            btn_ListadoDeudores.Location = new Point(365, 297);
            btn_ListadoDeudores.Name = "btn_ListadoDeudores";
            btn_ListadoDeudores.Size = new Size(218, 70);
            btn_ListadoDeudores.TabIndex = 3;
            btn_ListadoDeudores.Text = "Emitir listado de deudores";
            btn_ListadoDeudores.UseVisualStyleBackColor = true;
            btn_ListadoDeudores.Click += btn_ListadoDeudores_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 98);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 7;
            label3.Text = "¡BIENVENIDO!";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(138, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(107, 274);
            label1.Name = "label1";
            label1.Size = new Size(189, 23);
            label1.TabIndex = 9;
            label1.Text = "CLUB DEPORTIVO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 297);
            label2.Name = "label2";
            label2.Size = new Size(154, 23);
            label2.TabIndex = 10;
            label2.Text = "Fitness Center";
            // 
            // button1
            // 
            button1.Location = new Point(683, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btn_ListadoDeudores);
            Controls.Add(btn_CobrarCuota);
            Controls.Add(btn_InscribirSocio);
            Name = "Home";
            Text = "Home - Club Deportivo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_InscribirSocio;
        private Button btn_CobrarCuota;
        private Button btn_ListadoDeudores;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}