using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public int IdInstructor { get; set; }
        public string RazonSocial { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int CupoMin { get; set; }
        public int CupoMax { get; set; }
    }
}
