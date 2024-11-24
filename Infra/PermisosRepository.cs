using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Infra
{
    public class PermisosRepository
    {
        //string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private string ConnectionString = @"Data Source=JAIRQUIROGAASSA\SQLEXPRESS;Initial Catalog=VisionTFI;Integrated Security=True;TrustServerCertificate=True";


        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(BEtipoPermiso));
        }

        // metodo para comprobar la conexion
        public bool comprobarConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString);
                conexion.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }


        public BEcomponente GuardarComponente(BEcomponente p, bool esFamilia)
        {
            try
            {
                var cnn = new SqlConnection(ConnectionString);
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                string query = $@"insert into Permiso (nombre,permiso) values (@nombre,@permiso); 
                SELECT idPermiso AS LastID FROM Permiso WHERE idPermiso = @@Identity;       ";


                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("nombre", p.Nombre));

                if (esFamilia)
                    cmd.Parameters.Add(new SqlParameter("permiso", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("permiso", p.Permiso.ToString()));

                var id = cmd.ExecuteScalar();


                p.Id = (int)id;



                return p;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void GuardarFamilia(BEfamilia f)
        {
            try
            {
                var cnn = new SqlConnection(ConnectionString);
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                var query = $@"delete from permiso_permiso where idPermisoPadre=@idPermiso;       ";

                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("idPermiso", f.Id));
                cmd.ExecuteNonQuery();

                foreach (var item in f.Hijos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    query = $@"insert into permiso_permiso (idPermisoPadre,idPermisoHijo) 
                            values (@idPermisoPadre,@idPermisoHijo) ";

                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("idPermisoPadre", f.Id));
                    cmd.Parameters.Add(new SqlParameter("idPermisoHijo", item.Id));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }



        }


        public IList<BEpatente> GetAllPatentes()
        {
            var cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;


            var query = $@"select * from Permiso p where p.permiso is not null;";
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();

            var lista = new List<BEpatente>();

            while (reader.Read())
            {
                var id = reader.GetInt32(reader.GetOrdinal("idPermiso"));
                var nombre = reader.GetString(reader.GetOrdinal("nombre"));
                var permiso = reader.GetString(reader.GetOrdinal("permiso"));

                BEpatente c = new BEpatente();

                c.Id = id;
                c.Nombre = nombre;
                c.Permiso = (BEtipoPermiso)Enum.Parse(typeof(BEtipoPermiso), permiso);
                lista.Add(c);

            }
            reader.Close();
            cnn.Close();
            return lista;
        }

        public IList<BEfamilia> GetAllFamilias()
        {
            var cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var query = $@"select * from Permiso p where p.permiso is  null;";
            cmd.CommandText = query;

            var reader = cmd.ExecuteReader();

            var lista = new List<BEfamilia>();

            while (reader.Read())
            {

                var id = reader.GetInt32(reader.GetOrdinal("idPermiso"));
                var nombre = reader.GetString(reader.GetOrdinal("nombre"));

                BEfamilia f = new BEfamilia();

                f.Id = id;
                f.Nombre = nombre;

                lista.Add(f);

            }
            reader.Close();
            cnn.Close();
            return lista;
        }


        public IList<BEcomponente> GetAll(string familia)
        {
            var where = "is NULL";

            if (!String.IsNullOrEmpty(familia))
            {
                where = familia;

            }

            var cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;


            var sql = $@"with recursivo as (
                        select sp2.idPermisoPadre, sp2.idPermisoHijo  from permiso_permiso SP2
                        where sp2.idPermisoPadre {where} --acá se va variando la familia que busco
                        UNION ALL 
                        select sp.idPermisoPadre, sp.idPermisoHijo from permiso_permiso sp 
                        inner join recursivo r on r.idPermisoHijo= sp.idPermisoPadre
                        )
                        select r.idPermisoPadre,r.idPermisoHijo,p.idPermiso,p.nombre, p.permiso
                        from recursivo r 
                        inner join Permiso p on r.idPermisoHijo = p.idPermiso
						
                        ";

            cmd.CommandText = sql;


            var reader = cmd.ExecuteReader();

            var lista = new List<BEcomponente>();

            while (reader.Read())
            {
                int idPadre = 0;
                if (reader["idPermisoPadre"] != DBNull.Value)
                {
                    idPadre = reader.GetInt32(reader.GetOrdinal("idPermisoPadre"));
                }

                var id = reader.GetInt32(reader.GetOrdinal("idPermiso"));
                var nombre = reader.GetString(reader.GetOrdinal("nombre"));

                var permiso = string.Empty;

                if (reader["permiso"] != DBNull.Value)
                {
                    permiso = reader.GetString(reader.GetOrdinal("permiso"));
                }

                BEcomponente c;

                if (string.IsNullOrEmpty(permiso))
                {
                    c = new BEfamilia();
                }
                else
                {
                    c = new BEpatente();
                }

                c.Id = id;
                c.Nombre = nombre;


                if (!string.IsNullOrEmpty(permiso))
                {
                    c.Permiso = (BEtipoPermiso)Enum.Parse(typeof(BEtipoPermiso), permiso);
                }

                var padre = GetComponent(idPadre, lista);

                if (padre == null)
                {
                    lista.Add(c);
                }
                else
                {
                    padre.AgregarHijo(c);
                }

            }

            reader.Close();
            cnn.Close();

            return lista;
        }

        private BEcomponente GetComponent(int id, IList<BEcomponente> lista)
        {
            BEcomponente componente = lista != null ? lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

            if (componente == null && lista != null)
            {
                foreach (var c in lista)
                {
                    var l = GetComponent(id, c.Hijos);
                    if (l != null && l.Id == id)
                    {
                        return l;
                    }
                    else if (l != null)
                    {
                        return GetComponent(id, l.Hijos);
                    }

                }
            }
            return componente;
        }


        public void FillUserComponents(BEusuario u)
        {
            var cnn = new SqlConnection(ConnectionString);
            cnn.Open();

            var cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = $@"select p.* from usuarios_permisos up inner join Permiso p on up.idPermiso=p.idPermiso where idUsuario=@id;";
            cmd.Parameters.AddWithValue("id", u.IdUsuario);

            var reader = cmd.ExecuteReader();
            u.Permisos.Clear();
            while (reader.Read())
            {
                var idp = reader.GetInt32(reader.GetOrdinal("idPermiso"));
                var nombrep = reader.GetString(reader.GetOrdinal("nombre"));

                var permisop = String.Empty;
                if (reader["permiso"] != DBNull.Value)
                {
                    permisop = reader.GetString(reader.GetOrdinal("permiso"));
                }

                BEcomponente c1;
                if (!String.IsNullOrEmpty(permisop))
                {
                    c1 = new BEpatente();
                    c1.Id = idp;
                    c1.Nombre = nombrep;
                    c1.Permiso = (BEtipoPermiso)Enum.Parse(typeof(BEtipoPermiso), permisop);
                    u.Permisos.Add(c1);
                }
                else
                {
                    c1 = new BEfamilia();
                    c1.Id = idp;
                    c1.Nombre = nombrep;

                    var f = GetAll("=" + idp);
                    u.Permisos.Add(c1);
                }
            }

            reader.Close();
            cnn.Close();

        }

        public void FillFamilyComponents(BEfamilia famila)
        {
            famila.VaciarHijos();
            foreach (var item in GetAll("=" + famila.Id))
            {
                famila.AgregarHijo(item);
            }
        }



        //public DataTable ConsultarPermisoDT(int idPermiso)
        //{
        //    SqlHelper helper = new DAL.SqlHelper();

        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("idPermiso",idPermiso),
        //    };

        //    var prueba = parameters;
        //    DataTable dt = helper.ExecuteReader("permisoConsultarPorID", parameters);
        //    return dt;

        //    //  return helper.ExecuteReader("permisoConsultarPorID",parameters);
        //}
    }
}
