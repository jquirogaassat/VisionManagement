using BE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALbitacoraC
    {
        
       
      public int ReportarBitacoraArticulo(BEbitacoraC bitacora)
        {
            string cmd = "INSERT INTO BitacoraArticulos (ArticuloId,Nombre,Cantidad,FechaModificacion,Accion,precio) VALUES"
                        + "(" + bitacora.Articulo.Id + "','" + bitacora.Nombre + "','" + bitacora.Cantidad + "','" + bitacora.UltimaModificacion
                        + "','" + bitacora.Accion + "','" + bitacora.Articulo.precio + " ');";


            SqlHelper sqlHelper = new SqlHelper();

            return sqlHelper.ExecuteQueryPRUEBA(cmd);

        }



    }
}
