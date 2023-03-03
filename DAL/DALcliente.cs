using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
            throw new NotImplementedException();
        }

        public IList<BEcliente> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEcliente itemModifica)
        {
            throw new NotImplementedException();
        }
    }
}
