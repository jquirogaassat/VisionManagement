using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEbitacoraC
    {
        public int Id { get;set; }
        public int Activo { get; set; }
        public string Usuario {  get;set; }
        public DateTime UltimaModificacion {  get;set; }
        public BEherramientas IdHerramienta { get;set; }
        public string Tipo { get; set; }
        
    }
}
