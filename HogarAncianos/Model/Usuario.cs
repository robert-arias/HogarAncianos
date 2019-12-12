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
        public byte[] contrasenia { get; set; }
        public string cedula { get; set; }



        public Usuario (string nombreUsuario, byte[] contrasenia, string cedula)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.cedula = cedula;
            
        }


    }   
}
