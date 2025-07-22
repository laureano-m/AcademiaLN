using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Reserva
    {
        public int IdReserva { get; set; }

        public int IdVehiculo { get; set; }
        public Vehiculo oVehiculo { get; set; }

        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
    }
}
