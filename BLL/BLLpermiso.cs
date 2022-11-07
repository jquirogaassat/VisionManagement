using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLpermiso : BE.ICRUd<BE.BEpermiso>
    {
        BLL.BLLencriptacion encriptadora = new BLLencriptacion();
        DAL.DALpermiso DALpermiso = new DAL.DALpermiso();
        BE.BEpermiso familiaBe = new BE.BEfamilia("", "");
        BE.BEpermiso patenteBe = new BE.BEpatente("");

        public bool Alta(BEpermiso itemAlta)
        {
            itemAlta.nombrePermiso = encriptadora.encriptarAES(itemAlta.nombrePermiso);
            return DALpermiso.Alta(itemAlta);
           // throw new NotImplementedException();
        }

        public bool Baja(BEpermiso itemBaja)
        {
            return DALpermiso.Baja(itemBaja);
           // throw new NotImplementedException();
        }

        public IList<BEpermiso> Listar()
        {
            throw new NotImplementedException();
        }

        public List<BE.BEpermiso> Consulta()
        {
            return DALpermiso.Consulta();
        }

        public bool Modificar(BEpermiso itemModifica)
        {
            itemModifica.nombrePermiso = encriptadora.encriptarAES(itemModifica.nombrePermiso);
            return DALpermiso.Modificar(itemModifica);
            //throw new NotImplementedException();
        }


        public BLLpermiso()
        {
            DALpermiso= new DAL.DALpermiso();
        }

        public BE.BEpermiso Consultar(string nombrePermiso)
        {
            return DALpermiso.Consultar(nombrePermiso);
        }

        public BE.BEpermiso Consultar (int idPermiso)
        {
            return DALpermiso.Consultar(idPermiso);
        }

        public bool Existe(string nombre)
        {
            return DALpermiso.Existe(nombre);
        }

        public List<BE.BEpermiso> ConsultarFamilias()
        {
            List<BE.BEpermiso> familias = new List<BE.BEpermiso>();
            familias = DALpermiso.ConsultarFamilias();
            foreach(BE.BEpermiso permiso in familias)
            {
                permiso.nombrePermiso = encriptadora.desencriptarAes(permiso.nombrePermiso);
            }
            return familias;
        }

        public bool QuitarAsignaciones(BE.BEpermiso p)
        {
            return DALpermiso.QuitarAsignaciones(p);
        }


        public void Asignar(BE.BEpermiso a, BE.BEpermiso b)
        {
             DALpermiso.Asignar(a, b);
        }
    }
}
