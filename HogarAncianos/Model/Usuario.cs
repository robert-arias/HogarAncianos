using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
    public class Usuario
    {

        public string nombreUsuario { get; set; }
        public string contrasenia { get; set; }
        public string rol { get; set; }



        public Usuario (string nombreUsuario, string contrasenia, string rol)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.rol = rol;
            
        }


    }   
}
