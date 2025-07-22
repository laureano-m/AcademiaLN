using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Mantenimiento
    {
        public int IdMantenimiento { get; set; }
        public int IdVehiculo { get; set; }
        public string TipoMantenimiento { get; set; }
        public DateTime FechaProgramada { get; set; }
        public DateTime FechaRealizacion { get; set; }
        public string Estado { get; set; }
        public string Detalle { get; set; }
    }
}
