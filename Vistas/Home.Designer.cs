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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_InscribirSocio
            // 
            btn_InscribirSocio.BackColor = Color.Beige;
            btn_InscribirSocio.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btn_InscribirSocio.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_InscribirSocio.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_InscribirSocio.FlatStyle = FlatStyle.Flat;
            btn_InscribirSocio.Location = new Point(41, 37);
            btn_InscribirSocio.Name = "btn_InscribirSocio";
            btn_InscribirSocio.Size = new Size(242, 47);
            btn_InscribirSocio.TabIndex = 0;
            btn_InscribirSocio.Text = "Registrar Cliente";
            btn_InscribirSocio.TextAlign = ContentAlignment.MiddleLeft;
            btn_InscribirSocio.UseVisualStyleBackColor = false;
            btn_InscribirSocio.Click += button1_Click;
            // 
            // btn_CobrarCuota
            // 
            btn_CobrarCuota.BackColor = Color.Beige;
            btn_CobrarCuota.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btn_CobrarCuota.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_CobrarCuota.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_CobrarCuota.FlatStyle = FlatStyle.Flat;
            btn_CobrarCuota.Location = new Point(41, 114);
            btn_CobrarCuota.Name = "btn_CobrarCuota";
            btn_CobrarCuota.Size = new Size(242, 47);
            btn_CobrarCuota.TabIndex = 2;
            btn_CobrarCuota.Text = "Cobrar Cuota (Socios)";
            btn_CobrarCuota.TextAlign = ContentAlignment.MiddleLeft;
            btn_CobrarCuota.UseVisualStyleBackColor = false;
            btn_CobrarCuota.Click += btn_CobrarCuota_Click;
            // 
            // btn_ListadoDeudores
            // 
            btn_ListadoDeudores.BackColor = Color.Beige;
            btn_ListadoDeudores.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btn_ListadoDeudores.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_ListadoDeudores.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_ListadoDeudores.FlatStyle = FlatStyle.Flat;
            btn_ListadoDeudores.Location = new Point(41, 269);
            btn_ListadoDeudores.Name = "btn_ListadoDeudores";
            btn_ListadoDeudores.Size = new Size(242, 47);
            btn_ListadoDeudores.TabIndex = 3;
            btn_ListadoDeudores.Text = "Emitir listado de deudores";
            btn_ListadoDeudores.TextAlign = ContentAlignment.MiddleLeft;
            btn_ListadoDeudores.UseVisualStyleBackColor = false;
            btn_ListadoDeudores.Click += btn_ListadoDeudores_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 92);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 7;
            label3.Text = "¡BIENVENIDO!";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(107, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(108, 329);
            label1.Name = "label1";
            label1.Size = new Size(178, 21);
            label1.TabIndex = 9;
            label1.Text = "CLUB DEPORTIVO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 350);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 10;
            label2.Text = "Fitness Center";
            // 
            // button1
            // 
            button1.Location = new Point(684, 27);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btn_Actividad
            // 
            btn_Actividad.BackColor = Color.Beige;
            btn_Actividad.FlatAppearance.BorderColor = Color.DarkGoldenrod;
            btn_Actividad.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Actividad.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Actividad.FlatStyle = FlatStyle.Flat;
            btn_Actividad.Location = new Point(41, 191);
            btn_Actividad.Margin = new Padding(3, 4, 3, 4);
            btn_Actividad.Name = "btn_Actividad";
            btn_Actividad.Size = new Size(242, 49);
            btn_Actividad.TabIndex = 12;
            btn_Actividad.Text = "Inscripcion Actividad (No Socios)";
            btn_Actividad.TextAlign = ContentAlignment.MiddleLeft;
            btn_Actividad.UseVisualStyleBackColor = false;
            btn_Actividad.Click += btn_Actividad_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Actividad);
            panel1.Controls.Add(btn_InscribirSocio);
            panel1.Controls.Add(btn_CobrarCuota);
            panel1.Controls.Add(btn_ListadoDeudores);
            panel1.Location = new Point(332, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 349);
            panel1.TabIndex = 13;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 451);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Name = "Home";
            Text = "Home - Club Deportivo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
    }
}