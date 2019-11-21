using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
    public class Salida_Productos
    {
        public string Identificador_producto { get; set; }
        public int Cantidad_sustraer { get; set; }
        public string Fecha_salida { get; set; }
        public string Cedula_empleado { get; set; }

        public Salida_Productos(string identificador_producto, int cantidad_sustraer,
            string fecha_salida, string cedula_empleado) {
            Identificador_producto = identificador_producto;
            Cantidad_sustraer = cantidad_sustraer;
            Fecha_salida = fecha_salida;
            Cedula_empleado = cedula_empleado; 
        }

    }
}
