using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        private SqlHelper sqlHelper= new SqlHelper();
        private string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private string spInsert = "detalleFacturaInsert";       
        private string spDelete = "detalleFacturaDelete";
        private SqlCommand cmd;


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



        public List<BEdetallefactura> GetAll(BEfactura facDet) 
        {
            
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd = new SqlCommand();
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "DetalleFacturaSelectAllByIntIdFactura";
            var cnn = new SqlConnection(ConnectionString);
            cmd.Connection= cnn;
            cmd.Parameters.AddWithValue("@id_factura", facDet.Id);

            adapter.SelectCommand = cmd;
            adapter.Fill(ds);

            return Mappers.Mpdetalle.GetInstance().Map(ds);

        }


     
    }
}
