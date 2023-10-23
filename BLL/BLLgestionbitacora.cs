using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLgestionbitacora : BE.ICRUd<BE.BEgestionbitacora>
    {

        BLL.BLLencriptacion encriptadora= new BLL.BLLencriptacion();
        DAL.DALbitacora DALbitacora = new DAL.DALbitacora();

        public bool Alta(BE.BEgestionbitacora itemAlta)
        {
            return DALbitacora.Alta(itemAlta);
        }

        public List<BE.BEgestionbitacora> Consulta(DateTime fechaDesde, DateTime fechaHasta, BE.BEusuario usuario, string orden, string criticidad)
        {
            List<BE.BEgestionbitacora> bitacoras= new List<BE.BEgestionbitacora>();
            bitacoras = DALbitacora.Consulta(fechaDesde, fechaHasta, usuario, orden, criticidad);

            foreach(BE.BEgestionbitacora b in bitacoras)
            {
                b.Descripcion = encriptadora.desencriptarAes(b.Descripcion);
            }
            //return DALbitacora.Consulta(fechaDesde,fechaHasta,usuario,orden,criticidad);
            return bitacoras;
        }

      

        public bool Baja(BEgestionbitacora itemBaja)
        {
            throw new NotImplementedException();
        }


        public List<BEgestionbitacora> Listar()
        {
            List<BEgestionbitacora> bitacora = new List<BEgestionbitacora>();
            bitacora = DALbitacora.Consultar();
            foreach(BEgestionbitacora b in bitacora)
            {
                b.Descripcion = encriptadora.desencriptarAes(b.Descripcion);
            }
            return bitacora;
           // throw new NotImplementedException();
        }
        
        public bool Modificar(BEgestionbitacora itemModifica)
        {
            throw new NotImplementedException();
        }

     

        public IList<BEgestionbitacora> Lista()
        {
            throw new NotImplementedException();
        }
    }
}
