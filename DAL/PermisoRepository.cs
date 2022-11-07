using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;

namespace DAL
{
    public class PermisoRepository
    {
        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(BEtipoPermiso));
        }

        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = ".";
            cs.InitialCatalog = "upf";
            return cs.ConnectionString;
        }

        public BEcomponente GuardarComponente(BEcomponente p, bool esFamilia)
        {

            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                var sql = $@"insert into permiso (nombre,permiso) values (@nombre,@permiso);  SELECT ID AS LastID FROM permiso WHERE ID = @@Identity;       ";
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("nombre", p.Nombre));

                if (esFamilia)
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

        public void GuardarFamilia(BEfamilia c)
        {
            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                var sql = $@"delete from permiso_permiso where id_permiso_padre=@id;       ";

                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("id", c.Id));
                cmd.ExecuteNonQuery();

                foreach (var item in c.Hijos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    sql = $@"insert into permiso_permiso (id_permiso_padre,id_permiso_hijo) 
                            values (@id_permiso_padre,@id_permiso_hijo) ";

                    cmd.CommandText = sql;
                    cmd.Parameters.Add(new SqlParameter("id_permiso_padre", c.Id));
                    cmd.Parameters.Add(new SqlParameter("id_permiso_hijo", item.Id));

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public IList<BEpatente> GetAllPatentes()
        {
            var cnn = new SqlConnection(GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = $@"select * from permiso p where p.permiso is not null;";

            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<BEpatente>();

            while (reader.Read())
            {

                var id = reader.GetInt32(reader.GetOrdinal("id"));
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
            var cnn = new SqlConnection(GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = $@"select * from permiso p where p.permiso is  null;";
            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<BEfamilia>();

            while (reader.Read())
            {

                var id = reader.GetInt32(reader.GetOrdinal("id"));
                var nombre = reader.GetString(reader.GetOrdinal("nombre"));

                BEfamilia c = new BEfamilia();

                c.Id = id;
                c.Nombre = nombre;
                lista.Add(c);
            }
            reader.Close();
            cnn.Close();

            return lista;

        }

        public IList<BEcomponente> GetAll(string familia)
        {
            var where = "is NULL";

            if (!string.IsNullOrEmpty(familia))
            {
                where = familia;
            }

            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = ".";
            cs.InitialCatalog = "upf";
            var cnn = new SqlConnection(cs.ConnectionString);
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = $@"with recursivo as (
                        select sp2.id_permiso_padre, sp2.id_permiso_hijo  from permiso_permiso SP2
                        where sp2.id_permiso_padre {where} --acá se va variando la familia que busco
                        UNION ALL 
                        select sp.id_permiso_padre, sp.id_permiso_hijo from permiso_permiso sp 
                        inner join recursivo r on r.id_permiso_hijo= sp.id_permiso_padre
                        )
                        select r.id_permiso_padre,r.id_permiso_hijo,p.id,p.nombre, p.permiso
                        from recursivo r 
                        inner join permiso p on r.id_permiso_hijo = p.id 
						
                        ";

            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<BEcomponente>();


            while (reader.Read())
            {
                int id_padre = 0;
                if (reader["id_permiso_padre"] != DBNull.Value)
                {
                    id_padre = reader.GetInt32(reader.GetOrdinal("id_permiso_padre"));
                }

                var id = reader.GetInt32(reader.GetOrdinal("id"));
                var nombre = reader.GetString(reader.GetOrdinal("nombre"));

                var permiso = string.Empty;
                if (reader["permiso"] != DBNull.Value)
                    permiso = reader.GetString(reader.GetOrdinal("permiso"));

                BEcomponente c;


                if (string.IsNullOrEmpty(permiso))
                    c = new BEfamilia();
                else
                {
                    c = new BEpatente();
                }

                c.Id = id;
                c.Nombre = nombre;

                if (!string.IsNullOrEmpty(permiso))
                    c.Permiso = (BEtipoPermiso)Enum.Parse(typeof(BEtipoPermiso), permiso);

                var padre = GetComponent(id, lista);

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
            BEcomponente component = lista != null ? lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;


            if (component == null && lista != null)
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
            return component;
        }

        public void FillUserComponents(BEusuario u)
        {
            var cnn = new SqlConnection(GetConnectionString());
            cnn.Open();

            var cmd2 = new SqlCommand();
            cmd2.Connection = cnn;
            cmd2.CommandText = $@"select p.* from usuarios_permisos up inner join permiso p on up.id_permiso=p.id where id_usuario=@id;";
            cmd2.Parameters.AddWithValue("id", u.Id);


            var reader = cmd2.ExecuteReader();
            u.Permisos.Clear();

            while (reader.Read())
            {
                var idp = reader.GetInt32(reader.GetOrdinal("id"));
                var nombrep = reader.GetString(reader.GetOrdinal("nombre"));

                var permisop = string.Empty;
                if (reader["permiso"] != DBNull.Value)
                    permisop = reader.GetString(reader.GetOrdinal("permiso"));

                BEcomponente c1;

                if (!string.IsNullOrEmpty(permisop))
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

                    foreach (var familia in f)
                    {
                        c1.AgregarHijo(familia);
                    }
                    u.Permisos.Add(c1);
                }

            }
            reader.Close();
        }

        public void FillFamilyComponents(BEfamilia familia)
        {
            familia.VaciarHijos();
            foreach (var item in GetAll("=" + familia.Id))
            {
                familia.AgregarHijo(item);
            }
        }
    }
}
