using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLcliente : BE.ICRUd<BE.BEcliente>
    {
          
        DAL.DALcliente clienteDal = new DAL.DALcliente();
        public bool Alta(BEcliente item)
        {
            BLL.BLLencriptacion encriptar = new BLL.BLLencriptacion();
            item.Telefono = encriptar.encriptarAES(item.Telefono);
            item.Direccion = encriptar.encriptarAES(item.Direccion);
            item.Localidad = encriptar.encriptarAES(item.Localidad);
            DAL.DALcliente clientedal = new DAL.DALcliente();
            return clientedal.Alta(item);
        }

        public bool Baja(BEcliente item)
        {
            throw new NotImplementedException();
        }

        public IList<BEcliente> Listar(BEcliente item)
        {
            throw new NotImplementedException();
        }

        public IList<BEcliente> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEcliente item)
        {
            throw new NotImplementedException();
        }
    }
}
