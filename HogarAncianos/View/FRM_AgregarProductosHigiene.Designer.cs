namespace HogarAncianos.View
{
    partial class FRM_AgregarProductosHigiene
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNombreProducto = new System.Windows.Forms.TextBox();
            this.rbLimpieza = new System.Windows.Forms.RadioButton();
            this.rbHigienePersonal = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btVerificar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbIdentificadorProducto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(43, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificador Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(43, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(43, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(43, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(456, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción:";
            // 
            // txbNombreProducto
            // 
            this.txbNombreProducto.Enabled = false;
            this.txbNombreProducto.Location = new System.Drawing.Point(142, 69);
            this.txbNombreProducto.Name = "txbNombreProducto";
            this.txbNombreProducto.Size = new System.Drawing.Size(241, 20);
            this.txbNombreProducto.TabIndex = 13;
            // 
            // rbLimpieza
            // 
            this.rbLimpieza.AutoSize = true;
            this.rbLimpieza.Enabled = false;
            this.rbLimpieza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLimpieza.Location = new System.Drawing.Point(203, 112);
            this.rbLimpieza.Name = "rbLimpieza";
            this.rbLimpieza.Size = new System.Drawing.Size(66, 17);
            this.rbLimpieza.TabIndex = 15;
            this.rbLimpieza.TabStop = true;
            this.rbLimpieza.Text = "Limpieza";
            this.rbLimpieza.UseVisualStyleBackColor = true;
            // 
            // rbHigienePersonal
            // 
            this.rbHigienePersonal.AutoSize = true;
            this.rbHigienePersonal.Checked = true;
            this.rbHigienePersonal.Enabled = false;
            this.rbHigienePersonal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbHigienePersonal.Location = new System.Drawing.Point(92, 112);
            this.rbHigienePersonal.Name = "rbHigienePersonal";
            this.rbHigienePersonal.Size = new System.Drawing.Size(105, 17);
            this.rbHigienePersonal.TabIndex = 16;
            this.rbHigienePersonal.TabStop = true;
            this.rbHigienePersonal.Text = "Higiene Personal";
            this.rbHigienePersonal.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Enabled = false;
            this.txbCantidad.Location = new System.Drawing.Point(101, 150);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(44, 20);
            this.txbCantidad.TabIndex = 20;
            this.txbCantidad.Text = "0";
            // 
            // btVerificar
            // 
            this.btVerificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btVerificar.Location = new System.Drawing.Point(308, 30);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(88, 29);
            this.btVerificar.TabIndex = 21;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = false;
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpiar.Location = new System.Drawing.Point(402, 30);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(88, 30);
            this.btLimpiar.TabIndex = 22;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAgregar.Enabled = false;
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAgregar.Location = new System.Drawing.Point(246, 294);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(90, 36);
            this.btAgregar.TabIndex = 23;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCancelar.Location = new System.Drawing.Point(399, 294);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 36);
            this.btCancelar.TabIndex = 24;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Enabled = false;
            this.txbDescripcion.Location = new System.Drawing.Point(459, 83);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbDescripcion.Size = new System.Drawing.Size(244, 101);
            this.txbDescripcion.TabIndex = 25;
            // 
            // txbIdentificadorProducto
            // 
            this.txbIdentificadorProducto.Location = new System.Drawing.Point(163, 37);
            this.txbIdentificadorProducto.Name = "txbIdentificadorProducto";
            this.txbIdentificadorProducto.Size = new System.Drawing.Size(124, 20);
            this.txbIdentificadorProducto.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbIdentificadorProducto);
            this.groupBox1.Controls.Add(this.txbDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.txbNombreProducto);
            this.groupBox1.Controls.Add(this.btVerificar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbHigienePersonal);
            this.groupBox1.Controls.Add(this.rbLimpieza);
            this.groupBox1.Controls.Add(this.txbCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(28, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 232);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información productos higiene ";
            // 
            // FRM_AgregarProductosHigiene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(796, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAgregar);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "FRM_AgregarProductosHigiene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AgregarProductosHigiene";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbNombreProducto;
        private System.Windows.Forms.RadioButton rbLimpieza;
        private System.Windows.Forms.RadioButton rbHigienePersonal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbIdentificadorProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btVerificar;
        public System.Windows.Forms.Button btLimpiar;
        public System.Windows.Forms.Button btAgregar;
        public System.Windows.Forms.Button btCancelar;
    }
}