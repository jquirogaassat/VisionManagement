using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepository
    {
        public UsuarioRepository()
        {

        }

        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = ".";
            cs.InitialCatalog = "upf";
            return cs.ConnectionString;
        }

        public List<BE.BEusuario> GetAll()
        {
            var cnn = new SqlConnection(GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = $@"select * from usuarios;";

            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<BE.BEusuario>();

            while(reader.Read())
            {
                BE.BEusuario u= new BE.BEusuario();
                u.Id = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                u.UserName = reader.GetString(reader.GetOrdinal("nombre"));
                lista.Add(u);

            }
            reader.Close();
            cnn.Close();
            return lista;

                                                                        
            
        }


        public void GuardarPermisos(BE.BEusuario u)
        {
            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText= $@"delete from usuarios_permisos where id_usuario=@id;";
                cmd.Parameters.Add(new SqlParameter("id", u.Id));
                cmd.ExecuteNonQuery();

                foreach (var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText= $@"insert into usuarios_permisos (id_usuario,id_permiso) 
                                                             values (@id_usuario,@id_permiso) ";

                    cmd.Parameters.Add(new SqlParameter("id_usuario", u.Id));
                    cmd.Parameters.Add(new SqlParameter("id_permiso", item.Id));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
