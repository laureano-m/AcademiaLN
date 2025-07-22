using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Practica
    {
        public int IdClase { get; set; }

        public int IdInstructor { get; set; }
        public Instructor oInstructor { get; set; }

        public int IdReserva { get; set; }
        public Reserva oReserva { get; set; }

        public TimeSpan Duracion { get; set; }
        public string Tipo { get; set; }
        public string Recorrido { get; set; }
        public string Ficha { get; set; }
    }
}
