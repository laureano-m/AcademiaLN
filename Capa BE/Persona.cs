using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class Persona
    {
        public int Dni { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
