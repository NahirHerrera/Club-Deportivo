namespace Club_Deportivo.Vistas
{
    partial class chkAptoFisico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chkAptoFisico));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nombreInput = new TextBox();
            apellidoInput = new TextBox();
            documentoInput = new TextBox();
            tipoBox = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            chkAF = new CheckBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 77);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(367, 139);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 199);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 257);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Documento";
            // 
            // nombreInput
            // 
            nombreInput.Location = new Point(474, 77);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(210, 27);
            nombreInput.TabIndex = 4;
            nombreInput.TextChanged += nombreInput_TextChanged;
            // 
            // apellidoInput
            // 
            apellidoInput.Location = new Point(474, 136);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(210, 27);
            apellidoInput.TabIndex = 5;
            apellidoInput.TextChanged += apellidoInput_TextChanged;
            // 
            // documentoInput
            // 
            documentoInput.Location = new Point(474, 251);
            documentoInput.Name = "documentoInput";
            documentoInput.Size = new Size(210, 27);
            documentoInput.TabIndex = 6;
            documentoInput.TextChanged += documentoInput_TextChanged;
            // 
            // tipoBox
            // 
            tipoBox.FormattingEnabled = true;
            tipoBox.Items.AddRange(new object[] { "DNI", "CUIT", "CUIL" });
            tipoBox.Location = new Point(474, 191);
            tipoBox.Name = "tipoBox";
            tipoBox.Size = new Size(210, 28);
            tipoBox.TabIndex = 7;
            tipoBox.SelectedIndexChanged += tipoBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(474, 368);
            button1.Name = "button1";
            button1.Size = new Size(153, 51);
            button1.TabIndex = 8;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(315, 368);
            button2.Name = "button2";
            button2.Size = new Size(153, 51);
            button2.TabIndex = 8;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(635, 368);
            button3.Name = "button3";
            button3.Size = new Size(153, 51);
            button3.TabIndex = 8;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(691, 81);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 10;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(691, 195);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 11;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(691, 139);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 12;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(691, 257);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 13;
            label8.Text = "*";
            // 
            // chkAF
            // 
            chkAF.AutoSize = true;
            chkAF.Location = new Point(367, 314);
            chkAF.Name = "chkAF";
            chkAF.Size = new Size(220, 24);
            chkAF.TabIndex = 14;
            chkAF.Text = "Presenta Apto Físico Vigente";
            chkAF.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(583, 318);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 15;
            label9.Text = "*";
            // 
            // chkAptoFisico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 451);
            Controls.Add(label9);
            Controls.Add(chkAF);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(tipoBox);
            Controls.Add(documentoInput);
            Controls.Add(apellidoInput);
            Controls.Add(nombreInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "chkAptoFisico";
            Text = "Inscripcion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nombreInput;
        private TextBox apellidoInput;
        private TextBox documentoInput;
        private ComboBox tipoBox;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox chkAF;
        private Label label9;
    }
}