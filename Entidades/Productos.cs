using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    public partial class Productos
    {
        [Key]
        public int ProductoId { get; set; }

        public string Descripción { get; set; }

        public decimal Existencia { get; set; }

        public decimal Costo { get; set; }
        public decimal ValorInventario { get; set; }
        public decimal Precio { get; set; }
        public decimal Ganancia { get; set; }

        [ForeignKey("ProductoId")]
        public virtual List<ProductoDetalles> ProductoDetalles{ get; set; } = new List<ProductoDetalles>();
    }
}