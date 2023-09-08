﻿using System;
using BE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class PermisosRepository
    {
        DALdigitoverificador dvdal = new DALdigitoverificador();
        string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        SqlHelper sqlHelper= new SqlHelper();
        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(BEtipoPermiso));
        }


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
        //private string GetConnectionString()
        //{
        //    var cs= new SqlConnectionStringBuilder();
        //    cs.IntegratedSecurity = true;
        //    cs.DataSource = ".";
        //    cs.InitialCatalog = "VisionManagement";
        //    return cs.ConnectionString;
        //}

        public BEcomponente GuardarComponente(BEcomponente p, bool esFamilia)
        {
            try
            {
                var cnn = new SqlConnection(ConnectionString);
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                string query = $@"insert into Permiso1 (nombre,permiso) values (@nombre,@permiso); 
                SELECT id_permiso AS LastID FROM Permiso1 WHERE id_permiso = @@Identity;       ";


                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("nombre", p.Nombre));

                if (esFamilia)
                    cmd.Parameters.Add(new SqlParameter("permiso", DBNull.Value));
                else
                    cmd.Parameters.Add(new SqlParameter("permiso", p.Permiso.ToString()));

                 var id = cmd.ExecuteScalar();

               // int id = sqlHelper.ExecuteQueryPRUEBA(query);
                p.Id = (int)id;
               // int dvhId = p.Id;

                
               // int dvh = dvdal.CalcularDVH(ConsultarPermisoDT(p.Id), 0);
              

                return p;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public void GuardarFamilia (BEfamilia f)
        {
            try
            {
                var cnn = new SqlConnection(ConnectionString);
                cnn.Open();
                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                var query = $@"delete from permiso_permiso where id_permiso_padre=@id;       ";

                cmd.CommandText= query;
                cmd.Parameters.Add(new SqlParameter("id", f.Id));
                cmd.ExecuteNonQuery();

                foreach(var item in f.Hijos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    query= $@"insert into permiso_permiso (id_permiso_padre,id_permiso_hijo) 
                            values (@id_permiso_padre,@id_permiso_hijo) ";

                    cmd.CommandText = query;
                    cmd.Parameters.Add(new SqlParameter("id_permiso_padre",f.Id));
                    cmd.Parameters.Add(new SqlParameter("id_permiso_hijo",item.Id));

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


            var query= $@"select * from Permiso1 p where p.permiso is not null;";
            cmd.CommandText = query;
            var reader = cmd.ExecuteReader();

            var lista= new List<BEpatente>();

            while(reader.Read())
            {
                var id = reader.GetInt32(reader.GetOrdinal("id_permiso"));
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

            var query = $@"select * from Permiso1 p where p.permiso is  null;";
            cmd.CommandText = query;

            var reader = cmd.ExecuteReader();

            var lista = new List<BEfamilia>();

            while (reader.Read())
            {

                var id = reader.GetInt32(reader.GetOrdinal("id"));
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

            if(!String.IsNullOrEmpty(familia))
            {
                where = familia;

            }

            var cnn= new SqlConnection(ConnectionString);
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;


            var sql= $@"with recursivo as (
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

            while( reader.Read())
            {
                int idPadre = 0;
                if (reader["id_permiso_padre"] != DBNull.Value)
                {
                    idPadre = reader.GetInt32(reader.GetOrdinal("id_permiso_padre"));
                }

                var id = reader.GetInt32(reader.GetOrdinal("id"));
                var nombre = reader.GetString(reader.GetOrdinal("nombre"));

                var permiso = string.Empty;

                if (reader["permiso"]!= DBNull.Value)
                {
                    permiso = reader.GetString(reader.GetOrdinal("permiso"));
                }

                BEcomponente c;

                if(string.IsNullOrEmpty(permiso))
                {
                    c = new BEfamilia();
                }
                else
                {
                    c = new BEpatente();
                }

                c.Id = id;
                c.Nombre = nombre;


                if(!string.IsNullOrEmpty(permiso))
                {
                    c.Permiso = (BEtipoPermiso)Enum.Parse(typeof(BEtipoPermiso), permiso);
                }

                var padre = GetComponent(idPadre, lista);

                if(padre== null)
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

        private BEcomponente GetComponent( int id, IList<BEcomponente>lista)
        {
            BEcomponente componente = lista != null ? lista.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;

            if (componente== null && lista!= null)
            {
                foreach(var c in lista)
                {
                    var l = GetComponent(id, c.Hijos);
                    if(l!=null && l.Id==id)
                    {
                        return l;
                    }
                    else if(l!=null)
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
            cmd.CommandText= $@"select p.* from usuarios_permisos up inner join permiso p on up.id_permiso=p.id where id_usuario=@id;";
            cmd.Parameters.AddWithValue("id", u.IdUsuario);

            var reader= cmd.ExecuteReader();
            u.Permisos.Clear();
            while(reader.Read())
            {
                var idp = reader.GetInt32(reader.GetOrdinal("id"));
                var nombrep = reader.GetString(reader.GetOrdinal("nombre"));

                var permisop = String.Empty;
                if (reader["permiso"]!= DBNull.Value)
                {
                    permisop = reader.GetString(reader.GetOrdinal("permiso"));
                }

                BEcomponente c1;
                if(!String.IsNullOrEmpty(permisop))
                {
                    c1 = new BEpatente();
                    c1.Id = idp;
                    c1.Nombre = nombrep;
                    c1.Permiso= (BEtipoPermiso)Enum.Parse(typeof(BEtipoPermiso),permisop);
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

        public void FillFamilyComponents( BEfamilia famila)
        {
            famila.VaciarHijos();
            foreach( var item in GetAll("=" + famila))
            {
                famila.AgregarHijo(item);
            }
        }



        public DataTable ConsultarPermisoDT(int idPermiso)
        {
            SqlHelper helper = new SqlHelper();
           
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("id_permiso",idPermiso),
            };

            var prueba = parameters;
            DataTable dt = helper.ExecuteReader("permisoConsultarPorID", parameters);
            return dt;

            //  return helper.ExecuteReader("permisoConsultarPorID",parameters);
        }


    }
}