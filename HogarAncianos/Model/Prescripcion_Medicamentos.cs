using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
   public  class Prescripcion_Medicamentos
    {
        public int num;
        public string codigo_medicamento { get; set; }
        public string fecha_caducidad { get; set; }
        public int cantidad_prescrita { get; set; }

        public Prescripcion_Medicamentos(int num, string codigo_medicamento,string fecha_caducidad,int cantidad_prescrita)
        {
            this.num = num;
            this.codigo_medicamento = codigo_medicamento;
            this.fecha_caducidad = fecha_caducidad;
            this.cantidad_prescrita = cantidad_prescrita;
        }

        public Prescripcion_Medicamentos()
        {
            
        }
    }
}
