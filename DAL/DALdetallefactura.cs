using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public  class DALdetallefactura
    {
        #region Singleton
        private DALdetallefactura() { }

        private static DALdetallefactura instance;
        public DALdetallefactura GetInstance()
        {
            if (instance == null)
            {
                instance = new DALdetallefactura();
            }
            return instance;
        } 
        #endregion


        private SqlHelper sqlHelper= new SqlHelper();
        private string spInsert = "detalleFacturaInsert";       
        private string spDelete = "detalleFacturaDelete";
        public bool Add(BEdetallefactura itemAlta)
        {
            SqlParameter[] parametros = new SqlParameter[] {
            new SqlParameter("@id_articulo", itemAlta.IdArticulo),
            new SqlParameter("@id_factura", itemAlta.IdFactura),
            new SqlParameter("@cantidad",itemAlta.Cantidad),
            };
            bool returnValue = sqlHelper.ExecuteQuery(spInsert, parametros);

            return returnValue;
        }


        public bool Add(BEdetallefactura itemAlta, BEfactura factura)
        {
            SqlParameter[] parametros = new SqlParameter[] {
            new SqlParameter("@id_articulo", itemAlta.IdArticulo),
            new SqlParameter("@id_factura", itemAlta.IdFactura),
            new SqlParameter("@cantidad",itemAlta.Cantidad),
            };


            bool returnValue = sqlHelper.ExecuteQuery(spInsert, parametros);

            return returnValue;
        }


        public bool Delete(BEdetallefactura itemBaja)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id_detalleFactura",itemBaja.Id ),
            };

            bool returnValue= sqlHelper.ExecuteQuery(spDelete, parametros);

            return returnValue;
        }
    }
}
