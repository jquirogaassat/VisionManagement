using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEfactura
    {
        public int Numero { get; set; }
        public float Importe { get; set; }
        public DateTime Fecha { get; set; }
        public BEcliente Cliente { get; set; }
        public BEarticulo Articulo { get; set; }
    }
}
