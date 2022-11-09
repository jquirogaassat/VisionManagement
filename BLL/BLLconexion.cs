using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLconexion
    {

      DAL.DALconexion conexion = new DAL.DALconexion();


        public void CambiarConexion(string cadena)
        {
            conexion.cambiar(cadena);
        }

        public bool ComprobarConexion()
        {
           DAL.DALconexion conexion = new DAL.DALconexion();
            return conexion.Comprobar();
        }
    }
}
