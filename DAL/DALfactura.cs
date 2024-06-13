using BE;
using DAL.Mappers;
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
  
        public int AddPrueba(BEfactura factura)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Factura (IdCliente, Fecha) OUTPUT INSERTED.idFactu VALUES (@IdCliente, @Fecha)", conn);
                cmd.Parameters.AddWithValue("@IdCliente", factura.IdCliente);
                cmd.Parameters.AddWithValue("@Fecha", factura.Fecha);

                // Obtener el ID generado
                int newId = (int)cmd.ExecuteScalar();
                DALdigitoverificador dvDAL = new DALdigitoverificador();
                int dvh = dvDAL.CalcularDVH(ConsultarFacturaDT(newId), 0);
                dvDAL.CargarDVH("Factura", newId, dvh);
                int dvv = dvDAL.CalcularDVV("Factura");
                dvDAL.CargarDVV(5, dvv);
                return newId;
            }
        }

        //baja de factura
        public bool Delete(BEfactura facBaja)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id_factu",facBaja.Id),
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

        public DataTable CargarReporte()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = @"
                     SELECT 
                        c.Nombre,
	                    c.apellido,
                        f.IdFactu,
	                    f.fecha,
                        SUM(df.Cantidad * a.precio) AS TotalFactura
                    FROM 
                        Cliente c
                    INNER JOIN 
                        Factura f ON c.idCliente = f.idCliente
                    INNER JOIN 
                        DetalleFactura df ON f.IdFactu = df.IdFactura
                    INNER JOIN
	                    Articulo a ON df.idArticulo = a.idArticulo
                    GROUP BY 
                        c.Nombre,c.apellido, f.idFactu, f.fecha
                    ORDER BY 
                        f.idFactu";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
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
            cmd.Parameters.AddWithValue("@id_factu",bEfactura.Id);
            adapter.SelectCommand=cmd;
            adapter.Fill(ds);

            factu = Mappers.MpFactura.getInstancia().Map(ds);
            facturabe = factu[0];

            return facturabe;

        }

        public DataTable ConsultarFacturaDT(int idFactura)
        {
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("idFactu",idFactura),
           };
            return sqlHelper.ExecuteReader("facturaConsultarPorID", parameters);
        }
    }
}
