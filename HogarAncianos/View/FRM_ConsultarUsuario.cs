using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void RealizarReporte() {
            DataSetUsuario dataSetUsuario = new DataSetUsuario();
            int fila = dtUsuarios.Rows.Count - 2;   
            for (int i = 0; i <= fila; i++) {
                dataSetUsuario.Tables[0].Rows.Add
                    (new object[] {    dtUsuarios[0, i].Value.ToString(),
                           dtUsuarios[1, i].Value.ToString(),
                           dtUsuarios[2, i].Value.ToString()}
                    );
            }

            ReportDocument report = new ReportDocument();
            string fileName = "View\\CrystalReportsUsuario.rpt";
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, fileName);
            Console.WriteLine(path);
            report.Load(path);
            report.SetDataSource(dataSetUsuario);
            reporteUsuarioPrueba.crystalReportViewer1.ReportSource = report;
            reporteUsuarioPrueba.ShowDialog();
        }

    }
}
