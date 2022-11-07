using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEnotacredito
    {
        public string Descripcion { get; set; }
        public int Numero { get; set; }
        public double Importe { get; set; }
        public DateTime Fecha { get; set; }
        public BEcliente IdCliente
        {
            get; set;
        }
    }
}
