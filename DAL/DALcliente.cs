    using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALcliente : BE.ICRUd<BE.BEcliente>
    {

        DAL.DALdigitoverificador dv= new DALdigitoverificador();
        SqlHelper helper = new SqlHelper();
        

        public bool Alta(BEcliente itemAlta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("apellido", itemAlta.Apellido),
                new SqlParameter("nombre", itemAlta.Nombre),
                new SqlParameter("cuit",itemAlta.Cuit),
                new SqlParameter("mail", itemAlta.Email),
                new SqlParameter("direccion",itemAlta.Direccion),
                new SqlParameter("localidad",itemAlta.Localidad),
                new SqlParameter("telefono",itemAlta.Telefono),
            };

            int nuevoClienteID= helper.ExecuteQueryPRUEBA("clienteInsert",parametros);
            return nuevoClienteID > 0; 
        }

        public bool Baja(BEcliente itemBaja)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idCliente",itemBaja.IdCliente),
            };
            bool resultado = helper.ExecuteQuery("clienteBajaLogica", parametros);
            if(resultado)
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
           SqlParameter [] parametros = new SqlParameter[]
                {};
            DataTable dt = helper.ExecuteReader("clienteSelect", parametros);
            List<BE.BEcliente> clientes = new List<BEcliente>();
            Mappers.MPcliente map = new Mappers.MPcliente();

            foreach(DataRow row in dt.Rows)
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
            bool resultado = helper.ExecuteQuery("clienteUpdate", parametros);

            return resultado;
        }

        public DataTable ConsultarClienteDT(int idCliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idCliente",idCliente),
            };

            DataTable dt= helper.ExecuteReader("ClienteConsultar",parametros),
            return dt;
        }
    }
}
