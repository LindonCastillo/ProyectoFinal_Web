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
        [Required(ErrorMessage = "El Nombre No puede Quedar Vacío")]
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 1000000000000000000, ErrorMessage = "El Precio De Compra No Puede Ser Cero")]
        public decimal PrecioCompra { get; set; }
        [Range(minimum: 1, maximum: 1000000000000000000, ErrorMessage = "El Precio De Venta No Puede Ser Cero")]
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
