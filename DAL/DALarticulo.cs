using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Configuration;

namespace DAL
{
    public class DALarticulo : BE.ICRUd<BE.BEarticulo>
    {
        #region Singleton

        private DALarticulo()
        {

        }

        private static DALarticulo instancia;

        public static DALarticulo GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DALarticulo();
            }
            return instancia;
        }


        #endregion


        private string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        SqlHelper sqlHelper = new SqlHelper();

        public bool Alta(BEarticulo itemAlta)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("nombre", itemAlta.Nombre),
                new SqlParameter("color", itemAlta.Color),
                new SqlParameter("origen", itemAlta.Origen),
                new SqlParameter("cantidad", itemAlta.Cantidad),                
                new SqlParameter("precio",itemAlta.precio)
            };

            int nuevoId = sqlHelper.ExecuteQueryPRUEBA("articuloInsert", parameters);
            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
            int dvh = dvDal.CalcularDVH(consultarArticuloDT(nuevoId), 0);
            dvDal.CargarDVH("Articulo", nuevoId, dvh);
            int dvv = dvDal.CalcularDVV("Articulo");
            //DAL.DALarticulo articuloDal= new DALarticulo();

            

            return dvDal.CargarDVV(4, dvv);
        }

        public bool Baja(BEarticulo itemBaja)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idArticulo",itemBaja.Id),
            };
            bool resultado = sqlHelper.ExecuteQuery("articuloBajaLogica", parametros);

            if(resultado)
            {
                return true;
            }

            return (resultado);
            
        }

        public bool Modificar(BEarticulo itemModifica)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idArticulo", itemModifica.Id),
                new SqlParameter("nombre", itemModifica.Nombre),
                new SqlParameter("color", itemModifica.Color),
                new SqlParameter("origen", itemModifica.Origen),
                new SqlParameter("cantidad", itemModifica.Cantidad),
                new SqlParameter("precio",itemModifica.precio)
            };

            sqlHelper.ExecuteQuery("articuloUpdate", parametros);
            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
            int dvh = dvDal.CalcularDVH(consultarArticuloDT(itemModifica.Id),0);
            dvDal.CargarDVH("Articulo", itemModifica.Id, dvh);
            int dvv = dvDal.CalcularDVV("Articulo");
            return dvDal.CargarDVV(4, dvv);
        }

        public List<BEarticulo> Listar()
        {
            SqlParameter[] parametros = new SqlParameter[] { };
            DataTable dt = sqlHelper.ExecuteReader("articuloSelect", parametros);
            List<BEarticulo> articulos = new List<BEarticulo>();
            Mappers.MParticulo map = new Mappers.MParticulo();
            foreach(DataRow row in dt.Rows)
            {
                articulos.Add(map.Map(row));
            }
            return articulos;
        }


        public DataTable consultarArticuloDT(int idArticulo)
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idArticulo",idArticulo),
            };

            DataTable dt = sqlHelper.ExecuteReader("articuloConsulta", parametros);
            return dt;
        }

        public IList<BEarticulo> Lista()
        {
            throw new NotImplementedException();
        }

        public DataTable CargarInforme()
        {            
            DataTable DT = new DataTable();

            using(SqlConnection con= new SqlConnection(ConnectionString))
            {
                string query = @"SELECT a.nombre AS NombreArticulo,
                                 SUM(d.Cantidad) AS CantidadVendida,
                                 SUM(d.Cantidad * a.precio ) AS IngresosGenerados
                                 FROM DetalleFactura d
                                 JOIN 
                                 Articulo a ON d.idArticulo = a.idArticulo
                                 GROUP BY 
                                 a.nombre
                                 ORDER BY 
                                 CantidadVendida DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(DT);
                }
            }
            return DT;

        }
    }
}
