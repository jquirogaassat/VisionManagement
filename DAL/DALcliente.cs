using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class DALcliente : BE.ICRUd<BE.BEcliente>
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private DALdigitoverificador dv= new DALdigitoverificador();
        private SqlHelper helper = new SqlHelper();

        #region ABM's
        public bool Alta(BEcliente itemAlta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("apellido", itemAlta.Apellido),//si
                new SqlParameter("nombre", itemAlta.Nombre),//si
                new SqlParameter("cuit",itemAlta.Cuit),//si
                new SqlParameter("mail", itemAlta.Email),//si
                new SqlParameter("direccion",itemAlta.Direccion),//si
                new SqlParameter("localidad",itemAlta.Localidad),//si
                new SqlParameter("telefono",itemAlta.Telefono),//si
            };

            int nuevoClienteID = helper.ExecuteQueryPRUEBA("clienteInsert", parametros);
            int dvh = dv.CalcularDVH(ConsultarClienteDT(nuevoClienteID), 0);
            dv.CargarDVH("Cliente", nuevoClienteID, dvh);
            int dvv = dv.CalcularDVV("Cliente");
            dv.CargarDVV(3, dvv);
            //int dvh = dvDal.CalcularDVH(ConsultarUsuarioDT(nuevoId), 0);
            //dvDal.CargarDVH("Usuario", nuevoId, dvh);
            //int dvv = dvDal.CalcularDVV("Usuario");


            //itemAlta.IdUsuario = nuevoId;
            //return dvDal.CargarDVV(2, dvv);
            return nuevoClienteID > 0;
        }

        public bool Baja(BEcliente itemBaja)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idCliente",itemBaja.IdCliente),
            };
            bool resultado = helper.ExecuteQuery("clienteBajaLogica", parametros);
            if (resultado)
            {
                return true;
            }

            return resultado;
            // throw new NotImplementedException();
        }

        public IList<BEcliente> Lista()
        {
            throw new NotImplementedException();
        }

        public List<BEcliente> Listar()
        {
            SqlParameter[] parametros = new SqlParameter[]
                 {};
            DataTable dt = helper.ExecuteReader("clienteSelect", parametros);
            List<BE.BEcliente> clientes = new List<BEcliente>();
            Mappers.MPcliente map = new Mappers.MPcliente();

            foreach (DataRow row in dt.Rows)
            {
                clientes.Add(map.Map(row));
            }

            // throw new NotImplementedException();
            return clientes;
        }

        public bool Modificar(BEcliente itemModifica)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idCliente",itemModifica.IdCliente),
                new SqlParameter("apellido", itemModifica.Apellido),
                new SqlParameter("nombre", itemModifica.Nombre),
                new SqlParameter("cuit",itemModifica.Cuit),
                new SqlParameter("mail", itemModifica.Email),
                new SqlParameter("direccion",itemModifica.Direccion),
                new SqlParameter("localidad",itemModifica.Localidad),
                new SqlParameter("telefono",itemModifica.Telefono),

            };

            helper.ExecuteQuery("clienteUpdate", parametros);
            int dvh = dv.CalcularDVH(ConsultarClienteDT(itemModifica.IdCliente), 0);
            dv.CargarDVH("CLiente", itemModifica.IdCliente, 0);
            int dvv = dv.CalcularDVV("Cliente");


            return dv.CargarDVV(4, dvv);
        }

        public DataTable ConsultarClienteDT(int idCliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idCliente",idCliente),
            };

            DataTable dt = helper.ExecuteReader("ClienteConsultar", parametros);
            return dt;
        }

        #endregion

        #region INforme
        public DataTable CargarInforme()
        {
            DataTable DT = new DataTable();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT 
                                        c.idCliente AS NumeroDeCliente,
                                        c.Nombre AS NombreCliente,
                                        c.Apellido AS ApellidoCliente,
                                        COUNT(f.idFactura) AS NumeroCompras
                                    FROM 
                                        Cliente c
                                    JOIN 
                                        Factura f ON c.idCliente = f.IdCliente
                                    GROUP BY 
                                        c.idCliente, c.Nombre, c.Apellido
                                    ORDER BY 
                                        NumeroCompras DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(DT);
                }
            }
            return DT;

        }
        #endregion

    }
}
