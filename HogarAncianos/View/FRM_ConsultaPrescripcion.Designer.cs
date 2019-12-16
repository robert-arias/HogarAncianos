namespace HogarAncianos.View
{
    partial class FRM_ConsultaPrescripcion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoMedicamento = new System.Windows.Forms.TextBox();
            this.checkBoxCodigoMedicamento = new System.Windows.Forms.CheckBox();
            this.checkBoxFechaCaducidad = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedulaPaciente = new System.Windows.Forms.TextBox();
            this.dtgConsultaPrescripcion = new System.Windows.Forms.DataGridView();
            this.btnReporteMedicamentos = new System.Windows.Forms.Button();
            this.btnTodosLosResultados = new System.Windows.Forms.Button();
            this.txtFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.Prescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPrescrita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPrescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(727, 49);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(622, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 34);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechaCaducidad);
            this.groupBox1.Controls.Add(this.txtCodigoMedicamento);
            this.groupBox1.Controls.Add(this.checkBoxCodigoMedicamento);
            this.groupBox1.Controls.Add(this.checkBoxFechaCaducidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(72)))));
            this.groupBox1.Location = new System.Drawing.Point(57, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 80);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // txtCodigoMedicamento
            // 
            this.txtCodigoMedicamento.Location = new System.Drawing.Point(594, 25);
            this.txtCodigoMedicamento.Name = "txtCodigoMedicamento";
            this.txtCodigoMedicamento.Size = new System.Drawing.Size(134, 26);
            this.txtCodigoMedicamento.TabIndex = 15;
            // 
            // checkBoxCodigoMedicamento
            // 
            this.checkBoxCodigoMedicamento.AutoSize = true;
            this.checkBoxCodigoMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCodigoMedicamento.ForeColor = System.Drawing.Color.White;
            this.checkBoxCodigoMedicamento.Location = new System.Drawing.Point(399, 28);
            this.checkBoxCodigoMedicamento.Name = "checkBoxCodigoMedicamento";
            this.checkBoxCodigoMedicamento.Size = new System.Drawing.Size(182, 24);
            this.checkBoxCodigoMedicamento.TabIndex = 14;
            this.checkBoxCodigoMedicamento.Text = "Codigo medicamento:";
            this.checkBoxCodigoMedicamento.UseVisualStyleBackColor = true;
            // 
            // checkBoxFechaCaducidad
            // 
            this.checkBoxFechaCaducidad.AutoSize = true;
            this.checkBoxFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFechaCaducidad.ForeColor = System.Drawing.Color.White;
            this.checkBoxFechaCaducidad.Location = new System.Drawing.Point(9, 28);
            this.checkBoxFechaCaducidad.Name = "checkBoxFechaCaducidad";
            this.checkBoxFechaCaducidad.Size = new System.Drawing.Size(154, 24);
            this.checkBoxFechaCaducidad.TabIndex = 13;
            this.checkBoxFechaCaducidad.Text = "Fecha caducidad:";
            this.checkBoxFechaCaducidad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cedula del paciente:";
            // 
            // txtCedulaPaciente
            // 
            this.txtCedulaPaciente.Location = new System.Drawing.Point(164, 50);
            this.txtCedulaPaciente.Name = "txtCedulaPaciente";
            this.txtCedulaPaciente.Size = new System.Drawing.Size(440, 20);
            this.txtCedulaPaciente.TabIndex = 10;
            // 
            // dtgConsultaPrescripcion
            // 
            this.dtgConsultaPrescripcion.AllowUserToAddRows = false;
            this.dtgConsultaPrescripcion.AllowUserToDeleteRows = false;
            this.dtgConsultaPrescripcion.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgConsultaPrescripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaPrescripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prescripcion,
            this.Cedula,
            this.Codigo,
            this.Nombre,
            this.CantidadPrescrita,
            this.Fecha});
            this.dtgConsultaPrescripcion.Location = new System.Drawing.Point(41, 204);
            this.dtgConsultaPrescripcion.Name = "dtgConsultaPrescripcion";
            this.dtgConsultaPrescripcion.ReadOnly = true;
            this.dtgConsultaPrescripcion.Size = new System.Drawing.Size(780, 170);
            this.dtgConsultaPrescripcion.TabIndex = 110;
            // 
            // btnReporteMedicamentos
            // 
            this.btnReporteMedicamentos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReporteMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteMedicamentos.Location = new System.Drawing.Point(535, 404);
            this.btnReporteMedicamentos.Name = "btnReporteMedicamentos";
            this.btnReporteMedicamentos.Size = new System.Drawing.Size(256, 34);
            this.btnReporteMedicamentos.TabIndex = 111;
            this.btnReporteMedicamentos.Text = "Realizar reporte de resultados";
            this.btnReporteMedicamentos.UseVisualStyleBackColor = false;
            // 
            // btnTodosLosResultados
            // 
            this.btnTodosLosResultados.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTodosLosResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosLosResultados.Location = new System.Drawing.Point(12, 404);
            this.btnTodosLosResultados.Name = "btnTodosLosResultados";
            this.btnTodosLosResultados.Size = new System.Drawing.Size(256, 34);
            this.btnTodosLosResultados.TabIndex = 112;
            this.btnTodosLosResultados.Text = "Todos los resultados";
            this.btnTodosLosResultados.UseVisualStyleBackColor = false;
            // 
            // txtFechaCaducidad
            // 
            this.txtFechaCaducidad.Enabled = false;
            this.txtFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaCaducidad.Location = new System.Drawing.Point(168, 29);
            this.txtFechaCaducidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaCaducidad.Name = "txtFechaCaducidad";
            this.txtFechaCaducidad.Size = new System.Drawing.Size(183, 23);
            this.txtFechaCaducidad.TabIndex = 117;
            // 
            // Prescripcion
            // 
            this.Prescripcion.DataPropertyName = "num";
            this.Prescripcion.HeaderText = "Prescripcion";
            this.Prescripcion.Name = "Prescripcion";
            this.Prescripcion.ReadOnly = true;
            this.Prescripcion.Width = 80;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "cedula_paciente";
            this.Cedula.HeaderText = "Cedula del paciente";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo_medicamento";
            this.Codigo.HeaderText = "Codigo medicamento";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre_medicamento";
            this.Nombre.HeaderText = "Nombre medicamento";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // CantidadPrescrita
            // 
            this.CantidadPrescrita.DataPropertyName = "cantidad_prescrita";
            this.CantidadPrescrita.HeaderText = "Cantidad prescrita";
            this.CantidadPrescrita.Name = "CantidadPrescrita";
            this.CantidadPrescrita.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha_caducidad";
            this.Fecha.HeaderText = "Fecha de caducidad";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // FRM_ConsultaPrescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.btnTodosLosResultados);
            this.Controls.Add(this.btnReporteMedicamentos);
            this.Controls.Add(this.dtgConsultaPrescripcion);
            this.Controls.Add(this.txtCedulaPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FRM_ConsultaPrescripcion";
            this.Text = "FRM_ConsultaPrescripcion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaPrescripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCedulaPaciente;
        public System.Windows.Forms.DataGridView dtgConsultaPrescripcion;
        public System.Windows.Forms.Button btnReporteMedicamentos;
        public System.Windows.Forms.TextBox txtCodigoMedicamento;
        public System.Windows.Forms.CheckBox checkBoxCodigoMedicamento;
        public System.Windows.Forms.CheckBox checkBoxFechaCaducidad;
        public System.Windows.Forms.Button btnTodosLosResultados;
        private System.Windows.Forms.DateTimePicker txtFechaCaducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPrescrita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}