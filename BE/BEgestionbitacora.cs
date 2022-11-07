using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEgestionbitacora
    {
        public string Descripcion { get; set; }
        public string Criticidad { get; set; }
        public int IdUsuario { get; set; }
        public int IdBitacora { get; set; }
        public int Dvh { get; set; }
        public DateTime FechaHora { get; set; }
        public int idPatente { get; set; }
    }
}
