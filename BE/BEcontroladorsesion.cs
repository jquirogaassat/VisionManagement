using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEcontroladorsesion
    {

        private static object _lock = new object();
        private static BEcontroladorsesion session;
        private DateTime FechaIngreso { get; set; }
        public BEusuario Usuario;

        public static BEcontroladorsesion GetInstance
        {
            get { return session; }
        }

        public static BEreusltadoLog Log(BE.BEusuario usuario)
        {

            lock (_lock)
            {
                if (session == null)
                {
                    session = new BEcontroladorsesion();
                    session.Usuario = usuario;
                    session.FechaIngreso = DateTime.Now;
                    return BE.BEreusltadoLog.LoginCorrecto;
                }
                else
                {
                    return BE.BEreusltadoLog.SesionActiva;
                }
            }
        }


        public static bool Logout()
        {
            if (session != null)
            {
                session = null;
                return true;
            }
            else
            {
                return false;
            }
        }

        private BEcontroladorsesion()
        {

        }

        public bool IsLoggedIn()
        {
            return Usuario != null;
        }

        bool IsInRole(BEcomponente c, BEtipoPermiso permiso, bool existe)
        {
            if (c.Permiso.Equals(permiso))
                existe = true;
            else
            {
                foreach (var item in c.Hijos)
                {
                    existe = IsInRole(item, permiso, existe);
                    if (existe) return true;
                }
            }

            return existe;
        }


        public bool IsInRole(BEtipoPermiso permiso)
        {
            bool existe = false;
            foreach(var item in Usuario.Permisos)
            {
                if(item.Permiso.Equals(permiso))
                {
                    return true;
                }
                else
                {
                    existe = IsInRole(item, permiso, existe);
                    if (existe)
                        return true;
                }
            }
            return existe;
        }




             

    }
}

