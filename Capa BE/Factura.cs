using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Factura
    {
        public int IdFactura { get; set; }

        public int IdReserva { get; set; }
        public Reserva oReserva { get; set; }

        public int IdAlquiler { get; set; }
        public Alquiler oAlquiler { get; set; }

        public DateTime FechaEmision { get; set; }
        public double Monto { get; set; }
        public string Estado { get; set; }
    }
}
