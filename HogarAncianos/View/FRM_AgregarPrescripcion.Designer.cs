namespace HogarAncianos.View
{
    partial class FRM_AgregarPrescripcion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarmMedicamento = new System.Windows.Forms.Button();
            this.labelCantidadDisponible = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtgMedicamento = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPrescrita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCedula = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnVerificarMedicamento = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVerificarPaciente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.IdPrescripcion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarMedicamento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtFechaCaducidad);
            this.groupBox1.Controls.Add(this.btnEliminarmMedicamento);
            this.groupBox1.Controls.Add(this.labelCantidadDisponible);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.dtgMedicamento);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbCedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnVerificarMedicamento);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(72)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del medicamento";
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarMedicamento.Enabled = false;
            this.btnAgregarMedicamento.FlatAppearance.BorderSize = 0;
            this.btnAgregarMedicamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnAgregarMedicamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnAgregarMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMedicamento.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(538, 34);
            this.btnAgregarMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(78, 29);
            this.btnAgregarMedicamento.TabIndex = 118;
            this.btnAgregarMedicamento.Text = "Agregar";
            this.btnAgregarMedicamento.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 115;
            this.label9.Text = "Fecha de caducidad:";
            // 
            // txtFechaCaducidad
            // 
            this.txtFechaCaducidad.Enabled = false;
            this.txtFechaCaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaCaducidad.Location = new System.Drawing.Point(220, 162);
            this.txtFechaCaducidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaCaducidad.Name = "txtFechaCaducidad";
            this.txtFechaCaducidad.Size = new System.Drawing.Size(183, 23);
            this.txtFechaCaducidad.TabIndex = 116;
            // 
            // btnEliminarmMedicamento
            // 
            this.btnEliminarmMedicamento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarmMedicamento.Enabled = false;
            this.btnEliminarmMedicamento.FlatAppearance.BorderSize = 0;
            this.btnEliminarmMedicamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnEliminarmMedicamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnEliminarmMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarmMedicamento.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarmMedicamento.Location = new System.Drawing.Point(27, 202);
            this.btnEliminarmMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarmMedicamento.Name = "btnEliminarmMedicamento";
            this.btnEliminarmMedicamento.Size = new System.Drawing.Size(75, 35);
            this.btnEliminarmMedicamento.TabIndex = 114;
            this.btnEliminarmMedicamento.Text = "Eliminar";
            this.btnEliminarmMedicamento.UseVisualStyleBackColor = false;
            // 
            // labelCantidadDisponible
            // 
            this.labelCantidadDisponible.AutoSize = true;
            this.labelCantidadDisponible.ForeColor = System.Drawing.Color.White;
            this.labelCantidadDisponible.Location = new System.Drawing.Point(419, 137);
            this.labelCantidadDisponible.Name = "labelCantidadDisponible";
            this.labelCantidadDisponible.Size = new System.Drawing.Size(19, 20);
            this.labelCantidadDisponible.TabIndex = 113;
            this.labelCantidadDisponible.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(419, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 112;
            this.label7.Text = "Cantidad disponible :  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 110;
            this.label6.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(220, 122);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(183, 24);
            this.txtCantidad.TabIndex = 111;
            // 
            // dtgMedicamento
            // 
            this.dtgMedicamento.AllowUserToAddRows = false;
            this.dtgMedicamento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.CantidadPrescrita,
            this.Fecha});
            this.dtgMedicamento.Location = new System.Drawing.Point(128, 202);
            this.dtgMedicamento.Name = "dtgMedicamento";
            this.dtgMedicamento.Size = new System.Drawing.Size(526, 170);
            this.dtgMedicamento.TabIndex = 109;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 120;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 120;
            // 
            // CantidadPrescrita
            // 
            this.CantidadPrescrita.HeaderText = "Cantidad Prescrita";
            this.CantidadPrescrita.Name = "CantidadPrescrita";
            this.CantidadPrescrita.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de caducidad";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 120;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1084, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 29);
            this.button1.TabIndex = 107;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(1051, 45);
            this.lbCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(14, 18);
            this.lbCedula.TabIndex = 106;
            this.lbCedula.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1051, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 18);
            this.label3.TabIndex = 105;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(220, 81);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 24);
            this.txtNombre.TabIndex = 99;
            // 
            // btnVerificarMedicamento
            // 
            this.btnVerificarMedicamento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerificarMedicamento.Enabled = false;
            this.btnVerificarMedicamento.FlatAppearance.BorderSize = 0;
            this.btnVerificarMedicamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnVerificarMedicamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnVerificarMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarMedicamento.ForeColor = System.Drawing.Color.Black;
            this.btnVerificarMedicamento.Location = new System.Drawing.Point(446, 34);
            this.btnVerificarMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerificarMedicamento.Name = "btnVerificarMedicamento";
            this.btnVerificarMedicamento.Size = new System.Drawing.Size(69, 29);
            this.btnVerificarMedicamento.TabIndex = 97;
            this.btnVerificarMedicamento.Text = "Verificar";
            this.btnVerificarMedicamento.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(220, 39);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(183, 24);
            this.txtCodigo.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Codigo del medicamento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnVerificarPaciente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNombrePaciente);
            this.groupBox2.Controls.Add(this.txtCedula);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(72)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del paciente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(547, 32);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 29);
            this.btnLimpiar.TabIndex = 121;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnVerificarPaciente
            // 
            this.btnVerificarPaciente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerificarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnVerificarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnVerificarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarPaciente.ForeColor = System.Drawing.Color.Black;
            this.btnVerificarPaciente.Location = new System.Drawing.Point(459, 32);
            this.btnVerificarPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerificarPaciente.Name = "btnVerificarPaciente";
            this.btnVerificarPaciente.Size = new System.Drawing.Size(69, 29);
            this.btnVerificarPaciente.TabIndex = 120;
            this.btnVerificarPaciente.Text = "Verificar";
            this.btnVerificarPaciente.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Nombre:";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Enabled = false;
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(220, 78);
            this.txtNombrePaciente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(308, 24);
            this.txtNombrePaciente.TabIndex = 119;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(220, 37);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(183, 24);
            this.txtCedula.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 116;
            this.label5.Text = "Cédula de identidad:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(380, 566);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 41);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(228, 566);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 41);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // tbNumero
            // 
            this.tbNumero.Enabled = false;
            this.tbNumero.Location = new System.Drawing.Point(605, 12);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(120, 20);
            this.tbNumero.TabIndex = 22;
            // 
            // IdPrescripcion
            // 
            this.IdPrescripcion.AutoSize = true;
            this.IdPrescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPrescripcion.ForeColor = System.Drawing.Color.White;
            this.IdPrescripcion.Location = new System.Drawing.Point(459, 13);
            this.IdPrescripcion.Name = "IdPrescripcion";
            this.IdPrescripcion.Size = new System.Drawing.Size(129, 16);
            this.IdPrescripcion.TabIndex = 23;
            this.IdPrescripcion.Text = "Codigo prescripcion";
            // 
            // FRM_AgregarPrescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(757, 612);
            this.Controls.Add(this.IdPrescripcion);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_AgregarPrescripcion";
            this.Text = "FRM_AgregarPrescripcion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicamento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lbCedula;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dtgMedicamento;
        public System.Windows.Forms.Label labelCantidadDisponible;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Button btnVerificarMedicamento;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Button btnVerificarPaciente;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombrePaciente;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        public System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        public System.Windows.Forms.DataGridViewTextBoxColumn CantidadPrescrita;
        public System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        public System.Windows.Forms.Button btnEliminarmMedicamento;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtFechaCaducidad;
        public System.Windows.Forms.Button btnAgregarMedicamento;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.TextBox tbNumero;
        public System.Windows.Forms.Label IdPrescripcion;
    }
}