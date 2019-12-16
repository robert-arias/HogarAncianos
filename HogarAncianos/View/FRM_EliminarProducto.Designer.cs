namespace HogarAncianos.View
{
    partial class FRM_EliminarProducto
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
            this.rbLimpieza = new System.Windows.Forms.RadioButton();
            this.rbHigienePersonal = new System.Windows.Forms.RadioButton();
            this.txbIdentificadorProducto = new System.Windows.Forms.TextBox();
            this.btVerificar = new System.Windows.Forms.Button();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLimpieza);
            this.groupBox1.Controls.Add(this.rbHigienePersonal);
            this.groupBox1.Controls.Add(this.txbIdentificadorProducto);
            this.groupBox1.Controls.Add(this.btVerificar);
            this.groupBox1.Controls.Add(this.txbCantidad);
            this.groupBox1.Controls.Add(this.txbDescripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbNombre);
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar producto";
            // 
            // rbLimpieza
            // 
            this.rbLimpieza.AutoSize = true;
            this.rbLimpieza.Enabled = false;
            this.rbLimpieza.Location = new System.Drawing.Point(292, 91);
            this.rbLimpieza.Name = "rbLimpieza";
            this.rbLimpieza.Size = new System.Drawing.Size(80, 20);
            this.rbLimpieza.TabIndex = 19;
            this.rbLimpieza.Text = "Limpieza";
            this.rbLimpieza.UseVisualStyleBackColor = true;
            // 
            // rbHigienePersonal
            // 
            this.rbHigienePersonal.AutoSize = true;
            this.rbHigienePersonal.Checked = true;
            this.rbHigienePersonal.Enabled = false;
            this.rbHigienePersonal.Location = new System.Drawing.Point(157, 91);
            this.rbHigienePersonal.Name = "rbHigienePersonal";
            this.rbHigienePersonal.Size = new System.Drawing.Size(129, 20);
            this.rbHigienePersonal.TabIndex = 18;
            this.rbHigienePersonal.TabStop = true;
            this.rbHigienePersonal.Text = "Higiene personal";
            this.rbHigienePersonal.UseVisualStyleBackColor = true;
            // 
            // txbIdentificadorProducto
            // 
            this.txbIdentificadorProducto.Location = new System.Drawing.Point(157, 22);
            this.txbIdentificadorProducto.Name = "txbIdentificadorProducto";
            this.txbIdentificadorProducto.Size = new System.Drawing.Size(215, 22);
            this.txbIdentificadorProducto.TabIndex = 17;
            // 
            // btVerificar
            // 
            this.btVerificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btVerificar.Location = new System.Drawing.Point(415, 19);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(75, 25);
            this.btVerificar.TabIndex = 16;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = false;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Enabled = false;
            this.txbCantidad.Location = new System.Drawing.Point(157, 126);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(215, 22);
            this.txbCantidad.TabIndex = 14;
            this.txbCantidad.Text = "0";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Enabled = false;
            this.txbDescripcion.Location = new System.Drawing.Point(415, 95);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(187, 55);
            this.txbDescripcion.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo:";
            // 
            // txbNombre
            // 
            this.txbNombre.Enabled = false;
            this.txbNombre.Location = new System.Drawing.Point(157, 56);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(215, 22);
            this.txbNombre.TabIndex = 7;
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpiar.Location = new System.Drawing.Point(496, 19);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 25);
            this.btLimpiar.TabIndex = 5;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador producto:";
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btEliminar.Enabled = false;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(238, 248);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(95, 33);
            this.btEliminar.TabIndex = 3;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancelar.Enabled = false;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(339, 248);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(95, 33);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // FRM_EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(667, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btCancelar);
            this.Name = "FRM_EliminarProducto";
            this.Text = "FRM_EliminarProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbLimpieza;
        private System.Windows.Forms.RadioButton rbHigienePersonal;
        public System.Windows.Forms.TextBox txbIdentificadorProducto;
        public System.Windows.Forms.Button btEliminar;
        public System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.Button btVerificar;
        public System.Windows.Forms.Button btLimpiar;
    }
}