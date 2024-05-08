using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALusuario :BE.ICRUd<BE.BEusuario>
    {
        DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
        SqlHelper sqlHelper = new SqlHelper();
        

        public bool Alta(BEusuario itemAlta)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                //new SqlParameter("idIdioma",itemAlta.Idioma.IdIdioma),
                new SqlParameter("usuario",itemAlta.usuario),
                new SqlParameter("userPass",itemAlta.UserPass),
                new SqlParameter("nombre",itemAlta.Nombre),
                new SqlParameter("apellido",itemAlta.Apellido),
                new SqlParameter("fechaNacimiento",itemAlta.FechaNacimiento),
               // new SqlParameter("tipoDocumento",itemAlta.TipoDocumento),
                new SqlParameter("numeroDocumento",itemAlta.NumeroDocumento),
                new SqlParameter("telefono",itemAlta.Telefono),
                new SqlParameter("direccion",itemAlta.Direccion),
                new SqlParameter("mail",itemAlta.Mail),
            };

            int nuevoId = sqlHelper.ExecuteQueryPRUEBA("usuarioInsert", parameters);
            DAL.DALdigitoverificador dvDal= new DALdigitoverificador();

            int dvh = dvDal.CalcularDVH(ConsultarUsuarioDT(nuevoId), 0);
            dvDal.CargarDVH("USUARIO", nuevoId, dvh);
            int dvv = dvDal.CalcularDVV("USUARIO");


            itemAlta.IdUsuario = nuevoId;
            return dvDal.CargarDVV(2, dvv);
        }

        public DataTable ConsultarUsuarioDT(int idUsuario)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idUsuario",idUsuario),
            };
            return sqlHelper.ExecuteReader("usuarioConsultarPorID", parameters);
        }


        public bool quitarAsignaciones(BE.BEusuario usuario)
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idUsuario",usuario.IdUsuario),
            };
            return sqlHelper.ExecuteQuery("usuarioQuitarAsignaciones", parameters);
        }

        public bool Baja(BE.BEusuario itemBaja)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idUsuario",itemBaja.IdUsuario),
            };

            bool resultado = sqlHelper.ExecuteQuery("usuarioBajaLogica", parameters);
           // bool resultado1= sqlHelper.
            if (resultado)
            {
                int dvh = dvDal.CalcularDVH(ConsultarUsuarioDT(itemBaja.IdUsuario));
                dvDal.CargarDVH("USUARIO", itemBaja.IdUsuario, dvh);

                int dvv = dvDal.CalcularDVV("USUARIO");
                dvDal.CargarDVV(2, dvv);
            }
            return resultado;
        }

        public bool DesbloquearUsuario(BE.BEusuario itemDesbloquear)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idUsuario",itemDesbloquear.IdUsuario),
            };
            
            bool resultado = sqlHelper.ExecuteQuery("usuarioDesbloquear",parameters);
            if(resultado)
            {
                int dvh = dvDal.CalcularDVH(ConsultarUsuarioDT(itemDesbloquear.IdUsuario));
                dvDal.CargarDVH("USUARIO", itemDesbloquear.IdUsuario, dvh);
            }
            

            return resultado;
        }

        public List<BE.BEusuario>Consulta()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {

            };
            DataTable data= sqlHelper.ExecuteReader("usuarioSelect", parameters);
            List<BE.BEusuario> usuarios = new List<BEusuario>();
            Mappers.MPusuario mapp = new Mappers.MPusuario();
            foreach(DataRow row in data.Rows)
            {
                usuarios.Add(mapp.Map(row));
            }
            return usuarios;
        }

        public IList<BEusuario> Listar()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {};
            DataTable dt = sqlHelper.ExecuteReader("usuarioSelect", parameters);
            List<BE.BEusuario> usuario = new List<BEusuario>();
            Mappers.MPusuario mapp = new Mappers.MPusuario();
            foreach(DataRow row in dt.Rows)
            {
                usuario.Add(mapp.Map(row));
            }
            return usuario;

        }

        public bool Modificar(BEusuario itemModifica)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idUsuario",itemModifica.IdUsuario),
                new SqlParameter("usuario",itemModifica.usuario),
                new SqlParameter("userPass",itemModifica.UserPass),
              //  new SqlParameter("isBlocked",itemModifica.IsBlocked),
                new SqlParameter("nombre",itemModifica.Nombre),
                new SqlParameter("apellido",itemModifica.Apellido),
                new SqlParameter("fechaNacimiento",itemModifica.FechaNacimiento),              
                new SqlParameter("numeroDocumento",itemModifica.NumeroDocumento),
                new SqlParameter("telefono",itemModifica.Telefono),
                new SqlParameter("direccion",itemModifica.Direccion),
                new SqlParameter("mail",itemModifica.Mail),               
              //  new SqlParameter("intentosFallidos", itemModifica.intentosFallidos),
            };

            sqlHelper.ExecuteQuery("usuarioUpdate", parameters);
            int dvh = dvDal.CalcularDVH(ConsultarUsuarioDT(itemModifica.IdUsuario), 0);
            dvDal.CargarDVH("USUARIO", itemModifica.IdUsuario, dvh);
            int dvv = dvDal.CalcularDVV("USUARIO");
            return dvDal.CargarDVV(2, dvv);
        }


        public BE.BEusuario ConsultarUsuario(BE.BEusuario usuario)
        {
            DataTable dt = new DataTable();
            if (usuario.IdUsuario == 0)
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("usuario",usuario.usuario),
                };
                dt = sqlHelper.ExecuteReader("usuarioConsulta", parameters);
            }
            else
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("idUsuario",usuario.IdUsuario),
                };
                dt = sqlHelper.ExecuteReader("usuarioConsultarPorId", parameters);
            }
            if (dt.Rows.Count > 0)
            {
                DAL.Mappers.MPusuario mapp= new DAL.Mappers.MPusuario();
                return mapp.Map(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        //public List<BE.BEpermiso> ObtenerPermisoRecursivo(string usuario)
        //{
        //    List<BE.BEpermiso> permisos = new List<BE.BEpermiso>();

        //    var where = "is null";
        //    if (!String.IsNullOrEmpty(usuario))
        //    {
        //        where = usuario;

        //    }

        //    var sql = $@"with recursivo as (
                   
        //                select up2.idPermiso from usuario_permiso UP2
        //                where up2.idUsuario {where}
        //                UNION ALL
        //                select pp.idPermisoHijo from permiso_permiso pp
        //                inner join recursivo r on r.idPermiso = pp.idPermisoPadre
        //                )
        //                select distinct r.idPermiso,p.nombrePermiso,p.esFamilia,p.tipoFamilia
        //                from recursivo r
        //                inner join permiso p on r.idPermiso = p.idPermiso";

        //    DataTable dt = sqlHelper.ExecuteReader(sql);

        //    DAL.Mappers.MPpermiso mapp = new DAL.Mappers.MPpermiso();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        BE.BEpermiso hijo = mapp.Map(row);
        //        permisos.Add(hijo);
        //    }

        //    return permisos;
        //}


        //public List<BE.BEpermiso>ObtenerPermisos(BE.BEusuario bEusuario)
        //{
        //    List<BE.BEpermiso> permisos = new List<BE.BEpermiso>();
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("idUsuario",bEusuario.IdUsuario),
        //    };

        //    DataTable data = sqlHelper.ExecuteReader("UsuarioConsultaHijos", parameters);
        //    DAL.Mappers.MPpermiso mapp = new DAL.Mappers.MPpermiso();
        //    foreach(DataRow row in data.Rows)
        //    {
        //        permisos.Add(mapp.Map(row));
        //    }
        //    return permisos; 
        //}


        public bool Existe (BE.BEpermiso a, BE.BEpermiso b )
        {
            List<BE.BEpermiso> permisos = new List<BEpermiso>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPadre",b.idPermiso),
                new SqlParameter("idHijo",a.idPermiso),
            };

            SqlHelper sqlHelper = new SqlHelper();
            DataTable dt = sqlHelper.ExecuteReader("permisoExiste", parameters);

            if(dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<BE.BEusuario> FamiliaMiembros (BE.BEpermiso permiso)
        {
            List<BE.BEusuario> usuarios = new List<BEusuario>();
            List<BE.BEpermiso> permisos = new List<BEpermiso>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPermiso",permiso.idPermiso),
            };

            SqlHelper sqlHelper = new SqlHelper();
            DataTable dt = sqlHelper.ExecuteReader("familiaMiembros", parameters);


            DAL.Mappers.MPusuario mapp = new DAL.Mappers.MPusuario();

            foreach(DataRow row in dt.Rows)
            {
                BE.BEusuario u = mapp.Map(row);
                usuarios.Add(u);
            }
            return usuarios;
        }




        public void Asignar (BE.BEusuario usuario, BE.BEpermiso permiso)
        {
            List<BE.BEpermiso> permisos = new List<BEpermiso>();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idUsuario",usuario.IdUsuario),
                new SqlParameter("idPermiso",permiso.idPermiso),
            };

            SqlHelper sqlHelper = new SqlHelper();

            int idNuevo = sqlHelper.ExecuteQueryPRUEBA("usuarioAsignarPermiso", parameters);

            DAL.DALdigitoverificador dvDal = new DAL.DALdigitoverificador();

            int dvh = dvDal.CalcularDVH(consultarUsuarioPermisoDT(idNuevo), 0);
            dvDal.CargarDVH("USUARIO_PERMISO", idNuevo, dvh);
            int dvv = dvDal.CalcularDVV("USUARIO_PERMISO");
            dvDal.CargarDVV(3, dvv);
        }


        public DataTable consultarUsuarioPermisoDT(int idUsuarioPermiso)
        {
            SqlHelper sqlHelper= new SqlHelper();
            SqlParameter[] parameters = new SqlParameter[]

            {
                new SqlParameter("idUsuarioPermiso",idUsuarioPermiso),
            };

            DataTable dt= sqlHelper.ExecuteReader("usuarioPermisoConsultaPorID",parameters);
            return dt;
        }


        public bool QuitarPermisos(BE.BEusuario usuario, BE.BEpermiso permiso)
        {

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("idUsuario",usuario.IdUsuario),
                new SqlParameter("idPermiso",permiso.idPermiso),
            };

            sqlHelper.ExecuteQuery("usuarioQuitarPermiso", parameter);

            DAL.DALdigitoverificador dvdal = new DALdigitoverificador();
            int dvv = dvdal.CalcularDVV("USUARIO_PERMISO");
            return dvdal.CargarDVV(3, dvv);
        }

        public bool AsignacionDirecta(BE.BEusuario usuario, BE.BEpermiso permisoH)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idUsuario",usuario.IdUsuario),
                new SqlParameter("idPermiso",permisoH.idPermiso),
            };

            DataTable dt = sqlHelper.ExecuteReader("usuarioPermisoExisteAsignacion", parameters);

            if(dt.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }

        List<BEusuario> ICRUd<BEusuario>.Listar()
        {
            throw new NotImplementedException();
        }

        public IList<BEusuario> Lista()
        {
            throw new NotImplementedException();
        }

        public static int ObtenerId(string nombreUsuario)
        {
            SqlHelper helper = new SqlHelper();
            string mCommandText = "SELECT * FROM USUARIO WHERE nombre = '" + nombreUsuario + "'";
            return int.Parse(helper.ExecuteDataSet(mCommandText).Tables[0].Rows[0]["idUsuario"].ToString());
        }
    }
}
