namespace HogarAncianos.View
{
    partial class FRM_SalidaProductos
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
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.txbIdentificadorProducto = new System.Windows.Forms.TextBox();
            this.btVerificar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbHigienePersonal = new System.Windows.Forms.RadioButton();
            this.rbLimpieza = new System.Windows.Forms.RadioButton();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbNombreCompleto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSustraer = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txbCantidadSustraer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbCantidadSustraer);
            this.groupBox1.Controls.Add(this.txbCedula);
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.txbIdentificadorProducto);
            this.groupBox1.Controls.Add(this.btVerificar);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.rbHigienePersonal);
            this.groupBox1.Controls.Add(this.rbLimpieza);
            this.groupBox1.Controls.Add(this.txbNombre);
            this.groupBox1.Controls.Add(this.txbNombreCompleto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extraer productos";
            // 
            // txbCedula
            // 
            this.txbCedula.Enabled = false;
            this.txbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCedula.Location = new System.Drawing.Point(586, 97);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(233, 26);
            this.txbCedula.TabIndex = 20;
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpiar.Location = new System.Drawing.Point(527, 32);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 30);
            this.btLimpiar.TabIndex = 19;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            // 
            // txbIdentificadorProducto
            // 
            this.txbIdentificadorProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdentificadorProducto.Location = new System.Drawing.Point(180, 31);
            this.txbIdentificadorProducto.Name = "txbIdentificadorProducto";
            this.txbIdentificadorProducto.Size = new System.Drawing.Size(242, 26);
            this.txbIdentificadorProducto.TabIndex = 18;
            // 
            // btVerificar
            // 
            this.btVerificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btVerificar.Location = new System.Drawing.Point(446, 31);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(75, 30);
            this.btVerificar.TabIndex = 17;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(180, 136);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(242, 26);
            this.dtpFecha.TabIndex = 14;
            // 
            // rbHigienePersonal
            // 
            this.rbHigienePersonal.AutoSize = true;
            this.rbHigienePersonal.Checked = true;
            this.rbHigienePersonal.Enabled = false;
            this.rbHigienePersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHigienePersonal.ForeColor = System.Drawing.Color.White;
            this.rbHigienePersonal.Location = new System.Drawing.Point(180, 95);
            this.rbHigienePersonal.Name = "rbHigienePersonal";
            this.rbHigienePersonal.Size = new System.Drawing.Size(146, 24);
            this.rbHigienePersonal.TabIndex = 13;
            this.rbHigienePersonal.TabStop = true;
            this.rbHigienePersonal.Text = "Higiene personal";
            this.rbHigienePersonal.UseVisualStyleBackColor = true;
            // 
            // rbLimpieza
            // 
            this.rbLimpieza.AutoSize = true;
            this.rbLimpieza.Enabled = false;
            this.rbLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLimpieza.ForeColor = System.Drawing.Color.White;
            this.rbLimpieza.Location = new System.Drawing.Point(332, 96);
            this.rbLimpieza.Name = "rbLimpieza";
            this.rbLimpieza.Size = new System.Drawing.Size(90, 24);
            this.rbLimpieza.TabIndex = 12;
            this.rbLimpieza.Text = "Limpieza";
            this.rbLimpieza.UseVisualStyleBackColor = true;
            // 
            // txbNombre
            // 
            this.txbNombre.Enabled = false;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(180, 63);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(242, 26);
            this.txbNombre.TabIndex = 11;
            // 
            // txbNombreCompleto
            // 
            this.txbNombreCompleto.Enabled = false;
            this.txbNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreCompleto.Location = new System.Drawing.Point(586, 133);
            this.txbNombreCompleto.Name = "txbNombreCompleto";
            this.txbNombreCompleto.Size = new System.Drawing.Size(233, 26);
            this.txbNombreCompleto.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(442, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre completo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(442, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cédula empleado: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(71, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad a sustraer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(131, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador producto:";
            // 
            // btSustraer
            // 
            this.btSustraer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSustraer.Enabled = false;
            this.btSustraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSustraer.Location = new System.Drawing.Point(362, 318);
            this.btSustraer.Name = "btSustraer";
            this.btSustraer.Size = new System.Drawing.Size(91, 33);
            this.btSustraer.TabIndex = 15;
            this.btSustraer.Text = "Sustraer";
            this.btSustraer.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancelar.Enabled = false;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(471, 318);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(91, 33);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // txbCantidadSustraer
            // 
            this.txbCantidadSustraer.Enabled = false;
            this.txbCantidadSustraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidadSustraer.Location = new System.Drawing.Point(180, 180);
            this.txbCantidadSustraer.Name = "txbCantidadSustraer";
            this.txbCantidadSustraer.Size = new System.Drawing.Size(242, 26);
            this.txbCantidadSustraer.TabIndex = 21;
            // 
            // FRM_SalidaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(862, 413);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSustraer);
            this.Controls.Add(this.btCancelar);
            this.Name = "FRM_SalidaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida productos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RadioButton rbHigienePersonal;
        private System.Windows.Forms.RadioButton rbLimpieza;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbNombreCompleto;
        private System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.TextBox txbIdentificadorProducto;
        public System.Windows.Forms.Button btLimpiar;
        public System.Windows.Forms.Button btVerificar;
        public System.Windows.Forms.Button btSustraer;
        public System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txbCantidadSustraer;
    }
}