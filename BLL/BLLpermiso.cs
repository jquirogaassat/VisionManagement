using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLpermiso 
    {
        BLL.BLLencriptacion encriptadora = new BLLencriptacion();
        DAL.DALpermiso DALpermiso = new DAL.DALpermiso();
        // BE.BEpermiso familiaBe = new BE.BEfamilia("", "");
        //BE.BEpermiso patenteBe = new BE.BEpatente("");


        PermisosRepository _permisos;
       
        public BLLpermiso()
        {
            _permisos = new PermisosRepository();
        }
      
        public bool Existe (BEcomponente c, int id)
        {
            bool existe = false;
            if(c.Id.Equals(id))
                existe = true;
            else

            foreach(var item in c.Hijos)
                {
                    existe=Existe(item,id);
                    if(existe) return true;
                }
            return existe;
        }


        public Array GetAllPermission()
        {
            return _permisos.GetAllPermission();
        }

        public BEcomponente GuardarComponente(BEcomponente p, bool esFamilia)
        {
            return _permisos.GuardarComponente(p, esFamilia);
        }
       
        public void GuardarFamilia(BEfamilia f)
        {
            _permisos.GuardarFamilia(f);
        }

        public IList<BEfamilia> GetAllFamilias()
        {
            return _permisos.GetAllFamilias();
        }

        public IList<BEcomponente> GetAll(string familia)
        {
            return _permisos.GetAll(familia);
        }

        public void FillUserComponents(BEusuario u)
        {
            _permisos.FillUserComponents(u);
        }

        public void FillFamilyComponents(BEfamilia f)
        {
            _permisos.FillFamilyComponents(f);
        }

        public IList<BEpatente> GetAllPatentes()
        {
            return _permisos.GetAllPatentes();
        }
      
        

        public void Asignar(BE.BEpermiso a, BE.BEpermiso b)
        {
             DALpermiso.Asignar(a, b);
        }

        //public List<BE.BEpermiso> ObtenerHijos(BE.BEpermiso bEpermiso)
        //{
        //    List<BE.BEpermiso> permisos = new List<BEpermiso>();
        //    permisos = DALpermiso.ObtenerHijos(bEpermiso);

        //    foreach(BE.BEpermiso p in permisos)
        //    {
        //        p.nombrePermiso = encriptadora.desencriptarAes(p.nombrePermiso);
        //    }
        //    return permisos;
        //}




        //public List<BE.BEpermiso> ObtenerPermisoRecursivo(BE.BEpermiso permiso)
        //{
        //    List<BE.BEpermiso> permisos = new List<BEpermiso>();
        //    permisos = DALpermiso.ObtenerPermisosRecursivos("=" + permiso.idPermiso);

        //    foreach(BE.BEpermiso per in permisos)
        //    {
        //        per.nombrePermiso = encriptadora.desencriptarAes(per.nombrePermiso);
        //    }

        //    return permisos;

        //}


        //public void EncriptarPatentes()
        //{
        //    List<BE.BEpermiso> permisos = new List<BEpermiso>();
        //    permisos = DALpermiso.Consulta();


        //    foreach(BE.BEpermiso permiso in permisos)
        //    {
        //        permiso.nombrePermiso=encriptadora.encriptarAES(permiso.nombrePermiso);
        //        DALpermiso.Modificar(permiso);
        //    }


        //}

        //public void DesencriptarPatentes()
        //{
        //    List<BE.BEpermiso> permisos = new List<BEpermiso>();
        //    permisos=DALpermiso.Consulta();

        //    foreach(BE.BEpermiso permiso in permisos)
        //    {
        //        permiso.nombrePermiso = encriptadora.desencriptarAes(permiso.nombrePermiso);
        //        DALpermiso.Modificar(permiso);
        //    }    
        //}
        //public BE.BEpermiso Consultar(string nombrePermiso)
        //{
        //    return DALpermiso.Consultar(nombrePermiso);
        //}





    }
}
