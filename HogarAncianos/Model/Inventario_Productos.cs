using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
    public class Inventario_Productos
    {
        public string Identificador_producto { get; set; }
        public int Cantidad { get; set; }
        public string Fecha_ingreso { get; set; }

        public Inventario_Productos( string identificador_producto, int cantidad, string fecha_ingreso) {
            Identificador_producto = identificador_producto;
            Cantidad = cantidad;
            Fecha_ingreso = fecha_ingreso;
        }
    }
}
