namespace HogarAncianos.View
{
    partial class FRM_ModificarProductosHigiene
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
            this.btVerificar = new System.Windows.Forms.Button();
            this.txbIdentificadorProducto = new System.Windows.Forms.TextBox();
            this.txbNombreProducto = new System.Windows.Forms.TextBox();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbLimpieza = new System.Windows.Forms.RadioButton();
            this.rbHigienePersonal = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btVerificar);
            this.groupBox1.Controls.Add(this.txbIdentificadorProducto);
            this.groupBox1.Controls.Add(this.txbNombreProducto);
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.txbDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbLimpieza);
            this.groupBox1.Controls.Add(this.rbHigienePersonal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Productos Higiene";
            // 
            // btVerificar
            // 
            this.btVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btVerificar.Location = new System.Drawing.Point(293, 30);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(75, 31);
            this.btVerificar.TabIndex = 6;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = true;
            // 
            // txbIdentificadorProducto
            // 
            this.txbIdentificadorProducto.Location = new System.Drawing.Point(143, 37);
            this.txbIdentificadorProducto.Name = "txbIdentificadorProducto";
            this.txbIdentificadorProducto.Size = new System.Drawing.Size(117, 20);
            this.txbIdentificadorProducto.TabIndex = 7;
            // 
            // txbNombreProducto
            // 
            this.txbNombreProducto.Enabled = false;
            this.txbNombreProducto.Location = new System.Drawing.Point(87, 69);
            this.txbNombreProducto.Name = "txbNombreProducto";
            this.txbNombreProducto.Size = new System.Drawing.Size(197, 20);
            this.txbNombreProducto.TabIndex = 1;
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(374, 30);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btLimpiar.TabIndex = 6;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Enabled = false;
            this.txbDescripcion.Location = new System.Drawing.Point(374, 72);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbDescripcion.Size = new System.Drawing.Size(155, 72);
            this.txbDescripcion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripción:";
            // 
            // rbLimpieza
            // 
            this.rbLimpieza.AutoSize = true;
            this.rbLimpieza.Location = new System.Drawing.Point(228, 111);
            this.rbLimpieza.Name = "rbLimpieza";
            this.rbLimpieza.Size = new System.Drawing.Size(66, 17);
            this.rbLimpieza.TabIndex = 1;
            this.rbLimpieza.Text = "Limpieza";
            this.rbLimpieza.UseVisualStyleBackColor = true;
            // 
            // rbHigienePersonal
            // 
            this.rbHigienePersonal.AutoSize = true;
            this.rbHigienePersonal.Checked = true;
            this.rbHigienePersonal.Enabled = false;
            this.rbHigienePersonal.Location = new System.Drawing.Point(127, 111);
            this.rbHigienePersonal.Name = "rbHigienePersonal";
            this.rbHigienePersonal.Size = new System.Drawing.Size(105, 17);
            this.rbHigienePersonal.TabIndex = 3;
            this.rbHigienePersonal.TabStop = true;
            this.rbHigienePersonal.Text = "Higiene Personal";
            this.rbHigienePersonal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador producto:";
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btModificar.Enabled = false;
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(211, 236);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(95, 29);
            this.btModificar.TabIndex = 8;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(317, 236);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(95, 29);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // FRM_ModificarProductosHigiene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(637, 300);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_ModificarProductosHigiene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto Higiene";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbLimpieza;
        private System.Windows.Forms.RadioButton rbHigienePersonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombreProducto;
        private System.Windows.Forms.TextBox txbIdentificadorProducto;
        public System.Windows.Forms.Button btVerificar;
        public System.Windows.Forms.Button btLimpiar;
        public System.Windows.Forms.Button btModificar;
        public System.Windows.Forms.Button btCancelar;
    }
}