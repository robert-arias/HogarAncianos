using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
    class Paciente
    {
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string fechaNacimiento { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
    }
}
