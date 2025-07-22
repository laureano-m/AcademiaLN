using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public int Dni { get; set; }
        public int IdCurso { get; set; }
        public Curso oCurso { get; set; }
    }
}
