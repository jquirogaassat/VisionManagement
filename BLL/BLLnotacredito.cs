using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLnotacredito : BE.ICRUd<BE.BEnotacredito>
    {
        public bool Alta(BEnotacredito itemAlta)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BEnotacredito itemBaja)
        {
            throw new NotImplementedException();
        }

        public IList<BEnotacredito> Lista()
        {
            throw new NotImplementedException();
        }

        public IList<BEnotacredito> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEnotacredito itemModifica)
        {
            throw new NotImplementedException();
        }

        List<BEnotacredito> ICRUd<BEnotacredito>.Listar()
        {
            throw new NotImplementedException();
        }
    }
}
