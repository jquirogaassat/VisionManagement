using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLingreso : BE.ICRUd<BE.BEingreso>
    {
        public bool Alta(BEingreso itemAlta)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BEingreso itemBaja)
        {
            throw new NotImplementedException();
        }

        public IList<BEingreso> Lista()
        {
            throw new NotImplementedException();
        }

        public IList<BEingreso> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEingreso itemModifica)
        {
            throw new NotImplementedException();
        }

        List<BEingreso> ICRUd<BEingreso>.Listar()
        {
            throw new NotImplementedException();
        }
    }
}
