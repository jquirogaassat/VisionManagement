using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEprestamo
    {
        public int IdPrestamo { get; set; }
        public BEherramientas Herramienta  { get; set; }
        public BEcliente Cliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public int Dvh { get; set; }
    }
}
