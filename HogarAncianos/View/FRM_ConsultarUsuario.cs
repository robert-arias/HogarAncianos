using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HogarAncianos.Controller;

namespace HogarAncianos.View
{
    public partial class FRM_ConsultarUsuario : Form
    {
        BuscarUsuarioController buscarUsuarioController;
        public FRM_ConsultarUsuario()
        {
            InitializeComponent();
            buscarUsuarioController = new BuscarUsuarioController(this);
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

        }
    }
}
