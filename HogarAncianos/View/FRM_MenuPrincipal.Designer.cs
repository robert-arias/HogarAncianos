namespace HogarAncianos.View {
    partial class FRM_MenuPrincipal {
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
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.mi_Empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_EmpleadosAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_EmpleadosModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_EmpleadosBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_EmpleadosReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Empleados});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(992, 28);
            this.ms_Menu.TabIndex = 0;
            // 
            // mi_Empleados
            // 
            this.mi_Empleados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_EmpleadosAgregar,
            this.mi_EmpleadosModificar,
            this.mi_EmpleadosBuscar,
            this.mi_EmpleadosReporte});
            this.mi_Empleados.Name = "mi_Empleados";
            this.mi_Empleados.Size = new System.Drawing.Size(95, 24);
            this.mi_Empleados.Text = "Empleados";
            // 
            // mi_EmpleadosAgregar
            // 
            this.mi_EmpleadosAgregar.Name = "mi_EmpleadosAgregar";
            this.mi_EmpleadosAgregar.Size = new System.Drawing.Size(216, 26);
            this.mi_EmpleadosAgregar.Text = "Agregar";
            // 
            // mi_EmpleadosModificar
            // 
            this.mi_EmpleadosModificar.Name = "mi_EmpleadosModificar";
            this.mi_EmpleadosModificar.Size = new System.Drawing.Size(216, 26);
            this.mi_EmpleadosModificar.Text = "Modificar";
            // 
            // mi_EmpleadosBuscar
            // 
            this.mi_EmpleadosBuscar.Name = "mi_EmpleadosBuscar";
            this.mi_EmpleadosBuscar.Size = new System.Drawing.Size(216, 26);
            this.mi_EmpleadosBuscar.Text = "Buscar";
            // 
            // mi_EmpleadosReporte
            // 
            this.mi_EmpleadosReporte.Name = "mi_EmpleadosReporte";
            this.mi_EmpleadosReporte.Size = new System.Drawing.Size(216, 26);
            this.mi_EmpleadosReporte.Text = "Reporte";
            // 
            // FRM_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 624);
            this.Controls.Add(this.ms_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms_Menu;
            this.MaximizeBox = false;
            this.Name = "FRM_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip ms_Menu;
        public System.Windows.Forms.ToolStripMenuItem mi_Empleados;
        public System.Windows.Forms.ToolStripMenuItem mi_EmpleadosAgregar;
        public System.Windows.Forms.ToolStripMenuItem mi_EmpleadosModificar;
        public System.Windows.Forms.ToolStripMenuItem mi_EmpleadosBuscar;
        public System.Windows.Forms.ToolStripMenuItem mi_EmpleadosReporte;
    }
}