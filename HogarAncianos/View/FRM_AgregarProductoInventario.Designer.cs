namespace HogarAncianos.View
{
    partial class FRM_AgregarProductoInventario
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
            this.btLimpiar = new System.Windows.Forms.Button();
            this.txbNombreProducto = new System.Windows.Forms.TextBox();
            this.rbHigienePersonal = new System.Windows.Forms.RadioButton();
            this.rbLimpieza = new System.Windows.Forms.RadioButton();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btVerificar);
            this.groupBox1.Controls.Add(this.txbIdentificadorProducto);
            this.groupBox1.Controls.Add(this.btLimpiar);
            this.groupBox1.Controls.Add(this.txbNombreProducto);
            this.groupBox1.Controls.Add(this.rbHigienePersonal);
            this.groupBox1.Controls.Add(this.rbLimpieza);
            this.groupBox1.Controls.Add(this.txbCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar cantidad a producto";
            // 
            // btVerificar
            // 
            this.btVerificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btVerificar.Location = new System.Drawing.Point(420, 43);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(75, 29);
            this.btVerificar.TabIndex = 14;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = false;
            // 
            // txbIdentificadorProducto
            // 
            this.txbIdentificadorProducto.Location = new System.Drawing.Point(192, 43);
            this.txbIdentificadorProducto.Name = "txbIdentificadorProducto";
            this.txbIdentificadorProducto.Size = new System.Drawing.Size(215, 22);
            this.txbIdentificadorProducto.TabIndex = 0;
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLimpiar.Location = new System.Drawing.Point(501, 43);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 29);
            this.btLimpiar.TabIndex = 12;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = false;
            // 
            // txbNombreProducto
            // 
            this.txbNombreProducto.Enabled = false;
            this.txbNombreProducto.Location = new System.Drawing.Point(192, 71);
            this.txbNombreProducto.Name = "txbNombreProducto";
            this.txbNombreProducto.Size = new System.Drawing.Size(215, 22);
            this.txbNombreProducto.TabIndex = 9;
            // 
            // rbHigienePersonal
            // 
            this.rbHigienePersonal.AutoSize = true;
            this.rbHigienePersonal.Checked = true;
            this.rbHigienePersonal.Enabled = false;
            this.rbHigienePersonal.Location = new System.Drawing.Point(192, 107);
            this.rbHigienePersonal.Name = "rbHigienePersonal";
            this.rbHigienePersonal.Size = new System.Drawing.Size(129, 20);
            this.rbHigienePersonal.TabIndex = 8;
            this.rbHigienePersonal.TabStop = true;
            this.rbHigienePersonal.Text = "Higiene personal";
            this.rbHigienePersonal.UseVisualStyleBackColor = true;
            // 
            // rbLimpieza
            // 
            this.rbLimpieza.AutoSize = true;
            this.rbLimpieza.Enabled = false;
            this.rbLimpieza.Location = new System.Drawing.Point(327, 107);
            this.rbLimpieza.Name = "rbLimpieza";
            this.rbLimpieza.Size = new System.Drawing.Size(80, 20);
            this.rbLimpieza.TabIndex = 7;
            this.rbLimpieza.Text = "Limpieza";
            this.rbLimpieza.UseVisualStyleBackColor = true;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Enabled = false;
            this.txbCantidad.Location = new System.Drawing.Point(192, 137);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(215, 22);
            this.txbCantidad.TabIndex = 2;
            this.txbCantidad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha ingreso:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(192, 170);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(215, 22);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2019, 12, 14, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador producto:";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAgregar.Enabled = false;
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(184, 296);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(106, 43);
            this.btAgregar.TabIndex = 10;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btCancelar.Enabled = false;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(336, 296);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(106, 43);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // FRM_AgregarProductoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(639, 363);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btCancelar);
            this.Name = "FRM_AgregarProductoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txbNombreProducto;
        private System.Windows.Forms.RadioButton rbHigienePersonal;
        private System.Windows.Forms.RadioButton rbLimpieza;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        public System.Windows.Forms.Button btVerificar;
        public System.Windows.Forms.Button btLimpiar;
        public System.Windows.Forms.Button btAgregar;
        public System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.TextBox txbIdentificadorProducto;
    }
}