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

        public List<BE.BEgestionbitacora> Consulta()
        {
            return DALbitacora.Consulta();
        }

        public List<BE.BEgestionbitacora> Consulta(DateTime fechaDesde, DateTime fechaHasta, BE.BEusuario usuario, string orden, string criticidad)
        {
            List<BE.BEgestionbitacora> bitacoras= new List<BE.BEgestionbitacora>(); 
            bitacoras= DALbitacora.Consulta(fechaDesde, fechaHasta, usuario, orden, criticidad);

            foreach(BE.BEgestionbitacora bitacora in bitacoras)
            {
                bitacora.Descripcion = encriptadora.desencriptarAes(bitacora.Descripcion);
            }
            return bitacoras;
        }

        public bool Baja(BEgestionbitacora itemBaja)
        {
            throw new NotImplementedException();
        }

        public List<BEgestionbitacora> Listar(DateTime desde, DateTime hasta, string usuario,string criticidad, bool ordFecha, bool ordUsuario, bool ordCriticidad, bool fechaDesc, bool usuarioDes, bool criticidadDesc)
        {
            return DALbitacora.Listar(desde, hasta, usuario, criticidad, ordFecha, ordUsuario, ordCriticidad, fechaDesc, usuarioDes, criticidadDesc);
        }

        public bool Modificar(BEgestionbitacora itemModifica)
        {
            throw new NotImplementedException();
        }

        List<BEgestionbitacora> ICRUd<BEgestionbitacora>.Listar()
        {
            throw new NotImplementedException();
        }

        public IList<BEgestionbitacora> Lista()
        {
            throw new NotImplementedException();
        }
    }
}
