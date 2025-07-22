using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class DocumentacionVehiculo
    {
        public int IdDocumentacion { get; set; }
        public int IdVehiculo { get; set; }
        public string TipoDocumentacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }
    }
}
