using BE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALfactura
    {
        private SqlHelper sqlHelper = new SqlHelper();
        private string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private string spInsert = "FacturaInsert";
        private string spDelete = "FacturaDelete";
        private string spSelectAll= "FacturaSelectAll";
        private string spSelectAllById = "FacturaSelectAllByIntIdCliente";
        private string spSelectByIdFactura = "FacturaSelect";
        private SqlCommand cmd;

        // alta de factura
        public bool Add(BEfactura facAlta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@fecha",facAlta.Fecha),
                new SqlParameter("@id_cliente",facAlta.IdCliente),
            };


            bool returnValue= sqlHelper.ExecuteQuery(spInsert, parametros);

            return returnValue;
        }

        //baja de factura
        public bool Delete(BEfactura facBaja)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id_factura",facBaja.Id),
            };

            bool returnValue= sqlHelper.ExecuteQuery(spDelete, parametros);
            return returnValue;
        }

        // traigo todas las facturas
        public IList<BEfactura> GetAll()
        {
            DataSet table = new DataSet();

            table.Tables.Add(sqlHelper.ExecuteReader(spSelectAll));

            return Mappers.MpFactura.getInstancia().Map(table);
        }

        // traigo facturas por id de cliente
        public List<BEfactura> SellectAllByIdCliente(BEfactura factura) 
        {
            DataSet ds= new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd = new SqlCommand();
            var cnn = new SqlConnection(ConnectionString);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spSelectAllById;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id_cliente", factura.IdCliente);

            adapter.SelectCommand=cmd;

            adapter.Fill(ds);

            return Mappers.MpFactura.getInstancia().Map(ds);

        }

        // traigo la factura por id de factura
        public BEfactura GetAllById(BEfactura bEfactura) 
        {
            List<BEfactura> factu = new List<BEfactura>();
            BEfactura facturabe = new BEfactura();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spSelectByIdFactura;
            var cnn = new SqlConnection(ConnectionString);

            cmd.Connection=cnn;
            cmd.Parameters.AddWithValue("@id_factura",bEfactura.Id);
            adapter.SelectCommand=cmd;
            adapter.Fill(ds);

            factu = Mappers.MpFactura.getInstancia().Map(ds);
            facturabe = factu[0];

            return facturabe;

        }
    }
}
