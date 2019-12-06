using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HogarAncianos.Model;
using HogarAncianos.Controller;

namespace HogarAncianos.View
{
    public partial class FRM_ModificarMedicamento : Form
    {
        private ModificarMedicamentoController modificarMedicamentoController;
        public FRM_ModificarMedicamento()
        {
            InitializeComponent();
            modificarMedicamentoController = new ModificarMedicamentoController(this);
            EstadoInicial();
            cbUnidadMedida.Text = "Seleccionar";
        }

        public void llenarCampos(DataSet data)
        {
            Console.WriteLine("QUE TRAE EL ROW O,2"+data.Tables[0].Rows[0][2].ToString());

            string texto = data.Tables[0].Rows[0][2].ToString();
            char[] delimiterChars = { ' ', ' ' };
            string[] partes = texto.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            txtMedida.Text = partes[0].ToString();
            Console.WriteLine(partes[0].ToString() + "medidaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Console.WriteLine(partes[1].ToString()+"medidaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            cbUnidadMedida.SelectedItem = partes[1].ToString();

            txtNombre.Text = data.Tables[0].Rows[0][1].ToString();
            cbCategoria.SelectedItem= data.Tables[0].Rows[0][3].ToString();
            txtCantidadDisponible.Text = data.Tables[0].Rows[0][4].ToString();
        }


      

        public Medicamento GetMedicamento()
        {

            return new Medicamento(txtCodigo.Text, txtNombre.Text, txtMedida.Text + "  " + cbUnidadMedida.SelectedItem, cbCategoria.SelectedItem.ToString(),
            Convert.ToInt32(txtCantidadDisponible.Text));

        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia");
        }

        public bool ShowMessage2(string menssage)
        {
            DialogResult boton = MessageBox.Show(menssage, "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (boton == DialogResult.OK)
            {
                return true;
            }

            return false;
        }
        public string GetCodigo()
        {
            return txtCodigo.Text;
        }

        public void ActivarCampos()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;
            txtMedida.Enabled = true;
            cbCategoria.Enabled = true;
            txtCantidadDisponible.Enabled = true;


            btnModificar.Enabled = true;
            btnVerificar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

        }

        public void EstadoInicial()
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtMedida.Enabled = false;
            cbCategoria.Enabled = false;
            txtCantidadDisponible.Enabled = false;
          

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtMedida.Text = "";
            cbCategoria.SelectedIndex = 0;
            txtCantidadDisponible.Text = "";


            btnModificar.Enabled = false;
            btnVerificar.Enabled = true;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = true;

        }

        public bool VerificarCampos()
        {
            bool vacio = false;

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {             
                vacio = true;
            }
           

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                
                vacio = true;
            }
            


            if (cbCategoria.SelectedIndex == 0)
            {
               
                vacio = true;
            }
           

            if (string.IsNullOrEmpty(txtMedida.Text))
            {
               
                vacio = true;
            }
            

            if (string.IsNullOrEmpty(txtCantidadDisponible.Text))
            {

               
                vacio = true;

            }
          


            return vacio;
        }
    }
}
