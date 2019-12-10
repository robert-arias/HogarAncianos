using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using HogarAncianos.Controller;
using HogarAncianos.Model;

namespace HogarAncianos.View
{
    public partial class FRM_ConsultarUsuario : Form
    {
        BuscarUsuarioController buscarUsuarioController;
        FRM_ReporteUsuarioPrueba reporteUsuarioPrueba;
        public FRM_ConsultarUsuario()
        {
            InitializeComponent();
            buscarUsuarioController = new BuscarUsuarioController(this);
            reporteUsuarioPrueba = new FRM_ReporteUsuarioPrueba();
        }

        private void SetdtUsuarios()
        {
            dtUsuarios.ColumnCount = 3;
            dtUsuarios.Columns[0].DataPropertyName = "usuario";
            dtUsuarios.Columns[0].Name = "Usuario";
            dtUsuarios.Columns[1].DataPropertyName = "contrasenia";
            dtUsuarios.Columns[1].Name = "Contraseña";
            dtUsuarios.Columns[2].DataPropertyName = "rol";
            dtUsuarios.Columns[2].Name = "Rol";                   
            dtUsuarios.AutoGenerateColumns = false;
        }

        public void  FilldtgUsuarios(DataSet usuarios)
        {
            SetdtUsuarios();
            dtUsuarios.DataSource = usuarios.Tables[0];             
        }

        private void FRM_ConsultarUsuario_Load(object sender, EventArgs e)
        {
            //quitar
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
           DataSetUsuario dataSetUsuario = new DataSetUsuario();
            int fila = dtUsuarios.Rows.Count - 2;
            Console.WriteLine("Fila 0 columna 1" + dtUsuarios[0, 0].Value.ToString());
            Console.WriteLine("Fila 0 columna 2" + dtUsuarios[0, 1].Value.ToString());
            Console.WriteLine("Fila 0 columna 3" + dtUsuarios[0, 2].Value.ToString());
            Console.WriteLine("Fila 1 columna 0" + dtUsuarios[1, 0].Value.ToString());
            Console.WriteLine("Fila 1 columna 1" + dtUsuarios[1, 1].Value.ToString());
            Console.WriteLine("Fila 1 columna 2" + dtUsuarios[1, 2].Value.ToString());
            for (int i=0; i <= fila ;i++)
            {
                dataSetUsuario.Tables[0].Rows.Add
                    (new object[] {    dtUsuarios[0, i].Value.ToString(),
                           dtUsuarios[1, i].Value.ToString(),
                           dtUsuarios[2, i].Value.ToString()}
                    );
            }

            ReportDocument report = new ReportDocument();
             report.Load("C:/Users/User/source/repos/HogarAncianos2/HogarAncianos/View/CrystalReportsUsuario.rpt");
          //  report.Load(System.Windows.Forms.Application.StartupPath + "//HogarAncianos//View//CrystalReportsUsuario.rpt");
            report.SetDataSource(dataSetUsuario);
            reporteUsuarioPrueba.crystalReportViewer1.ReportSource=report;
            reporteUsuarioPrueba.ShowDialog();
        }
    }
}
