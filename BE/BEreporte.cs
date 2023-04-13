using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEreporte
    {
        public int idReporte { get; set; }
        public BEusuario usuario { get; set; }
        public DateTime fechaCreacion { get; set; }
    }
}
