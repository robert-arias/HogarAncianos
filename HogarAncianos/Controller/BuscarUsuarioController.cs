using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HogarAncianos.Model;
using HogarAncianos.View;

namespace HogarAncianos.Controller
{
    class BuscarUsuarioController
    {
        private FRM_ConsultarUsuario FRM_ConsultarUsuario;
        private ConnectionDB connectionDB;
        public BuscarUsuarioController(FRM_ConsultarUsuario FRM_ConsultarUsuario)
        {
            this.FRM_ConsultarUsuario = FRM_ConsultarUsuario;
            connectionDB = new ConnectionDB();
            AgregarEventosConsultarUsuario();
           
        }

        public void AgregarEventosConsultarUsuario()
        {
           
            FRM_ConsultarUsuario.Load += new EventHandler(FilldtgUsuarios);
            
        }

        public void FilldtgUsuarios(object sender, EventArgs e)
        {
            FRM_ConsultarUsuario.FilldtgUsuarios(connectionDB.GetAllUsuarios());
        }

        
    }
}
