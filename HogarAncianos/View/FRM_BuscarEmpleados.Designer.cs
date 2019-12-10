namespace HogarAncianos.View {
    partial class FRM_BuscarEmpleados {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEstadoLaboral = new System.Windows.Forms.CheckBox();
            this.ddlEstadoLaboral = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPuestoTrabajo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlPuesto = new System.Windows.Forms.ComboBox();
            this.dtpFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.rbApellidos = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSalario = new System.Windows.Forms.CheckBox();
            this.cbFechaContratacion = new System.Windows.Forms.CheckBox();
            this.cbDireccion = new System.Windows.Forms.CheckBox();
            this.cbCorreo = new System.Windows.Forms.CheckBox();
            this.cbTelefono = new System.Windows.Forms.CheckBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuestoTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoLaboral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(178, 55);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(499, 23);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(684, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEstadoLaboral);
            this.groupBox1.Controls.Add(this.ddlEstadoLaboral);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbPuestoTrabajo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ddlPuesto);
            this.groupBox1.Controls.Add(this.dtpFechaContratacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbApellidos);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbCedula);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(72)))));
            this.groupBox1.Location = new System.Drawing.Point(85, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // cbEstadoLaboral
            // 
            this.cbEstadoLaboral.AutoSize = true;
            this.cbEstadoLaboral.Enabled = false;
            this.cbEstadoLaboral.Location = new System.Drawing.Point(195, 177);
            this.cbEstadoLaboral.Name = "cbEstadoLaboral";
            this.cbEstadoLaboral.Size = new System.Drawing.Size(15, 14);
            this.cbEstadoLaboral.TabIndex = 10;
            this.cbEstadoLaboral.UseVisualStyleBackColor = true;
            // 
            // ddlEstadoLaboral
            // 
            this.ddlEstadoLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEstadoLaboral.Enabled = false;
            this.ddlEstadoLaboral.FormattingEnabled = true;
            this.ddlEstadoLaboral.Items.AddRange(new object[] {
            "Seleccionar",
            "Activo",
            "Inactivo"});
            this.ddlEstadoLaboral.Location = new System.Drawing.Point(219, 171);
            this.ddlEstadoLaboral.Name = "ddlEstadoLaboral";
            this.ddlEstadoLaboral.Size = new System.Drawing.Size(175, 28);
            this.ddlEstadoLaboral.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado laboral:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbPuestoTrabajo
            // 
            this.cbPuestoTrabajo.AutoSize = true;
            this.cbPuestoTrabajo.Enabled = false;
            this.cbPuestoTrabajo.Location = new System.Drawing.Point(195, 128);
            this.cbPuestoTrabajo.Name = "cbPuestoTrabajo";
            this.cbPuestoTrabajo.Size = new System.Drawing.Size(15, 14);
            this.cbPuestoTrabajo.TabIndex = 7;
            this.cbPuestoTrabajo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puesto de trabajo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ddlPuesto
            // 
            this.ddlPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPuesto.Enabled = false;
            this.ddlPuesto.FormattingEnabled = true;
            this.ddlPuesto.Items.AddRange(new object[] {
            "Seleccionar",
            "Administradora",
            "Administrativo",
            "Asistente",
            "Chofer",
            "Cocinera",
            "Cuidador",
            "Enfermera",
            "Guarda",
            "Misceláneo",
            "Nutricionista",
            "Psicóloga",
            "Terapeuta",
            "Trabajadora social"});
            this.ddlPuesto.Location = new System.Drawing.Point(219, 122);
            this.ddlPuesto.Name = "ddlPuesto";
            this.ddlPuesto.Size = new System.Drawing.Size(175, 28);
            this.ddlPuesto.TabIndex = 5;
            // 
            // dtpFechaContratacion
            // 
            this.dtpFechaContratacion.Checked = false;
            this.dtpFechaContratacion.Enabled = false;
            this.dtpFechaContratacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaContratacion.Location = new System.Drawing.Point(195, 77);
            this.dtpFechaContratacion.Name = "dtpFechaContratacion";
            this.dtpFechaContratacion.ShowCheckBox = true;
            this.dtpFechaContratacion.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaContratacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de contratación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbApellidos
            // 
            this.rbApellidos.AutoSize = true;
            this.rbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApellidos.ForeColor = System.Drawing.Color.White;
            this.rbApellidos.Location = new System.Drawing.Point(297, 27);
            this.rbApellidos.Name = "rbApellidos";
            this.rbApellidos.Size = new System.Drawing.Size(91, 24);
            this.rbApellidos.TabIndex = 2;
            this.rbApellidos.Text = "Apellidos";
            this.rbApellidos.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.ForeColor = System.Drawing.Color.White;
            this.rbNombre.Location = new System.Drawing.Point(179, 27);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(83, 24);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Checked = true;
            this.rbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCedula.ForeColor = System.Drawing.Color.White;
            this.rbCedula.Location = new System.Drawing.Point(12, 28);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(156, 24);
            this.rbCedula.TabIndex = 0;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Número de cédula";
            this.rbCedula.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSalario);
            this.groupBox2.Controls.Add(this.cbFechaContratacion);
            this.groupBox2.Controls.Add(this.cbDireccion);
            this.groupBox2.Controls.Add(this.cbCorreo);
            this.groupBox2.Controls.Add(this.cbTelefono);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(72)))));
            this.groupBox2.Location = new System.Drawing.Point(513, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos extra";
            // 
            // cbSalario
            // 
            this.cbSalario.AutoSize = true;
            this.cbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalario.ForeColor = System.Drawing.Color.White;
            this.cbSalario.Location = new System.Drawing.Point(12, 124);
            this.cbSalario.Name = "cbSalario";
            this.cbSalario.Size = new System.Drawing.Size(77, 24);
            this.cbSalario.TabIndex = 5;
            this.cbSalario.Text = "Salario";
            this.cbSalario.UseVisualStyleBackColor = true;
            // 
            // cbFechaContratacion
            // 
            this.cbFechaContratacion.AutoSize = true;
            this.cbFechaContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFechaContratacion.ForeColor = System.Drawing.Color.White;
            this.cbFechaContratacion.Location = new System.Drawing.Point(207, 76);
            this.cbFechaContratacion.Name = "cbFechaContratacion";
            this.cbFechaContratacion.Size = new System.Drawing.Size(187, 24);
            this.cbFechaContratacion.TabIndex = 3;
            this.cbFechaContratacion.Text = "Fecha de contratación";
            this.cbFechaContratacion.UseVisualStyleBackColor = true;
            // 
            // cbDireccion
            // 
            this.cbDireccion.AutoSize = true;
            this.cbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDireccion.ForeColor = System.Drawing.Color.White;
            this.cbDireccion.Location = new System.Drawing.Point(12, 76);
            this.cbDireccion.Name = "cbDireccion";
            this.cbDireccion.Size = new System.Drawing.Size(94, 24);
            this.cbDireccion.TabIndex = 2;
            this.cbDireccion.Text = "Dirección";
            this.cbDireccion.UseVisualStyleBackColor = true;
            // 
            // cbCorreo
            // 
            this.cbCorreo.AutoSize = true;
            this.cbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorreo.ForeColor = System.Drawing.Color.White;
            this.cbCorreo.Location = new System.Drawing.Point(206, 27);
            this.cbCorreo.Name = "cbCorreo";
            this.cbCorreo.Size = new System.Drawing.Size(157, 24);
            this.cbCorreo.TabIndex = 1;
            this.cbCorreo.Text = "Correo electrónico";
            this.cbCorreo.UseVisualStyleBackColor = true;
            // 
            // cbTelefono
            // 
            this.cbTelefono.AutoSize = true;
            this.cbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTelefono.ForeColor = System.Drawing.Color.White;
            this.cbTelefono.Location = new System.Drawing.Point(12, 28);
            this.cbTelefono.Name = "cbTelefono";
            this.cbTelefono.Size = new System.Drawing.Size(157, 24);
            this.cbTelefono.TabIndex = 0;
            this.cbTelefono.Text = "Número telefónico";
            this.cbTelefono.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.nombre,
            this.Apellidos,
            this.FechaNacimiento,
            this.PuestoTrabajo,
            this.Horario,
            this.EstadoLaboral});
            this.dgvResultados.Location = new System.Drawing.Point(43, 348);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.ShowEditingIcon = false;
            this.dgvResultados.Size = new System.Drawing.Size(910, 227);
            this.dgvResultados.TabIndex = 5;
            // 
            // Cedula
            // 
            this.Cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cedula.HeaderText = "Cédula de identidad";
            this.Cedula.MinimumWidth = 147;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 147;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 147;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.FechaNacimiento.MinimumWidth = 147;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 147;
            // 
            // PuestoTrabajo
            // 
            this.PuestoTrabajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PuestoTrabajo.HeaderText = "Puesto de trabajo";
            this.PuestoTrabajo.MinimumWidth = 147;
            this.PuestoTrabajo.Name = "PuestoTrabajo";
            this.PuestoTrabajo.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Horario.HeaderText = "Horario de trabajo";
            this.Horario.MinimumWidth = 147;
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // EstadoLaboral
            // 
            this.EstadoLaboral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EstadoLaboral.HeaderText = "Estado laboral";
            this.EstadoLaboral.MinimumWidth = 147;
            this.EstadoLaboral.Name = "EstadoLaboral";
            this.EstadoLaboral.ReadOnly = true;
            this.EstadoLaboral.Width = 147;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(697, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Realizar reporte de resultados";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(806, 55);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 27);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FRM_BuscarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(992, 624);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_BuscarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar empleados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlPuesto;
        private System.Windows.Forms.ComboBox ddlEstadoLaboral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton rbApellidos;
        public System.Windows.Forms.RadioButton rbNombre;
        public System.Windows.Forms.RadioButton rbCedula;
        public System.Windows.Forms.DateTimePicker dtpFechaContratacion;
        public System.Windows.Forms.CheckBox cbEstadoLaboral;
        public System.Windows.Forms.CheckBox cbPuestoTrabajo;
        public System.Windows.Forms.CheckBox cbSalario;
        public System.Windows.Forms.CheckBox cbFechaContratacion;
        public System.Windows.Forms.CheckBox cbDireccion;
        public System.Windows.Forms.CheckBox cbCorreo;
        public System.Windows.Forms.CheckBox cbTelefono;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuestoTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoLaboral;
    }
}