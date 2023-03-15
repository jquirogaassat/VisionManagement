using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLnotadebito : BE.ICRUd<BE.BEnotadebito>
    {
        public bool Alta(BEnotadebito itemAlta)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BEnotadebito itemBaja)
        {
            throw new NotImplementedException();
        }

        public IList<BEnotadebito> Lista()
        {
            throw new NotImplementedException();
        }

        public IList<BEnotadebito> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEnotadebito itemModifica)
        {
            throw new NotImplementedException();
        }

        List<BEnotadebito> ICRUd<BEnotadebito>.Listar()
        {
            throw new NotImplementedException();
        }
    }
}
