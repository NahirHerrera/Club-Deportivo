namespace Club_Deportivo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usuarioBox = new TextBox();
            contraseniaBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usuarioBox
            // 
            usuarioBox.Location = new Point(461, 73);
            usuarioBox.Name = "usuarioBox";
            usuarioBox.Size = new Size(186, 27);
            usuarioBox.TabIndex = 0;
            usuarioBox.TextChanged += usuarioInput;
            // 
            // contraseniaBox
            // 
            contraseniaBox.Location = new Point(461, 139);
            contraseniaBox.Name = "contraseniaBox";
            contraseniaBox.Size = new Size(186, 27);
            contraseniaBox.TabIndex = 1;
            contraseniaBox.TextChanged += contraseniaInput;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 76);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 141);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(493, 213);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(62, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 339);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contraseniaBox);
            Controls.Add(usuarioBox);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usuarioBox;
        private TextBox contraseniaBox;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
