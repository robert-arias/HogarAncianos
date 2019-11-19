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
    public partial class FRM_ModificarUsuario : Form
    {
        private ModificarUsuarioController modificarUsuarioController;
        public FRM_ModificarUsuario()
        {
            InitializeComponent();
            EstadoInicial();
            modificarUsuarioController =new  ModificarUsuarioController(this);
        }


        public void llenarCampos(DataSet data)
        {
            txtContrasenia.Text = data.Tables[0].Rows[0][1].ToString();
            cbRol.SelectedItem = data.Tables[0].Rows[0][2].ToString();

            Console.WriteLine(data.Tables[0].Rows[0][1].ToString() + "LLenar campos metodooo usuarioooooooooooooooooooo");
        }
        public void FillUsuarios(DataSet usuario)
        {

            cbUsuario.DataSource = usuario.Tables[0];
            cbUsuario.DisplayMember = "cedula";
            cbUsuario.ValueMember = "cedula";


        }

        public Usuario GetUsuario()
        {
            return new Usuario(cbUsuario.GetItemText(cbUsuario.SelectedItem), txtContrasenia.Text, cbRol.GetItemText(cbRol.SelectedItem));
        }

        public void ActivarCampos()
        {
           
            txtContrasenia.Enabled = true;
            cbRol.Enabled = true;
            checkBoxMostrarDatos.Enabled = true;

            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
           
            btnLimpiar.Enabled = true;
        }

        public void EstadoInicial()
        {
            cbUsuario.Enabled = true;
            txtContrasenia.Enabled = false;
            cbRol.Enabled = false;
            checkBoxMostrarDatos.Enabled = false;

            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
          
            btnLimpiar.Enabled = true;


            cbUsuario.SelectedIndex = 0;
            txtContrasenia.Text = "";
            cbRol.SelectedIndex = 0;

        }

        public bool VerificarCampos()
        {
            bool verificar = false;

            if (string.IsNullOrEmpty(txtContrasenia.Text))
            {
                lbContrasenia.ForeColor = Color.Red;
                verificar = true;
            }
            else
            {
                lbContrasenia.ForeColor = Color.Black;

            }

            if (cbRol.SelectedIndex == 0)
            {
                lbRol.ForeColor = Color.Red;
                verificar = true;
            }
            else
            {
                lbRol.ForeColor = Color.Black;

            }

            return verificar;

        }

        private void checkBoxMostrarDatos_CheckedChanged(object sender, EventArgs e)
        {
            string contrasenia = txtContrasenia.Text;
            if (checkBoxMostrarDatos.Checked)
            {
                txtContrasenia.UseSystemPasswordChar = false;
                txtContrasenia.Text = contrasenia;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
                txtContrasenia.Text = contrasenia;
            }

        }

        public string GetNombreUsuario()
        {
            return cbUsuario.GetItemText(cbUsuario.SelectedItem);
        }
    }
}
