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
            btn_Inscripcion = new Button();
            groupBox1 = new GroupBox();
            rbTarjeta6 = new RadioButton();
            rbTarjeta3 = new RadioButton();
            rbEfectivo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Font = new Font("Segoe UI", 12F);
            lbl_DNI.Location = new Point(21, 20);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(46, 28);
            lbl_DNI.TabIndex = 0;
            lbl_DNI.Text = "DNI";
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(70, 20);
            txt_DNI.Margin = new Padding(3, 4, 3, 4);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(161, 27);
            txt_DNI.TabIndex = 1;
            // 
            // lbl_Actividad
            // 
            lbl_Actividad.AutoSize = true;
            lbl_Actividad.Font = new Font("Segoe UI", 10F);
            lbl_Actividad.Location = new Point(21, 69);
            lbl_Actividad.Name = "lbl_Actividad";
            lbl_Actividad.Size = new Size(179, 23);
            lbl_Actividad.TabIndex = 2;
            lbl_Actividad.Text = "Listado de Actividades";
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Location = new Point(21, 99);
            dgvActividades.Margin = new Padding(3, 4, 3, 4);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowHeadersWidth = 51;
            dgvActividades.Size = new Size(766, 160);
            dgvActividades.TabIndex = 3;
            dgvActividades.CellContentClick += dgvActividades_CellContentClick;
            // 
            // btn_Inscribir
            // 
            btn_Inscribir.Location = new Point(21, 267);
            btn_Inscribir.Margin = new Padding(3, 4, 3, 4);
            btn_Inscribir.Name = "btn_Inscribir";
            btn_Inscribir.Size = new Size(153, 51);
            btn_Inscribir.TabIndex = 4;
            btn_Inscribir.Text = "Inscribir";
            btn_Inscribir.UseVisualStyleBackColor = true;
            btn_Inscribir.Click += btn_Inscribir_Click;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(21, 368);
            btn_Volver.Margin = new Padding(3, 4, 3, 4);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(153, 51);
            btn_Volver.TabIndex = 5;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(246, 17);
            btn_Buscar.Margin = new Padding(3, 4, 3, 4);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(98, 32);
            btn_Buscar.TabIndex = 6;
            btn_Buscar.Text = "BUSCAR";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // btn_PagarInscribir
            // 
            btn_PagarInscribir.Location = new Point(633, 267);
            btn_PagarInscribir.Margin = new Padding(3, 4, 3, 4);
            btn_PagarInscribir.Name = "btn_PagarInscribir";
            btn_PagarInscribir.Size = new Size(153, 51);
            btn_PagarInscribir.TabIndex = 7;
            btn_PagarInscribir.Text = "Ir a Pagar";
            btn_PagarInscribir.UseVisualStyleBackColor = true;
            btn_PagarInscribir.Click += btn_PagarInscribir_Click;
            // 
            // btn_Inscripcion
            // 
            btn_Inscripcion.Location = new Point(365, 408);
            btn_Inscripcion.Margin = new Padding(3, 4, 3, 4);
            btn_Inscripcion.Name = "btn_Inscripcion";
            btn_Inscripcion.Size = new Size(147, 31);
            btn_Inscripcion.TabIndex = 9;
            btn_Inscripcion.Text = "Inscribir";
            btn_Inscripcion.UseVisualStyleBackColor = true;
            btn_Inscripcion.Click += btn_Inscripcion_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbTarjeta6);
            groupBox1.Controls.Add(rbTarjeta3);
            groupBox1.Controls.Add(rbEfectivo);
            groupBox1.Location = new Point(270, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 131);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // rbTarjeta6
            // 
            rbTarjeta6.AutoSize = true;
            rbTarjeta6.Location = new Point(21, 97);
            rbTarjeta6.Name = "rbTarjeta6";
            rbTarjeta6.Size = new Size(257, 24);
            rbTarjeta6.TabIndex = 8;
            rbTarjeta6.TabStop = true;
            rbTarjeta6.Text = "Tarj de crédito: 6 cuotas sin interes";
            rbTarjeta6.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta3
            // 
            rbTarjeta3.AutoSize = true;
            rbTarjeta3.Location = new Point(21, 67);
            rbTarjeta3.Name = "rbTarjeta3";
            rbTarjeta3.Size = new Size(257, 24);
            rbTarjeta3.TabIndex = 7;
            rbTarjeta3.TabStop = true;
            rbTarjeta3.Text = "Tarj de crédito: 3 cuotas sin interes";
            rbTarjeta3.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(21, 37);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(197, 24);
            rbEfectivo.TabIndex = 6;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo (10% descuento)";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // Actividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 451);
            Controls.Add(groupBox1);
            Controls.Add(btn_Inscripcion);
            Controls.Add(btn_PagarInscribir);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Volver);
            Controls.Add(btn_Inscribir);
            Controls.Add(dgvActividades);
            Controls.Add(lbl_Actividad);
            Controls.Add(txt_DNI);
            Controls.Add(lbl_DNI);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Actividad";
            Text = "Inscripcion de Actividades";
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
        private Button btn_PagarInscribir;
        private Button btn_Inscripcion;
        private GroupBox groupBox1;
        private RadioButton rbTarjeta6;
        private RadioButton rbTarjeta3;
        private RadioButton rbEfectivo;
    }
}