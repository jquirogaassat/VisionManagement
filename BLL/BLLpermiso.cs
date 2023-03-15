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

        public List<BE.BEpermiso> ObtenerHijos(BE.BEpermiso bEpermiso)
        {
            List<BE.BEpermiso> permisos = new List<BEpermiso>();
            permisos = DALpermiso.ObtenerHijos(bEpermiso);

            foreach(BE.BEpermiso p in permisos)
            {
                p.nombrePermiso = encriptadora.desencriptarAes(p.nombrePermiso);
            }
            return permisos;
        }


        public List<BE.BEpermiso> PermisosNoAsignados( BE.BEpermiso permiso)
        {
            List<BE.BEpermiso> permisoT = Consulta();
            List<BE.BEpermiso> permisoA = ObtenerHijos(permiso);
            List<BE.BEpermiso> permisoD = new List<BEpermiso>() { };


            foreach(BE.BEpermiso per in permisoT)
            {
                if (!(permisoA.Exists(permisos => permisos.idPermiso == per.idPermiso)))
                {
                    permisoD.Add(per);
                }
            }

            foreach(BE.BEpermiso p in permisoD)
            {
                p.nombrePermiso = encriptadora.desencriptarAes(p.nombrePermiso);
            }

            return permisoD;

        }


        public bool AsignacionDirecta(BE.BEpermiso permisoPadre, BE.BEpermiso permisoHijo)
        {
            return DALpermiso.AsignacionDirecta(permisoPadre, permisoHijo);
        }

        public bool QuitarPermisos(BE.BEpermiso pHijo , BE.BEpermiso pPadre)
        {
            return DALpermiso.QuitarPermiso(pHijo, pPadre);
        }


        public bool TienePermiso(BE.BEpermiso pPadre, BE.BEpermiso pHijo)
        {
            List<BE.BEpermiso> permisos = ObtenerPermisoRecursivo(pPadre).ToList();
            return permisos.Exists(p => p.idPermiso == pHijo.idPermiso);
        }

        public List<BE.BEpermiso> ObtenerPermisoRecursivo(BE.BEpermiso permiso)
        {
            List<BE.BEpermiso> permisos = new List<BEpermiso>();
            permisos = DALpermiso.ObtenerPermisosRecursivos("=" + permiso.idPermiso);

            foreach(BE.BEpermiso per in permisos)
            {
                per.nombrePermiso = encriptadora.desencriptarAes(per.nombrePermiso);
            }

            return permisos;

        }


        public void EncriptarPatentes()
        {
            List<BE.BEpermiso> permisos = new List<BEpermiso>();
            permisos = DALpermiso.Consulta();


            foreach(BE.BEpermiso permiso in permisos)
            {
                permiso.nombrePermiso=encriptadora.encriptarAES(permiso.nombrePermiso);
                DALpermiso.Modificar(permiso);
            }

            
        }

        public void DesencriptarPatentes()
        {
            List<BE.BEpermiso> permisos = new List<BEpermiso>();
            permisos=DALpermiso.Consulta();

            foreach(BE.BEpermiso permiso in permisos)
            {
                permiso.nombrePermiso = encriptadora.desencriptarAes(permiso.nombrePermiso);
                DALpermiso.Modificar(permiso);
            }    
        }



        public List<BE.BEusuario> Usuarios( BE.BEpermiso permiso)
        {
            BLL.BLLusuario BLLusuario= new BLLusuario();
            List<BE.BEusuario> usuarios = BLLusuario.Consulta().Where(u => u.IsBlocked == "NO").ToList();


            List<BE.BEusuario> usuarioMiebro = new List<BEusuario>();

            foreach(BE.BEusuario user in usuarios)
            {
                if(BLLusuario.AsignacionDirecta(user,permiso))
                {
                    usuarioMiebro.Add(user);
                }
            }
            return usuarioMiebro;
        }

        List<BEpermiso> ICRUd<BEpermiso>.Listar()
        {
            throw new NotImplementedException();
        }

        public IList<BEpermiso> Lista()
        {
            throw new NotImplementedException();
        }
    }
}
