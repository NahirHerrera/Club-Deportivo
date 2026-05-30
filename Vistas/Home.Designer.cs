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
            btn_Actividad = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_InscribirSocio
            // 
            btn_InscribirSocio.Location = new Point(274, 46);
            btn_InscribirSocio.Margin = new Padding(3, 2, 3, 2);
            btn_InscribirSocio.Name = "btn_InscribirSocio";
            btn_InscribirSocio.Size = new Size(191, 48);
            btn_InscribirSocio.TabIndex = 0;
            btn_InscribirSocio.Text = "Registrar Cliente";
            btn_InscribirSocio.UseVisualStyleBackColor = true;
            btn_InscribirSocio.Click += button1_Click;
            // 
            // btn_CobrarCuota
            // 
            btn_CobrarCuota.Location = new Point(274, 129);
            btn_CobrarCuota.Margin = new Padding(3, 2, 3, 2);
            btn_CobrarCuota.Name = "btn_CobrarCuota";
            btn_CobrarCuota.Size = new Size(191, 53);
            btn_CobrarCuota.TabIndex = 2;
            btn_CobrarCuota.Text = "Cobrar Cuota/Generar Carnet";
            btn_CobrarCuota.UseVisualStyleBackColor = true;
            btn_CobrarCuota.Click += btn_CobrarCuota_Click;
            // 
            // btn_ListadoDeudores
            // 
            btn_ListadoDeudores.Location = new Point(274, 223);
            btn_ListadoDeudores.Margin = new Padding(3, 2, 3, 2);
            btn_ListadoDeudores.Name = "btn_ListadoDeudores";
            btn_ListadoDeudores.Size = new Size(191, 52);
            btn_ListadoDeudores.TabIndex = 3;
            btn_ListadoDeudores.Text = "Emitir listado de deudores";
            btn_ListadoDeudores.UseVisualStyleBackColor = true;
            btn_ListadoDeudores.Click += btn_ListadoDeudores_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 74);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 7;
            label3.Text = "¡BIENVENIDO!";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(121, 100);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(94, 206);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 9;
            label1.Text = "CLUB DEPORTIVO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 223);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 10;
            label2.Text = "Fitness Center";
            // 
            // button1
            // 
            button1.Location = new Point(598, 16);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 11;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btn_Actividad
            // 
            btn_Actividad.Location = new Point(497, 129);
            btn_Actividad.Name = "btn_Actividad";
            btn_Actividad.Size = new Size(191, 53);
            btn_Actividad.TabIndex = 12;
            btn_Actividad.Text = "Actividad";
            btn_Actividad.UseVisualStyleBackColor = true;
            btn_Actividad.Click += btn_Actividad_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_Actividad);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btn_ListadoDeudores);
            Controls.Add(btn_CobrarCuota);
            Controls.Add(btn_InscribirSocio);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btn_Actividad;
    }
}