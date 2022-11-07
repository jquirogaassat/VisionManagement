using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEerror
    {
        public BEerror(int errorId, string nombreTabla, string tipoDV, int ID)
        {
            idError = errorId;
            tabla = nombreTabla;
            tipoError = tipoDV; 
            id=ID;
        }

        public int idError { get; set; }
        public string tabla { get; set; }
        public string tipoError { get; set; }
        public int id { get; set; }
    }
}
