using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Incidencia
    {
        public int IdIncidencia { get; set; }
        public int IdVehiculo { get; set; }
        public int IdInstructor { get; set; }
        public DateTime FechaReporte { get; set; }
        public string Detalle { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
    }
}
