namespace Club_Deportivo.Vistas
{
    partial class Inscripcion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripcion));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nombreInput = new TextBox();
            apellidoInput = new TextBox();
            documentoInput = new TextBox();
            cmbTipoDoc = new ComboBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            chkAF = new CheckBox();
            label9 = new Label();
            cmbTipoCliente = new ComboBox();
            label10 = new Label();
            btnRegistrarCliente = new Button();
            label11 = new Label();
            btn_Volver = new Button();
            btn_Limpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 118);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 167);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 216);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 265);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Documento";
            // 
            // nombreInput
            // 
            nombreInput.Location = new Point(476, 115);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(208, 27);
            nombreInput.TabIndex = 4;
            // 
            // apellidoInput
            // 
            apellidoInput.Location = new Point(476, 167);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(208, 27);
            apellidoInput.TabIndex = 5;
            // 
            // documentoInput
            // 
            documentoInput.Location = new Point(476, 265);
            documentoInput.Name = "documentoInput";
            documentoInput.Size = new Size(208, 27);
            documentoInput.TabIndex = 6;
            // 
            // cmbTipoDoc
            // 
            cmbTipoDoc.FormattingEnabled = true;
            cmbTipoDoc.Items.AddRange(new object[] { "DNI", "CUIT", "CUIL" });
            cmbTipoDoc.Location = new Point(476, 216);
            cmbTipoDoc.Name = "cmbTipoDoc";
            cmbTipoDoc.Size = new Size(208, 28);
            cmbTipoDoc.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(690, 114);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 10;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(690, 216);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 11;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(690, 169);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 12;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(690, 264);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 13;
            label8.Text = "*";
            // 
            // chkAF
            // 
            chkAF.AutoSize = true;
            chkAF.Location = new Point(360, 318);
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
            label9.Location = new Point(586, 322);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 15;
            label9.Text = "*";
            // 
            // cmbTipoCliente
            // 
            cmbTipoCliente.AccessibleRole = AccessibleRole.Cursor;
            cmbTipoCliente.BackColor = SystemColors.HighlightText;
            cmbTipoCliente.FormattingEnabled = true;
            cmbTipoCliente.Items.AddRange(new object[] { "Socios", "No Socios" });
            cmbTipoCliente.Location = new Point(476, 65);
            cmbTipoCliente.Name = "cmbTipoCliente";
            cmbTipoCliente.Size = new Size(208, 28);
            cmbTipoCliente.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(358, 65);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 17;
            label10.Text = "Tipo de Cliente";
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(474, 368);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(153, 51);
            btnRegistrarCliente.TabIndex = 18;
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(690, 65);
            label11.Name = "label11";
            label11.Size = new Size(15, 20);
            label11.TabIndex = 19;
            label11.Text = "*";
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(315, 368);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(153, 51);
            btn_Volver.TabIndex = 20;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.Location = new Point(635, 368);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(153, 51);
            btn_Limpiar.TabIndex = 21;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = true;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // Inscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 451);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Volver);
            Controls.Add(label11);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(label10);
            Controls.Add(cmbTipoCliente);
            Controls.Add(label9);
            Controls.Add(chkAF);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(cmbTipoDoc);
            Controls.Add(documentoInput);
            Controls.Add(apellidoInput);
            Controls.Add(nombreInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Inscripcion";
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
        private ComboBox cmbTipoDoc;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Button btnLimpiar;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox chkAF;
        private Label label9;
        private ComboBox cmbTipoCliente;
        private Label label10;
        private Button btnRegistrar;
        private Button btnRegistrarCliente;
        private Label label11;
        private Button btn_Volver;
        private Button btn_Limpiar;
    }
}