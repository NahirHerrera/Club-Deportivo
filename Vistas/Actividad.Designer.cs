namespace Club_Deportivo.Vistas
{
    partial class Actividad
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
            lbl_DNI = new Label();
            txt_DNI = new TextBox();
            lbl_Actividad = new Label();
            dgvActividades = new DataGridView();
            btn_Inscribir = new Button();
            btn_Volver = new Button();
            btn_Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Font = new Font("Segoe UI", 12F);
            lbl_DNI.Location = new Point(18, 17);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(37, 21);
            lbl_DNI.TabIndex = 0;
            lbl_DNI.Text = "DNI";
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(61, 15);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(141, 23);
            txt_DNI.TabIndex = 1;
            // 
            // lbl_Actividad
            // 
            lbl_Actividad.AutoSize = true;
            lbl_Actividad.Font = new Font("Segoe UI", 10F);
            lbl_Actividad.Location = new Point(18, 52);
            lbl_Actividad.Name = "lbl_Actividad";
            lbl_Actividad.Size = new Size(80, 19);
            lbl_Actividad.TabIndex = 2;
            lbl_Actividad.Text = "ACTIVIDAD";
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Location = new Point(18, 74);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.Size = new Size(670, 120);
            dgvActividades.TabIndex = 3;
            // 
            // btn_Inscribir
            // 
            btn_Inscribir.Location = new Point(286, 213);
            btn_Inscribir.Name = "btn_Inscribir";
            btn_Inscribir.Size = new Size(134, 38);
            btn_Inscribir.TabIndex = 4;
            btn_Inscribir.Text = "Inscribir";
            btn_Inscribir.UseVisualStyleBackColor = true;
            btn_Inscribir.Click += btn_Inscribir_Click;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(286, 273);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(134, 38);
            btn_Volver.TabIndex = 5;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(227, 14);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(95, 25);
            btn_Buscar.TabIndex = 6;
            btn_Buscar.Text = "BUSCAR";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // Actividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Volver);
            Controls.Add(btn_Inscribir);
            Controls.Add(dgvActividades);
            Controls.Add(lbl_Actividad);
            Controls.Add(txt_DNI);
            Controls.Add(lbl_DNI);
            Name = "Actividad";
            Text = "Actividad";
            Load += Actividad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_DNI;
        private TextBox txt_DNI;
        private Label lbl_Actividad;
        private DataGridView dgvActividades;
        private Button btn_Inscribir;
        private Button btn_Volver;
        private Button btn_Buscar;
    }
}