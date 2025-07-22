using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Teorica
    {
        public int IdClase { get; set; }

        public int IdCurso { get; set; }
        public Curso oCurso { get; set; }

        public string Temas { get; set; }
        public TimeSpan Duracion { get; set; }
    }
}
