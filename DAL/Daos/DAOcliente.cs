using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Daos
{
    internal class DAOcliente : BE.ICRUd<BE.BEcliente>
    {
        public bool Alta(BEcliente itemAlta)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BEcliente itemBaja)
        {
            throw new NotImplementedException();
        }

        public IList<BEcliente> Lista()
        {
            throw new NotImplementedException();
        }

        public List<BEcliente> Listar()
        {
            //SqlHelper helper = new SqlHelper();
            //DataSet ds= new DataSet();
            //SqlDataAdapter da = new SqlDataAdapter();
            //SqlCommand comm = new SqlCommand();
            //comm.Connection
            throw new NotImplementedException();
        }

        public bool Modificar(BEcliente itemModifica)
        {
            throw new NotImplementedException();
        }
    }
}
