using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class Bitacora : ICRUD<Bitacora>
    {

        Encriptadora encriptadora = new Encriptadora();
        
        public bool Alta(Bitacora item)
        {
            throw new NotImplementedException();
        }

        public bool Baja(Bitacora item)
        {
            throw new NotImplementedException();
        }

        public IList<Bitacora> Listar(Bitacora item)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Bitacora item)
        {
            throw new NotImplementedException();
        }
    }
}
