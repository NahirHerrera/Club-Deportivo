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
            btn_PagarInscribir = new Button();
            groupBox1 = new GroupBox();
            lbl_Total = new Label();
            rd_Transferencia = new RadioButton();
            rd_Tarjeta = new RadioButton();
            rd_Efectivo = new RadioButton();
            btn_Inscripcion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            groupBox1.SuspendLayout();
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
            dgvActividades.RowHeadersWidth = 51;
            dgvActividades.Size = new Size(670, 120);
            dgvActividades.TabIndex = 3;
            dgvActividades.CellContentClick += dgvActividades_CellContentClick;
            // 
            // btn_Inscribir
            // 
            btn_Inscribir.Location = new Point(18, 200);
            btn_Inscribir.Name = "btn_Inscribir";
            btn_Inscribir.Size = new Size(134, 38);
            btn_Inscribir.TabIndex = 4;
            btn_Inscribir.Text = "Inscribir";
            btn_Inscribir.UseVisualStyleBackColor = true;
            btn_Inscribir.Click += btn_Inscribir_Click;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(18, 276);
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
            // btn_PagarInscribir
            // 
            btn_PagarInscribir.Location = new Point(554, 200);
            btn_PagarInscribir.Name = "btn_PagarInscribir";
            btn_PagarInscribir.Size = new Size(134, 38);
            btn_PagarInscribir.TabIndex = 7;
            btn_PagarInscribir.Text = "Ir a Pagar";
            btn_PagarInscribir.UseVisualStyleBackColor = true;
            btn_PagarInscribir.Click += btn_PagarInscribir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_Total);
            groupBox1.Controls.Add(rd_Transferencia);
            groupBox1.Controls.Add(rd_Tarjeta);
            groupBox1.Controls.Add(rd_Efectivo);
            groupBox1.Location = new Point(281, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Location = new Point(38, 23);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(19, 15);
            lbl_Total.TabIndex = 3;
            lbl_Total.Text = "$0";
            // 
            // rd_Transferencia
            // 
            rd_Transferencia.AutoSize = true;
            rd_Transferencia.Location = new Point(143, 52);
            rd_Transferencia.Name = "rd_Transferencia";
            rd_Transferencia.Size = new Size(95, 19);
            rd_Transferencia.TabIndex = 2;
            rd_Transferencia.TabStop = true;
            rd_Transferencia.Text = "Transferencia";
            rd_Transferencia.UseVisualStyleBackColor = true;
            // 
            // rd_Tarjeta
            // 
            rd_Tarjeta.AutoSize = true;
            rd_Tarjeta.Location = new Point(77, 52);
            rd_Tarjeta.Name = "rd_Tarjeta";
            rd_Tarjeta.Size = new Size(60, 19);
            rd_Tarjeta.TabIndex = 1;
            rd_Tarjeta.TabStop = true;
            rd_Tarjeta.Text = "Tarjeta";
            rd_Tarjeta.UseVisualStyleBackColor = true;
            // 
            // rd_Efectivo
            // 
            rd_Efectivo.AutoSize = true;
            rd_Efectivo.Location = new Point(4, 52);
            rd_Efectivo.Name = "rd_Efectivo";
            rd_Efectivo.Size = new Size(67, 19);
            rd_Efectivo.TabIndex = 0;
            rd_Efectivo.TabStop = true;
            rd_Efectivo.Text = "Efectivo";
            rd_Efectivo.UseVisualStyleBackColor = true;
            // 
            // btn_Inscripcion
            // 
            btn_Inscripcion.Location = new Point(319, 306);
            btn_Inscripcion.Name = "btn_Inscripcion";
            btn_Inscripcion.Size = new Size(129, 23);
            btn_Inscripcion.TabIndex = 9;
            btn_Inscripcion.Text = "Inscribir";
            btn_Inscripcion.UseVisualStyleBackColor = true;
            btn_Inscripcion.Click += btn_Inscripcion_Click;
            // 
            // Actividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_Inscripcion);
            Controls.Add(groupBox1);
            Controls.Add(btn_PagarInscribir);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btn_PagarInscribir;
        private GroupBox groupBox1;
        private RadioButton rd_Transferencia;
        private RadioButton rd_Tarjeta;
        private RadioButton rd_Efectivo;
        private Button btn_Inscripcion;
        private Label lbl_Total;
    }
}