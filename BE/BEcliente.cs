using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEcliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int IdCliente { get; set; }
        public int Dvh { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }
    }
}
