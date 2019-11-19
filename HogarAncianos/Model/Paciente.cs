using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
   public class Paciente
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string fechaNacimiento { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }

        public Paciente(string cedula, string nombre, string apellidos, string fechaNacimiento, int edad, string sexo)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.edad = edad;
            this.sexo = sexo;
        }

        public Paciente(string cedula)
        {
            this.cedula = cedula;
            
        }
    }

  
}
