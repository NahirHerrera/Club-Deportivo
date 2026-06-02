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
            btn_Volver = new Button();
            btn_Buscar = new Button();
            groupBox1 = new GroupBox();
            rbTarjeta6 = new RadioButton();
            rbTarjeta3 = new RadioButton();
            rbEfectivo = new RadioButton();
            pagarAct = new Button();
            btn_Inscribir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DNI.Location = new Point(21, 22);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(43, 25);
            lbl_DNI.TabIndex = 0;
            lbl_DNI.Text = "DNI";
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(70, 22);
            txt_DNI.Margin = new Padding(3, 4, 3, 4);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(161, 27);
            txt_DNI.TabIndex = 1;
            txt_DNI.Text = "29445114";
            // 
            // lbl_Actividad
            // 
            lbl_Actividad.AutoSize = true;
            lbl_Actividad.Font = new Font("Segoe UI", 10F);
            lbl_Actividad.Location = new Point(21, 69);
            lbl_Actividad.Name = "lbl_Actividad";
            lbl_Actividad.Size = new Size(96, 23);
            lbl_Actividad.TabIndex = 2;
            lbl_Actividad.Text = "Actividades";
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
            dgvActividades.Size = new Size(750, 147);
            dgvActividades.TabIndex = 3;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(537, 383);
            btn_Volver.Margin = new Padding(3, 4, 3, 4);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(153, 55);
            btn_Volver.TabIndex = 5;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(246, 20);
            btn_Buscar.Margin = new Padding(3, 4, 3, 4);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(102, 31);
            btn_Buscar.TabIndex = 6;
            btn_Buscar.Text = "BUSCAR";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbTarjeta6);
            groupBox1.Controls.Add(rbTarjeta3);
            groupBox1.Controls.Add(rbEfectivo);
            groupBox1.Location = new Point(103, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 114);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // rbTarjeta6
            // 
            rbTarjeta6.AutoSize = true;
            rbTarjeta6.Location = new Point(21, 87);
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
            rbTarjeta3.Location = new Point(21, 57);
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
            rbEfectivo.Location = new Point(21, 27);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(197, 24);
            rbEfectivo.TabIndex = 6;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo (10% descuento)";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // pagarAct
            // 
            pagarAct.ForeColor = Color.Red;
            pagarAct.Location = new Point(537, 263);
            pagarAct.Margin = new Padding(3, 4, 3, 4);
            pagarAct.Name = "pagarAct";
            pagarAct.Size = new Size(153, 51);
            pagarAct.TabIndex = 8;
            pagarAct.Text = "Pagar Actividad";
            pagarAct.UseVisualStyleBackColor = true;
            pagarAct.Click += pagarAct_Click;
            // 
            // btn_Inscribir
            // 
            btn_Inscribir.Location = new Point(537, 323);
            btn_Inscribir.Margin = new Padding(3, 4, 3, 4);
            btn_Inscribir.Name = "btn_Inscribir";
            btn_Inscribir.Size = new Size(153, 51);
            btn_Inscribir.TabIndex = 9;
            btn_Inscribir.Text = "Inscribir";
            btn_Inscribir.UseVisualStyleBackColor = true;
            btn_Inscribir.Click += btn_Inscribir_Click;
            // 
            // Actividad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 451);
            Controls.Add(btn_Inscribir);
            Controls.Add(pagarAct);
            Controls.Add(groupBox1);
            Controls.Add(btn_Buscar);
            Controls.Add(btn_Volver);
            Controls.Add(dgvActividades);
            Controls.Add(lbl_Actividad);
            Controls.Add(txt_DNI);
            Controls.Add(lbl_DNI);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Actividad";
            Text = "Cobrar Actividad";
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
        private Button btn_Volver;
        private Button btn_Buscar;
        private GroupBox groupBox1;
        private RadioButton rbTarjeta6;
        private RadioButton rbTarjeta3;
        private RadioButton rbEfectivo;
        private Button pagarAct;
        private Button btn_Inscribir;
    }
}