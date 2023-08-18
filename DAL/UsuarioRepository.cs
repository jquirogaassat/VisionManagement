using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BE;

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
            cs.InitialCatalog = "VisionManagement";
            return cs.ConnectionString;
        }


        public List<BEusuario> GetAll()
        {
            var cnn= new SqlConnection(GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;


            var sql= $@"select * from usuarios;";
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
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText= $@"delete from usuarios_permisos where id_usuario=@id;";
                cmd.Parameters.Add(new SqlParameter("idUsuario", u.IdUsuario));
                cmd.ExecuteNonQuery();

                foreach(var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;
                    cmd.CommandText= $@"insert into usuarios_permisos (id_usuario,id_permiso) values (@id_usuario,@id_permiso) "; ;
                    cmd.Parameters.Add(new SqlParameter("idUsuario", u.IdUsuario));
                    cmd.Parameters.Add(new SqlParameter("idPermiso", item.Id));

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
