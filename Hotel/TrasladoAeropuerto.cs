using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class TrasladoAeropuerto
    {
        public int pasajeros { get; set; }
        public bool nocturno { get; set;  }

        public decimal Subtotal => pasajeros * 25m;
        public decimal Recargo => nocturno ? Subtotal * 0.20m : 0m;

        public decimal Total => Subtotal + Recargo; 
    }
}
