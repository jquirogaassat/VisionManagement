using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEpermiso
    {
        string _nombrePermiso;

        public BEpermiso(string nombre)
        {
            nombrePermiso = nombre;
        }

        public int idPermiso { get; set; }

        public string nombrePermiso
        {
            get
            {
                return _nombrePermiso;
            }
            set
            {
                _nombrePermiso = value;
            }
        }

        public bool esFamilia { get; set; }
        public  string tipoFamilia { get; set; }
    }
}
