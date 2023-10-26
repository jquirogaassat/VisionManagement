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
        public int Cantidad {  get;set; }
        public string Usuario {  get;set; }
        public DateTime UltimaModificacion {  get;set; }
        public BEarticulo Articulo { get;set; }
        public string Nombre { get; set; }
        public string Accion {  get;set; }
    }
}
