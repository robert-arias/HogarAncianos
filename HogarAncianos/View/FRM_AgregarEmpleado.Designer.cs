﻿namespace HogarAncianos.View {
    partial class FRM_AgregarEmpleado {
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarCorreo = new System.Windows.Forms.Button();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbFechaNacimiento = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvCorreos = new System.Windows.Forms.DataGridView();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnAgregarCorreo = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbFechaContratacion = new System.Windows.Forms.Label();
            this.lbSalario = new System.Windows.Forms.Label();
            this.lbHorario = new System.Windows.Forms.Label();
            this.lbPuesto = new System.Windows.Forms.Label();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.txtFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEliminarCorreo);
            this.groupBox1.Controls.Add(this.lbCedula);
            this.groupBox1.Controls.Add(this.lbDireccion);
            this.groupBox1.Controls.Add(this.lbTelefono);
            this.groupBox1.Controls.Add(this.lbFechaNacimiento);
            this.groupBox1.Controls.Add(this.lbApellidos);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.dgvCorreos);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.btnAgregarCorreo);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtCorreos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.btnVerificar);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información personal";
            // 
            // btnEliminarCorreo
            // 
            this.btnEliminarCorreo.Enabled = false;
            this.btnEliminarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCorreo.Location = new System.Drawing.Point(466, 242);
            this.btnEliminarCorreo.Name = "btnEliminarCorreo";
            this.btnEliminarCorreo.Size = new System.Drawing.Size(82, 31);
            this.btnEliminarCorreo.TabIndex = 31;
            this.btnEliminarCorreo.Text = "Eliminar";
            this.toolTip1.SetToolTip(this.btnEliminarCorreo, "Debe seleccionar el correo que desea eliminar.");
            this.btnEliminarCorreo.UseVisualStyleBackColor = true;
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(434, 37);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(15, 20);
            this.lbCedula.TabIndex = 30;
            this.lbCedula.Text = "*";
            this.toolTip1.SetToolTip(this.lbCedula, "Sin guiones.\nDebe ser de al menos 9 carácteres.");
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(945, 88);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(15, 20);
            this.lbDireccion.TabIndex = 29;
            this.lbDireccion.Text = "*";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(434, 249);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(15, 20);
            this.lbTelefono.TabIndex = 28;
            this.lbTelefono.Text = "*";
            // 
            // lbFechaNacimiento
            // 
            this.lbFechaNacimiento.AutoSize = true;
            this.lbFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaNacimiento.Location = new System.Drawing.Point(434, 198);
            this.lbFechaNacimiento.Name = "lbFechaNacimiento";
            this.lbFechaNacimiento.Size = new System.Drawing.Size(15, 20);
            this.lbFechaNacimiento.TabIndex = 27;
            this.lbFechaNacimiento.Text = "*";
            this.toolTip1.SetToolTip(this.lbFechaNacimiento, "Debe ser mayor de edad.");
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.Location = new System.Drawing.Point(434, 145);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(15, 20);
            this.lbApellidos.TabIndex = 26;
            this.lbApellidos.Text = "*";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(434, 92);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(15, 20);
            this.lbNombre.TabIndex = 25;
            this.lbNombre.Text = "*";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(554, 30);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 28);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvCorreos
            // 
            this.dgvCorreos.AllowUserToAddRows = false;
            this.dgvCorreos.AllowUserToDeleteRows = false;
            this.dgvCorreos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorreos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correo});
            this.dgvCorreos.Enabled = false;
            this.dgvCorreos.Location = new System.Drawing.Point(554, 242);
            this.dgvCorreos.Name = "dgvCorreos";
            this.dgvCorreos.ReadOnly = true;
            this.dgvCorreos.RowTemplate.Height = 24;
            this.dgvCorreos.Size = new System.Drawing.Size(387, 90);
            this.dgvCorreos.TabIndex = 22;
            // 
            // correo
            // 
            this.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(554, 190);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(299, 27);
            this.txtCorreo.TabIndex = 21;
            // 
            // btnAgregarCorreo
            // 
            this.btnAgregarCorreo.Enabled = false;
            this.btnAgregarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCorreo.Location = new System.Drawing.Point(859, 190);
            this.btnAgregarCorreo.Name = "btnAgregarCorreo";
            this.btnAgregarCorreo.Size = new System.Drawing.Size(82, 28);
            this.btnAgregarCorreo.TabIndex = 20;
            this.btnAgregarCorreo.Text = "Agregar";
            this.btnAgregarCorreo.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(185, 242);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(244, 27);
            this.txtTelefono.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(554, 85);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(387, 77);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCorreos
            // 
            this.txtCorreos.AutoSize = true;
            this.txtCorreos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreos.Location = new System.Drawing.Point(462, 191);
            this.txtCorreos.Name = "txtCorreos";
            this.txtCorreos.Size = new System.Drawing.Size(74, 20);
            this.txtCorreos.TabIndex = 14;
            this.txtCorreos.Text = "Correos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de teléfono:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(186, 138);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(243, 27);
            this.txtApellidos.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(185, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 27);
            this.txtNombre.TabIndex = 16;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(186, 191);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(243, 27);
            this.txtFechaNacimiento.TabIndex = 12;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(466, 30);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(82, 28);
            this.btnVerificar.TabIndex = 13;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(185, 30);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(243, 27);
            this.txtCedula.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula de identidad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbFechaContratacion);
            this.groupBox2.Controls.Add(this.lbSalario);
            this.groupBox2.Controls.Add(this.lbHorario);
            this.groupBox2.Controls.Add(this.lbPuesto);
            this.groupBox2.Controls.Add(this.cbPuesto);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.rbInactivo);
            this.groupBox2.Controls.Add(this.rbActivo);
            this.groupBox2.Controls.Add(this.txtFechaContratacion);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSalario);
            this.groupBox2.Controls.Add(this.txtHorario);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información laboral";
            // 
            // lbFechaContratacion
            // 
            this.lbFechaContratacion.AutoSize = true;
            this.lbFechaContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaContratacion.Location = new System.Drawing.Point(945, 33);
            this.lbFechaContratacion.Name = "lbFechaContratacion";
            this.lbFechaContratacion.Size = new System.Drawing.Size(15, 20);
            this.lbFechaContratacion.TabIndex = 35;
            this.lbFechaContratacion.Text = "*";
            // 
            // lbSalario
            // 
            this.lbSalario.AutoSize = true;
            this.lbSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalario.Location = new System.Drawing.Point(434, 140);
            this.lbSalario.Name = "lbSalario";
            this.lbSalario.Size = new System.Drawing.Size(15, 20);
            this.lbSalario.TabIndex = 34;
            this.lbSalario.Text = "*";
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorario.Location = new System.Drawing.Point(434, 87);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(15, 20);
            this.lbHorario.TabIndex = 33;
            this.lbHorario.Text = "*";
            // 
            // lbPuesto
            // 
            this.lbPuesto.AutoSize = true;
            this.lbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuesto.Location = new System.Drawing.Point(434, 31);
            this.lbPuesto.Name = "lbPuesto";
            this.lbPuesto.Size = new System.Drawing.Size(15, 20);
            this.lbPuesto.TabIndex = 32;
            this.lbPuesto.Text = "*";
            // 
            // cbPuesto
            // 
            this.cbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuesto.Enabled = false;
            this.cbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPuesto.Items.AddRange(new object[] {
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
            this.cbPuesto.Location = new System.Drawing.Point(194, 25);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(234, 28);
            this.cbPuesto.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(197, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "₡";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Enabled = false;
            this.rbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.Location = new System.Drawing.Point(854, 76);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(87, 24);
            this.rbInactivo.TabIndex = 29;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Enabled = false;
            this.rbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.Location = new System.Drawing.Point(643, 77);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(76, 24);
            this.rbActivo.TabIndex = 28;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // txtFechaContratacion
            // 
            this.txtFechaContratacion.Enabled = false;
            this.txtFechaContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaContratacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaContratacion.Location = new System.Drawing.Point(648, 26);
            this.txtFechaContratacion.Name = "txtFechaContratacion";
            this.txtFechaContratacion.Size = new System.Drawing.Size(293, 27);
            this.txtFechaContratacion.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(462, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Estado laboral:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(462, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fecha de contratación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Horario de trabajo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Salario base mensual:";
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(224, 133);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(204, 27);
            this.txtSalario.TabIndex = 24;
            // 
            // txtHorario
            // 
            this.txtHorario.Enabled = false;
            this.txtHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(194, 80);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(234, 27);
            this.txtHorario.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Puesto de trabajo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(327, 575);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 28);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(498, 575);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 28);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FRM_AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 624);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRM_AgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar empleados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
        private System.Windows.Forms.DataGridView dgvCorreos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCorreos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.DateTimePicker txtFechaContratacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnAgregarCorreo;
        public System.Windows.Forms.Button btnVerificar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbFechaContratacion;
        private System.Windows.Forms.Label lbSalario;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.Label lbPuesto;
        private System.Windows.Forms.Label lbFechaNacimiento;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnEliminarCorreo;
    }
}