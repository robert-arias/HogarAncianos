using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.View;
using HogarAncianos.Model;
using System.Windows.Forms;
namespace HogarAncianos.Controller
{
    class AgregarUsuarioController
    {
        private FRM_AgregarUsuario frm_AgregarUsuario;
        private ConnectionDB connection;
        public AgregarUsuarioController(FRM_AgregarUsuario frm_AgregarUsuario)
        {
            this.frm_AgregarUsuario = frm_AgregarUsuario;
            connection = new ConnectionDB();
            AgregarEventosUsuarios();
        }

        public void AgregarEventosUsuarios()
        {
            frm_AgregarUsuario.btnAgregar.Click += new EventHandler(AgregarUsuario);
            frm_AgregarUsuario.btnVerificar.Click += new EventHandler(VerificarUsuarioBoton);
            frm_AgregarUsuario.txtUsuario.KeyDown += new KeyEventHandler(VerificarUsuarioEnter);
            frm_AgregarUsuario.btnLimpiar.Click += new EventHandler(limpiar);
        }

        public void VerificarUsuarioEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!connection.ExisteUsuario(frm_AgregarUsuario.GetNombreUsuario()))
                {
                    frm_AgregarUsuario.ActivarCampos();
                }
                else
                    frm_AgregarUsuario.ShowMessage("El usuario ingresado se encuentra en los registros.");
                e.SuppressKeyPress = true; //remove ding windows sound.

                
            }
        }

        public void VerificarUsuarioBoton(object sender, EventArgs e)
        {
            if (!connection.ExisteUsuario(frm_AgregarUsuario.GetNombreUsuario()))
            {
                frm_AgregarUsuario.ActivarCampos();
            }
            else
            {
                frm_AgregarUsuario.ShowMessage("El usuario ingresado se encuentra en los registros.");

            } 
        }

        public void limpiar(object sender, EventArgs e)
        {
            frm_AgregarUsuario.EstadoInicial();
        }

        public void AgregarUsuario(object sender, EventArgs e)
        {
            if (!frm_AgregarUsuario.VerificarCampos())
            {
                connection.agregarUsuario(frm_AgregarUsuario.GetUsuario());
                frm_AgregarUsuario.ShowMessage("El usuario ha sido agregadp exitosamente.");
                frm_AgregarUsuario.EstadoInicial();
            }
            else
            {

                frm_AgregarUsuario.ShowMessage("Algunos campos se encuentran vacíos." +
                    "\nLos campos con el asterisco (*) rojo son aquellos que deben ser modificados.");
            }
           

        }
    }
}
