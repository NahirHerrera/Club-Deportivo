namespace Club_Deportivo
{
    partial class Listado
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dtgvCuota = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Vencimiento = new DataGridViewTextBoxColumn();
            btnVolverListado = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvCuota).BeginInit();
            SuspendLayout();
            // 
            // dtgvCuota
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgvCuota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgvCuota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCuota.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Documento, Monto, Vencimiento });
            dtgvCuota.Location = new Point(54, 32);
            dtgvCuota.Name = "dtgvCuota";
            dtgvCuota.RowHeadersWidth = 51;
            dtgvCuota.Size = new Size(672, 172);
            dtgvCuota.TabIndex = 0;
            // 
            // Nombre
            // 
            dataGridViewCellStyle8.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nombre.DefaultCellStyle = dataGridViewCellStyle8;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            dataGridViewCellStyle9.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Apellido.DefaultCellStyle = dataGridViewCellStyle9;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Documento
            // 
            dataGridViewCellStyle10.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Documento.DefaultCellStyle = dataGridViewCellStyle10;
            Documento.HeaderText = "Documento";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento";
            Documento.Width = 125;
            // 
            // Monto
            // 
            dataGridViewCellStyle11.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Monto.DefaultCellStyle = dataGridViewCellStyle11;
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.Width = 125;
            // 
            // Vencimiento
            // 
            Vencimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Vencimiento.DefaultCellStyle = dataGridViewCellStyle12;
            Vencimiento.HeaderText = "Vencimiento";
            Vencimiento.MinimumWidth = 6;
            Vencimiento.Name = "Vencimiento";
            Vencimiento.Width = 129;
            // 
            // btnVolverListado
            // 
            btnVolverListado.Location = new Point(573, 339);
            btnVolverListado.Name = "btnVolverListado";
            btnVolverListado.Size = new Size(153, 51);
            btnVolverListado.TabIndex = 9;
            btnVolverListado.Text = "Volver";
            btnVolverListado.UseVisualStyleBackColor = true;
            btnVolverListado.Click += btnVolverListado_Click;
            // 
            // Listado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolverListado);
            Controls.Add(dtgvCuota);
            Name = "Listado";
            Text = "Emitir listado de deudores";
            Load += Listado_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCuota).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvCuota;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Vencimiento;
        private Button btnVolverListado;
    }
}