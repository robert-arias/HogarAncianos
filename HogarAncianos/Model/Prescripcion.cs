using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
    public class Prescripcion
    {
        public int num { get; set; }
        public string cedula_paciente { get; set; }


        public Prescripcion(int num,string cedula_paciente )
        {
            this.num = num;
            this.cedula_paciente = cedula_paciente;
        }
    }
}
