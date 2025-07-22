using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Pago
    {
        public int IdPago { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string MetodoPago { get; set; }
    }
}
