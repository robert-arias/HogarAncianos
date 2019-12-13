namespace HogarAncianos.View
{
    partial class FRM_AgregarMedicamento
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
            this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lbCantidadPrescrita = new System.Windows.Forms.Label();
            this.lbCantidadDisponible = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.txtCantidadPrescrita = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUnidadMedida = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.cbUnidadMedida);
            this.groupBox1.Controls.Add(this.txtMedida);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnVerificar);
            this.groupBox1.Controls.Add(this.lbCantidadPrescrita);
            this.groupBox1.Controls.Add(this.lbCantidadDisponible);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCantidadDisponible);
            this.groupBox1.Controls.Add(this.txtCantidadPrescrita);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.lbCategoria);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbUnidadMedida);
            this.groupBox1.Controls.Add(this.lbCodigo);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(42)))), ((int)(((byte)(72)))));
            this.groupBox1.Location = new System.Drawing.Point(27, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del medicamento";
            // 
            // cbUnidadMedida
            // 
            this.cbUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnidadMedida.FormattingEnabled = true;
            this.cbUnidadMedida.Items.AddRange(new object[] {
            "Seleccionar",
            "ML",
            "GR",
            "LITRO",
            "ONZAS"});
            this.cbUnidadMedida.Location = new System.Drawing.Point(313, 207);
            this.cbUnidadMedida.Name = "cbUnidadMedida";
            this.cbUnidadMedida.Size = new System.Drawing.Size(77, 26);
            this.cbUnidadMedida.TabIndex = 96;
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(206, 207);
            this.txtMedida.Multiline = true;
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(98, 26);
            this.txtMedida.TabIndex = 95;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(499, 57);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 29);
            this.btnLimpiar.TabIndex = 94;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.Black;
            this.btnVerificar.Location = new System.Drawing.Point(426, 57);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(69, 29);
            this.btnVerificar.TabIndex = 93;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            // 
            // lbCantidadPrescrita
            // 
            this.lbCantidadPrescrita.AutoSize = true;
            this.lbCantidadPrescrita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadPrescrita.ForeColor = System.Drawing.Color.Red;
            this.lbCantidadPrescrita.Location = new System.Drawing.Point(395, 307);
            this.lbCantidadPrescrita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCantidadPrescrita.Name = "lbCantidadPrescrita";
            this.lbCantidadPrescrita.Size = new System.Drawing.Size(14, 18);
            this.lbCantidadPrescrita.TabIndex = 92;
            this.lbCantidadPrescrita.Text = "*";
            // 
            // lbCantidadDisponible
            // 
            this.lbCantidadDisponible.AutoSize = true;
            this.lbCantidadDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadDisponible.ForeColor = System.Drawing.Color.Red;
            this.lbCantidadDisponible.Location = new System.Drawing.Point(394, 264);
            this.lbCantidadDisponible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCantidadDisponible.Name = "lbCantidadDisponible";
            this.lbCantidadDisponible.Size = new System.Drawing.Size(14, 18);
            this.lbCantidadDisponible.TabIndex = 91;
            this.lbCantidadDisponible.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 88;
            this.label8.Text = "Cantidad disponible:";
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.Enabled = false;
            this.txtCantidadDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDisponible.Location = new System.Drawing.Point(207, 258);
            this.txtCantidadDisponible.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.Size = new System.Drawing.Size(183, 24);
            this.txtCantidadDisponible.TabIndex = 90;
            // 
            // txtCantidadPrescrita
            // 
            this.txtCantidadPrescrita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPrescrita.Location = new System.Drawing.Point(207, 307);
            this.txtCantidadPrescrita.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadPrescrita.Name = "txtCantidadPrescrita";
            this.txtCantidadPrescrita.Size = new System.Drawing.Size(183, 24);
            this.txtCantidadPrescrita.TabIndex = 89;
            this.txtCantidadPrescrita.Text = "0";
            this.txtCantidadPrescrita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 307);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 87;
            this.label9.Text = "Cantidad prescrita:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Seleccionar",
            "Tabletas",
            "Inyecciones"});
            this.cbCategoria.Location = new System.Drawing.Point(206, 152);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(183, 26);
            this.cbCategoria.TabIndex = 85;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.Red;
            this.lbCategoria.Location = new System.Drawing.Point(393, 152);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(14, 18);
            this.lbCategoria.TabIndex = 84;
            this.lbCategoria.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "Categoria:";
            // 
            // lbUnidadMedida
            // 
            this.lbUnidadMedida.AutoSize = true;
            this.lbUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnidadMedida.ForeColor = System.Drawing.Color.Red;
            this.lbUnidadMedida.Location = new System.Drawing.Point(395, 213);
            this.lbUnidadMedida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUnidadMedida.Name = "lbUnidadMedida";
            this.lbUnidadMedida.Size = new System.Drawing.Size(14, 18);
            this.lbUnidadMedida.TabIndex = 82;
            this.lbUnidadMedida.Text = "*";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.ForeColor = System.Drawing.Color.Red;
            this.lbCodigo.Location = new System.Drawing.Point(393, 65);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(14, 18);
            this.lbCodigo.TabIndex = 80;
            this.lbCodigo.Text = "*";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.Red;
            this.lbNombre.Location = new System.Drawing.Point(393, 110);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(14, 18);
            this.lbNombre.TabIndex = 77;
            this.lbNombre.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Nombre del medicamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Unidad de medida:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(207, 107);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 24);
            this.txtNombre.TabIndex = 75;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(206, 59);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(183, 24);
            this.txtCodigo.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Codigo del medicamento:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(317, 398);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 41);
            this.btnCancelar.TabIndex = 19;
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
            this.btnAgregar.Location = new System.Drawing.Point(187, 398);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 41);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // FRM_AgregarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRM_AgregarMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AgregarMedicamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCantidadDisponible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        public System.Windows.Forms.TextBox txtCantidadPrescrita;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbUnidadMedida;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCantidadPrescrita;
        public System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.Button btnVerificar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.ComboBox cbUnidadMedida;
    }
}