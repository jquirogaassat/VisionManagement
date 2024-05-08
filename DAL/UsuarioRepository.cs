using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BE;
using System.Configuration;

namespace DAL
{
    public class UsuarioRepository
    {
        DAL.SqlHelper helper = new SqlHelper();
        string ConnectionString =ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        public UsuarioRepository()
        {

        }  


        public List<BEusuario> GetAll()
        {
            var cnn= new SqlConnection(ConnectionString);
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;


            var sql= $@"select * from Usuario;";
            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();
            var list = new List<BEusuario>();

            while(reader.Read())
            {
                BEusuario u = new BEusuario();
                u.IdUsuario = reader.GetInt32(reader.GetOrdinal("idUsuario"));
                u.Nombre = reader.GetString(reader.GetOrdinal("nombre"));
                list.Add(u);
            }

            reader.Close();
            cnn.Close();
            return list;
        }


        public void GuardarPermisos(BEusuario u)
        {
            try
            {
                var cnn = new SqlConnection(ConnectionString);
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText= $@"delete from usuarios_permisos where idUsuario=@idUsuario;";
                cmd.Parameters.Add(new SqlParameter("idUsuario", u.IdUsuario));                
                cmd.ExecuteNonQuery();

                foreach(var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;
                     
                    var query2 = "insert into usuarios_permisos (idUsuario,idPermiso) values (" + u.IdUsuario + ","+item.Id+ ")";
                
                    helper.ExecuteQuery(query2);
                 
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
