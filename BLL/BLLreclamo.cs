using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLreclamo : BE.ICRUd<BE.BEreclamo>
    {
        public bool Alta(BEreclamo itemAlta)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BEreclamo itemBaja)
        {
            throw new NotImplementedException();
        }

        public IList<BEreclamo> Lista()
        {
            throw new NotImplementedException();
        }

        public IList<BEreclamo> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEreclamo itemModifica)
        {
            throw new NotImplementedException();
        }

        List<BEreclamo> ICRUd<BEreclamo>.Listar()
        {
            throw new NotImplementedException();
        }
    }
}
