namespace HogarAncianos.View
{
    partial class FRM_ConsultaPacientes
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
            this.btnReportePacientes = new System.Windows.Forms.Button();
            this.dtgPacientes = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCedula = new System.Windows.Forms.CheckBox();
            this.checkBoxEdad = new System.Windows.Forms.CheckBox();
            this.checkBoxApellidos = new System.Windows.Forms.CheckBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.checkBoxSexo = new System.Windows.Forms.CheckBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTodosLosResultados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportePacientes
            // 
            this.btnReportePacientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReportePacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePacientes.Location = new System.Drawing.Point(590, 499);
            this.btnReportePacientes.Name = "btnReportePacientes";
            this.btnReportePacientes.Size = new System.Drawing.Size(256, 31);
            this.btnReportePacientes.TabIndex = 21;
            this.btnReportePacientes.Text = "Realizar reporte de resultados";
            this.btnReportePacientes.UseVisualStyleBackColor = false;
            // 
            // dtgPacientes
            // 
            this.dtgPacientes.AllowUserToAddRows = false;
            this.dtgPacientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Apellidos,
            this.Fecha,
            this.Edad,
            this.Sexo});
            this.dtgPacientes.Location = new System.Drawing.Point(117, 284);
            this.dtgPacientes.Name = "dtgPacientes";
            this.dtgPacientes.Size = new System.Drawing.Size(645, 196);
            this.dtgPacientes.TabIndex = 20;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha_nacimiento";
            this.Fecha.HeaderText = "Fecha de Nacimiento";
            this.Fecha.Name = "Fecha";
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCedula);
            this.groupBox1.Controls.Add(this.checkBoxEdad);
            this.groupBox1.Controls.Add(this.checkBoxApellidos);
            this.groupBox1.Controls.Add(this.checkBoxNombre);
            this.groupBox1.Controls.Add(this.checkBoxSexo);
            this.groupBox1.Controls.Add(this.gbSexo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(72)))));
            this.groupBox1.Location = new System.Drawing.Point(129, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 194);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // checkBoxCedula
            // 
            this.checkBoxCedula.AutoSize = true;
            this.checkBoxCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCedula.ForeColor = System.Drawing.Color.White;
            this.checkBoxCedula.Location = new System.Drawing.Point(36, 25);
            this.checkBoxCedula.Name = "checkBoxCedula";
            this.checkBoxCedula.Size = new System.Drawing.Size(78, 24);
            this.checkBoxCedula.TabIndex = 25;
            this.checkBoxCedula.Text = "Cedula";
            this.checkBoxCedula.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdad
            // 
            this.checkBoxEdad.AutoSize = true;
            this.checkBoxEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEdad.ForeColor = System.Drawing.Color.White;
            this.checkBoxEdad.Location = new System.Drawing.Point(467, 25);
            this.checkBoxEdad.Name = "checkBoxEdad";
            this.checkBoxEdad.Size = new System.Drawing.Size(66, 24);
            this.checkBoxEdad.TabIndex = 24;
            this.checkBoxEdad.Text = "Edad";
            this.checkBoxEdad.UseVisualStyleBackColor = true;
            // 
            // checkBoxApellidos
            // 
            this.checkBoxApellidos.AutoSize = true;
            this.checkBoxApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxApellidos.ForeColor = System.Drawing.Color.White;
            this.checkBoxApellidos.Location = new System.Drawing.Point(317, 25);
            this.checkBoxApellidos.Name = "checkBoxApellidos";
            this.checkBoxApellidos.Size = new System.Drawing.Size(92, 24);
            this.checkBoxApellidos.TabIndex = 23;
            this.checkBoxApellidos.Text = "Apellidos";
            this.checkBoxApellidos.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNombre.ForeColor = System.Drawing.Color.White;
            this.checkBoxNombre.Location = new System.Drawing.Point(167, 25);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(84, 24);
            this.checkBoxNombre.TabIndex = 22;
            this.checkBoxNombre.Text = "Nombre";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // checkBoxSexo
            // 
            this.checkBoxSexo.AutoSize = true;
            this.checkBoxSexo.Location = new System.Drawing.Point(36, 100);
            this.checkBoxSexo.Name = "checkBoxSexo";
            this.checkBoxSexo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSexo.TabIndex = 17;
            this.checkBoxSexo.UseVisualStyleBackColor = true;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rbMasculino);
            this.gbSexo.Controls.Add(this.rbFemenino);
            this.gbSexo.Enabled = false;
            this.gbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.ForeColor = System.Drawing.Color.White;
            this.gbSexo.Location = new System.Drawing.Point(75, 89);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(247, 75);
            this.gbSexo.TabIndex = 16;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.ForeColor = System.Drawing.Color.White;
            this.rbMasculino.Location = new System.Drawing.Point(143, 35);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbMasculino.TabIndex = 11;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.ForeColor = System.Drawing.Color.White;
            this.rbFemenino.Location = new System.Drawing.Point(17, 35);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(98, 24);
            this.rbFemenino.TabIndex = 10;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(718, 37);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 31);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(596, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 31);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(129, 37);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(442, 20);
            this.txtBuscar.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Búsqueda:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTodosLosResultados
            // 
            this.btnTodosLosResultados.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTodosLosResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosLosResultados.Location = new System.Drawing.Point(55, 499);
            this.btnTodosLosResultados.Name = "btnTodosLosResultados";
            this.btnTodosLosResultados.Size = new System.Drawing.Size(260, 31);
            this.btnTodosLosResultados.TabIndex = 22;
            this.btnTodosLosResultados.Text = "Todos los resultados";
            this.btnTodosLosResultados.UseVisualStyleBackColor = false;
            // 
            // FRM_ConsultaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(889, 552);
            this.Controls.Add(this.btnTodosLosResultados);
            this.Controls.Add(this.btnReportePacientes);
            this.Controls.Add(this.dtgPacientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FRM_ConsultaPacientes";
            this.Text = "FRM_ConsultaPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnReportePacientes;
        public System.Windows.Forms.DataGridView dtgPacientes;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton rbMasculino;
        public System.Windows.Forms.RadioButton rbFemenino;
        public System.Windows.Forms.Button btnTodosLosResultados;
        private System.Windows.Forms.GroupBox gbSexo;
        public System.Windows.Forms.CheckBox checkBoxSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        public System.Windows.Forms.CheckBox checkBoxCedula;
        public System.Windows.Forms.CheckBox checkBoxEdad;
        public System.Windows.Forms.CheckBox checkBoxApellidos;
        public System.Windows.Forms.CheckBox checkBoxNombre;
    }
}