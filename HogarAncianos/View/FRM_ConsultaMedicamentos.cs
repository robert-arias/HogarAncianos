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


namespace HogarAncianos.View
{
    public partial class FRM_ConsultaMedicamentos : Form
    {
        BuscarMedicamentosController buscarMedicamentosController;
        FRM_ReporteMedicamentos FRM_ReporteMedicamentos;
        public FRM_ConsultaMedicamentos()
        {
            InitializeComponent();
            buscarMedicamentosController = new BuscarMedicamentosController(this);
            FRM_ReporteMedicamentos = new FRM_ReporteMedicamentos();
        }

        public void EstadoInicial()
        {
            do
            {
                foreach (DataGridViewRow row in dtgMedicamentos.Rows)
                {
                    dtgMedicamentos.Rows.Remove(row);
                }
            } while (dtgMedicamentos.Rows.Count >= 1);

        }

       

        public string GetBusquedaMedicamentos()
        {
            string query = "";

            if (rbCodigo.Checked)
            {
                query = $"select * from Medicamentos where codigo_medicamento= '{txtBuscar.Text}'";

            }
            else if (rbNombre.Checked)
            {
                query = $"select * from Medicamentos where nombre_medicamento like '%{txtBuscar.Text}%'";
            }          
            Console.WriteLine(query + "REVISAR");
            return query;
        }

        public void FillBusqueda(DataSet medicamentos)
        {
            dtgMedicamentos.DataSource = medicamentos.Tables[0];
        }

        public bool verificar()
        {
            bool verificar = false;
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                verificar = true;

            }
            return verificar;
        }

        public void MensajeInformativo(string message)
        {
            MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RealizarReporte()
        {
            DataSetMedicamentos dataSetMedicamentos = new DataSetMedicamentos();
            int fila = dtgMedicamentos.Rows.Count -1;
            for (int i = 0; i <= fila; i++)
            {
                dataSetMedicamentos.Tables[0].Rows.Add

                    (new object[] {

                         dtgMedicamentos[0, i].Value.ToString(),
                          dtgMedicamentos[1, i].Value.ToString(),
                         dtgMedicamentos[2, i].Value.ToString(),
                         dtgMedicamentos[3, i].Value.ToString(),
                         dtgMedicamentos[4, i].Value.ToString(),
                         dtgMedicamentos[5, i].Value.ToString()


                    }
                    );
            }
            Console.WriteLine("sIN QUITAR EL 2" + dtgMedicamentos.Rows.Count );
            Console.WriteLine("Menos 2" + fila);
            Console.WriteLine("Las filas que se añadieron"+dataSetMedicamentos.Tables[0].Rows.Count);

            ReportDocument report = new ReportDocument();
            string fileName = "View\\CrystalReportMedicamentos.rpt";
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, fileName);
            Console.WriteLine(path);
            report.Load(path);
            report.SetDataSource(dataSetMedicamentos);
            FRM_ReporteMedicamentos.crystalReportViewer1.ReportSource = report;
            FRM_ReporteMedicamentos.ShowDialog();
        }

    }
}
