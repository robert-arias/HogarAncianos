namespace HogarAncianos.View
{
    partial class FRM_ConsultaMedicamentos
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.dtgMedicamentos = new System.Windows.Forms.DataGridView();
            this.btnReporteMedicamentos = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(651, 41);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 31);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(529, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 31);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(136, 44);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(386, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Búsqueda:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(136, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 76);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(265, 20);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(62, 17);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(108, 20);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // dtgMedicamentos
            // 
            this.dtgMedicamentos.AllowUserToAddRows = false;
            this.dtgMedicamentos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Categoria,
            this.Unidad,
            this.CantidadD,
            this.CantidadP});
            this.dtgMedicamentos.Location = new System.Drawing.Point(74, 194);
            this.dtgMedicamentos.Name = "dtgMedicamentos";
            this.dtgMedicamentos.Size = new System.Drawing.Size(645, 196);
            this.dtgMedicamentos.TabIndex = 13;
            // 
            // btnReporteMedicamentos
            // 
            this.btnReporteMedicamentos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReporteMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteMedicamentos.Location = new System.Drawing.Point(463, 448);
            this.btnReporteMedicamentos.Name = "btnReporteMedicamentos";
            this.btnReporteMedicamentos.Size = new System.Drawing.Size(256, 26);
            this.btnReporteMedicamentos.TabIndex = 14;
            this.btnReporteMedicamentos.Text = "Realizar reporte de resultados";
            this.btnReporteMedicamentos.UseVisualStyleBackColor = false;
            // 
            // btnResultados
            // 
            this.btnResultados.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.Location = new System.Drawing.Point(59, 448);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(256, 26);
            this.btnResultados.TabIndex = 15;
            this.btnResultados.Text = "Todos los resultados";
            this.btnResultados.UseVisualStyleBackColor = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo_medicamento";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_medicamento";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "unidad_medida";
            this.Unidad.HeaderText = "Unidad Medida";
            this.Unidad.Name = "Unidad";
            // 
            // CantidadD
            // 
            this.CantidadD.DataPropertyName = "cantidad_disponible";
            this.CantidadD.HeaderText = "Cantidad Disponible";
            this.CantidadD.Name = "CantidadD";
            // 
            // CantidadP
            // 
            this.CantidadP.DataPropertyName = "cantidad_prescrita";
            this.CantidadP.HeaderText = "Cantidad Prescrita";
            this.CantidadP.Name = "CantidadP";
            // 
            // FRM_ConsultaMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(816, 505);
            this.Controls.Add(this.btnResultados);
            this.Controls.Add(this.btnReporteMedicamentos);
            this.Controls.Add(this.dtgMedicamentos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FRM_ConsultaMedicamentos";
            this.Text = "FRM_ConsultaMedicamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgMedicamentos;
        public System.Windows.Forms.Button btnReporteMedicamentos;
        public System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadP;
    }
}