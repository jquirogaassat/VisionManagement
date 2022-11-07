using Infraestructura;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Daos
{
    internal class Daobitacora : Infraestructura.ICRUD<Infraestructura.Bitacora>
    {

        private string cnn= @"Data Source=.\sqlexpress;Initial Catalog=VisionManagement;Integrated Security=True";
        private SqlConnection conn;
        

        public bool Alta(Bitacora item)
        {
            throw new NotImplementedException();
        }

        public bool Baja(Bitacora item)
        {
            throw new NotImplementedException();
        }

        public IList<Bitacora> Listar(Bitacora item)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Bitacora item)
        {
            throw new NotImplementedException();
        }
    }
}
