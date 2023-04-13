using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public  class DALreporte
    {
        SqlHelper sqlHelper= new SqlHelper();

        public int Alta (BE.BEreporte reporte)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idUsuario",reporte.usuario.IdUsuario),
            };

            return sqlHelper.ExecuteQueryPRUEBA("reporteInsert", parametros);
        }
    }
}
