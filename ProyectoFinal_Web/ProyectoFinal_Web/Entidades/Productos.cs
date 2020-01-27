using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Web.Entidades
{
    public class Productos
    {
        [Key]   
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Itbis { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Nombre = string.Empty;
            Cantidad = 0;
            PrecioCompra = 0;
            PrecioVenta = 0;
            Itbis = 0;
        }
    }
}
