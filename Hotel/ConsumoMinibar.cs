using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class ConsumoMinibar
    {
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }

        public decimal Subtotal => cantidad * precioUnitario;
        public decimal Itbis => Subtotal * 0.18m;
        public decimal Total => Subtotal + Itbis; 
    }
}
