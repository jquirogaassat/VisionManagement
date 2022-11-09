using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;


namespace DAL.Daos
{
    internal class DAOusuario : BE.ICRUd<BE.BEusuario>
    {
        SqlHelper sqlHelper= new SqlHelper();
       // Encriptadora encriptadora= new Encriptadora();


        private string connstring= @"Data Source=.\sqlexpress;Initial Catalog=VisionManagement;Integrated Security=True";
        private SqlConnection cnn;
        private string insertQuery = "insert into Usuario values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}' )";
        public bool Alta(BEusuario itemAlta)
        {


            throw new NotImplementedException();
        }

        public bool Baja(BEusuario itemBaja)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEusuario itemModifica)
        {
            throw new NotImplementedException();
        }

        public IList<BEusuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
