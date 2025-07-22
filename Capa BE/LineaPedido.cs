using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_BE
{
    public class LineaPedido
    {
        public int IdLineaPedido { get; set; }
        public int IdFactura { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
    }
}
