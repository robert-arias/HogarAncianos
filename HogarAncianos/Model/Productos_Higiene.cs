using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HogarAncianos.Model
{
    public class Productos_Higiene
    {
        public string Identificador_producto { get; set; }
        public string Nombre_producto  { get; set; }
        public string Tipo_producto { get; set; }
        public string Descripcion  { get; set; }
        public int Cantidad { get; set; }
    
        public Productos_Higiene(string identificador_producto, string nombre_producto, 
            string tipo_producto, string descripcion, int cantidad){
            Identificador_producto = identificador_producto;
            Nombre_producto = nombre_producto;
            Tipo_producto = tipo_producto;
            Descripcion = descripcion;
            Cantidad = cantidad;
        }
    }
}
