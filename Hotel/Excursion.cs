using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Excursion
    {
        public int personas { get; set; }

        public decimal precioPorPersona { get; set; }

        public decimal Subtotal => personas * precioPorPersona;

        public decimal Descuento => personas >= 4 ? Subtotal * 0.10m : 0m;

        public decimal Total => Subtotal - Descuento;

    }
}
