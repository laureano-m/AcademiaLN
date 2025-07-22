using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Alquiler
    {
        public int IdAlquiler { get; set; }

        public int IdAlumno { get; set; }
        public Alumno oAlumno { get; set; }

        public int IdVehiculo { get; set; }
        public Vehiculo oVehiculo { get; set; }

        public DateTime FechaAlquiler { get; set; }
        public TimeSpan HoraAlquiler { get; set; }
        public double Monto { get; set; }
        public string Estado { get; set; }
    }
}
