namespace HogarAncianos.View
{
    partial class FRM_BuscarProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbHigiene = new System.Windows.Forms.RadioButton();
            this.rbLimipieza = new System.Windows.Forms.RadioButton();
            this.rbTipo = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbIdentificador = new System.Windows.Forms.RadioButton();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbHistorialEntradas = new System.Windows.Forms.Label();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.fecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_ingresada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbHistorialSalidas = new System.Windows.Forms.Label();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_extraida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Búsqueda:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(120, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(406, 26);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(531, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rbTipo);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbIdentificador);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(32, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dtpSalida);
            this.groupBox3.Controls.Add(this.dtpIngreso);
            this.groupBox3.Location = new System.Drawing.Point(12, 71);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(262, 84);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha salida:";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Checked = false;
            this.dtpSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(116, 51);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.ShowCheckBox = true;
            this.dtpSalida.Size = new System.Drawing.Size(142, 26);
            this.dtpSalida.TabIndex = 8;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Checked = false;
            this.dtpIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(116, 15);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.ShowCheckBox = true;
            this.dtpIngreso.Size = new System.Drawing.Size(142, 26);
            this.dtpIngreso.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbHigiene);
            this.groupBox2.Controls.Add(this.rbLimipieza);
            this.groupBox2.Location = new System.Drawing.Point(292, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(255, 84);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // rbHigiene
            // 
            this.rbHigiene.AutoSize = true;
            this.rbHigiene.Checked = true;
            this.rbHigiene.Enabled = false;
            this.rbHigiene.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHigiene.ForeColor = System.Drawing.Color.White;
            this.rbHigiene.Location = new System.Drawing.Point(9, 17);
            this.rbHigiene.Name = "rbHigiene";
            this.rbHigiene.Size = new System.Drawing.Size(146, 24);
            this.rbHigiene.TabIndex = 5;
            this.rbHigiene.TabStop = true;
            this.rbHigiene.Text = "Higiene personal";
            this.rbHigiene.UseVisualStyleBackColor = true;
            // 
            // rbLimipieza
            // 
            this.rbLimipieza.AutoSize = true;
            this.rbLimipieza.Enabled = false;
            this.rbLimipieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLimipieza.ForeColor = System.Drawing.Color.White;
            this.rbLimipieza.Location = new System.Drawing.Point(9, 51);
            this.rbLimipieza.Name = "rbLimipieza";
            this.rbLimipieza.Size = new System.Drawing.Size(90, 24);
            this.rbLimipieza.TabIndex = 11;
            this.rbLimipieza.Text = "Limpieza";
            this.rbLimipieza.UseVisualStyleBackColor = true;
            // 
            // rbTipo
            // 
            this.rbTipo.AutoSize = true;
            this.rbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipo.ForeColor = System.Drawing.Color.White;
            this.rbTipo.Location = new System.Drawing.Point(292, 44);
            this.rbTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTipo.Name = "rbTipo";
            this.rbTipo.Size = new System.Drawing.Size(146, 24);
            this.rbTipo.TabIndex = 15;
            this.rbTipo.Text = "Tipo de producto";
            this.rbTipo.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.ForeColor = System.Drawing.Color.White;
            this.rbNombre.Location = new System.Drawing.Point(561, 44);
            this.rbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(172, 24);
            this.rbNombre.TabIndex = 14;
            this.rbNombre.Text = "Nombre de producto";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbIdentificador
            // 
            this.rbIdentificador.AutoSize = true;
            this.rbIdentificador.Checked = true;
            this.rbIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdentificador.ForeColor = System.Drawing.Color.White;
            this.rbIdentificador.Location = new System.Drawing.Point(12, 44);
            this.rbIdentificador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbIdentificador.Name = "rbIdentificador";
            this.rbIdentificador.Size = new System.Drawing.Size(204, 24);
            this.rbIdentificador.TabIndex = 13;
            this.rbIdentificador.TabStop = true;
            this.rbIdentificador.Text = "Identificador de producto";
            this.rbIdentificador.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.nombre,
            this.tipo,
            this.descripcion,
            this.cantidad});
            this.dgvProductos.Location = new System.Drawing.Point(32, 253);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(742, 125);
            this.dgvProductos.TabIndex = 5;
            // 
            // identificador
            // 
            this.identificador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.identificador.HeaderText = "Identificador";
            this.identificador.MinimumWidth = 200;
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 200;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 200;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 200;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 100;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // lbHistorialEntradas
            // 
            this.lbHistorialEntradas.AutoSize = true;
            this.lbHistorialEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistorialEntradas.ForeColor = System.Drawing.Color.White;
            this.lbHistorialEntradas.Location = new System.Drawing.Point(38, 388);
            this.lbHistorialEntradas.Name = "lbHistorialEntradas";
            this.lbHistorialEntradas.Size = new System.Drawing.Size(75, 20);
            this.lbHistorialEntradas.TabIndex = 6;
            this.lbHistorialEntradas.Text = "Ingresos:";
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_ingreso,
            this.cantidad_ingresada});
            this.dgvEntradas.Location = new System.Drawing.Point(32, 420);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.Size = new System.Drawing.Size(313, 125);
            this.dgvEntradas.TabIndex = 7;
            // 
            // fecha_ingreso
            // 
            this.fecha_ingreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_ingreso.HeaderText = "Fecha";
            this.fecha_ingreso.MinimumWidth = 200;
            this.fecha_ingreso.Name = "fecha_ingreso";
            this.fecha_ingreso.ReadOnly = true;
            // 
            // cantidad_ingresada
            // 
            this.cantidad_ingresada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad_ingresada.HeaderText = "Cantidad ingresada";
            this.cantidad_ingresada.MinimumWidth = 150;
            this.cantidad_ingresada.Name = "cantidad_ingresada";
            this.cantidad_ingresada.ReadOnly = true;
            // 
            // lbHistorialSalidas
            // 
            this.lbHistorialSalidas.AutoSize = true;
            this.lbHistorialSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistorialSalidas.ForeColor = System.Drawing.Color.White;
            this.lbHistorialSalidas.Location = new System.Drawing.Point(355, 396);
            this.lbHistorialSalidas.Name = "lbHistorialSalidas";
            this.lbHistorialSalidas.Size = new System.Drawing.Size(65, 20);
            this.lbHistorialSalidas.TabIndex = 8;
            this.lbHistorialSalidas.Text = "Salidas:";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.AllowUserToDeleteRows = false;
            this.dgvSalidas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_salida,
            this.cantidad_extraida,
            this.nombre_empleado});
            this.dgvSalidas.Location = new System.Drawing.Point(350, 420);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.ReadOnly = true;
            this.dgvSalidas.Size = new System.Drawing.Size(423, 125);
            this.dgvSalidas.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(652, 26);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 27);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // fecha_salida
            // 
            this.fecha_salida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha_salida.HeaderText = "Fecha";
            this.fecha_salida.MinimumWidth = 200;
            this.fecha_salida.Name = "fecha_salida";
            this.fecha_salida.ReadOnly = true;
            // 
            // cantidad_extraida
            // 
            this.cantidad_extraida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad_extraida.HeaderText = "Cantidad extraída";
            this.cantidad_extraida.MinimumWidth = 150;
            this.cantidad_extraida.Name = "cantidad_extraida";
            this.cantidad_extraida.ReadOnly = true;
            // 
            // nombre_empleado
            // 
            this.nombre_empleado.HeaderText = "Empleado";
            this.nombre_empleado.MinimumWidth = 200;
            this.nombre_empleado.Name = "nombre_empleado";
            this.nombre_empleado.ReadOnly = true;
            this.nombre_empleado.Width = 200;
            // 
            // FRM_BuscarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvSalidas);
            this.Controls.Add(this.lbHistorialSalidas);
            this.Controls.Add(this.dgvEntradas);
            this.Controls.Add(this.lbHistorialEntradas);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FRM_BuscarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbHistorialEntradas;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Label lbHistorialSalidas;
        private System.Windows.Forms.DataGridView dgvSalidas;
        public System.Windows.Forms.RadioButton rbTipo;
        public System.Windows.Forms.RadioButton rbNombre;
        public System.Windows.Forms.RadioButton rbIdentificador;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.RadioButton rbLimipieza;
        public System.Windows.Forms.RadioButton rbHigiene;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_ingresada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_extraida;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_empleado;
    }
}