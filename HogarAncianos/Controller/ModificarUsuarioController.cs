using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.View;
using HogarAncianos.Model;

namespace HogarAncianos.Controller
{
    class ModificarUsuarioController
    {
        private FRM_ModificarUsuario frm_ModificarUsuario;
        private ConnectionDB connection;

        public ModificarUsuarioController(FRM_ModificarUsuario frm_ModificarUsuario)
        {
            this.frm_ModificarUsuario = frm_ModificarUsuario;
            connection = new ConnectionDB();
            AgregarEventosModificarUsuario();
            FillUsuarios();
        }

        private void FillUsuarios()
        {
            frm_ModificarUsuario.FillUsuarios(connection.GetUsuarios());
        }

        private void limpiar(object sender, EventArgs e)
        {
            frm_ModificarUsuario.EstadoInicial();
        }
        public void AgregarEventosModificarUsuario()
        {
            frm_ModificarUsuario.btnModificar.Click += new EventHandler(modificarUsuario);
            frm_ModificarUsuario.btnLimpiar.Click += new EventHandler(limpiar);
            frm_ModificarUsuario.cbUsuario.SelectedIndexChanged += new EventHandler(llenarCampos);
        }

        public void llenarCampos(object sender, EventArgs e)
        {
            if (connection.GetUsuario(frm_ModificarUsuario.GetNombreUsuario()).Tables[0].Rows.Count != 0)
            {
                frm_ModificarUsuario.llenarCampos(connection.GetUsuario(frm_ModificarUsuario.GetNombreUsuario()));
                frm_ModificarUsuario.ActivarCampos();
            }
        }

        public void modificarUsuario(object sender, EventArgs e)
        {
            connection.UpdateUsuario(frm_ModificarUsuario.GetUsuario());
            frm_ModificarUsuario.EstadoInicial();
        }


    }
}
