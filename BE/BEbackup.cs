using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEbackup
    {
        public string Ubicacion { get; set; }
        public BEusuario Usuario { get; set; }
        public int Tamanio { get; set; }
        public int IdBackup { get; set; }
        public DateTime FechaAlta { get; set; }

        public int  Particiones { get; set; }
        public string  Nombre { get; set; }

       
    }
}
