using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEpedido
    {
        public string NombreArticulo { get; set; }
        public string NombreProveedor { get; set; }
        public int NumeroPedido { get; set; }
        public int IdPedido { get; set; }
        public DateTime Fecha { get; set; }
    }
}
