using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Vehiculo
    {
        public int IdVehiculo { get; set; }
        public int IdMarca { get; set; }
        public string RazonSocial { get; set; }
        public string Matricula { get; set; }
        public DateTime AnioFabricacion { get; set; }
        public bool Disponibilidad { get; set; }
    }
}
