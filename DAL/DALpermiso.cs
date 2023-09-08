using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALpermiso : BE.ICRUd<BE.BEpermiso>
    {

        DAL.SqlHelper sqlHelper = new DAL.SqlHelper();
        DAL.Mappers.MPpermiso mapp = new DAL.Mappers.MPpermiso();
        DAL.DALdigitoverificador DALdigitoverificador = new DAL.DALdigitoverificador();

        public bool Alta(BEpermiso itemAlta)
        {
            DAL.DALdigitoverificador dALdigitoverificador = new DALdigitoverificador();
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("nombrePermiso",itemAlta.nombrePermiso),
                new SqlParameter("tipo",itemAlta.tipoFamilia),
            };

            return sqlHelper.ExecuteQuery("permisoAlta", parameters);
            //throw new NotImplementedException();
        }

        public bool Baja(BEpermiso itemBaja)
        {

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("diPermiso",itemBaja.idPermiso),
            };

            return sqlHelper.ExecuteQuery("permisoBaja", parameters);
            //
            //throw new NotImplementedException();
        }


        //public List<BE.BEpermiso> ConsultarFamilias()
        //{
        //    List<BE.BEpermiso> permisos = new List<BEpermiso>();
        //    SqlParameter[] parameters = new SqlParameter[] { };

        //    DataTable data = sqlHelper.ExecuteReader("familiaConsulta", parameters);
        //    DAL.Mappers.MPpermiso mapp = new DAL.Mappers.MPpermiso();

        //    foreach(DataRow row in data.Rows)
        //    {
        //        permisos.Add(mapp.Map(row));
        //    }
        //    return permisos;
        //}

        public IList<BEpermiso> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEpermiso itemModifica)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPermiso",itemModifica.idPermiso),
                new SqlParameter("nombrePermiso",itemModifica.nombrePermiso),
            };

            SqlHelper sqlHelper = new SqlHelper();
            bool resultado = sqlHelper.ExecuteQuery("permisoUpdate", parameters);
            return resultado;
        }


        public bool Existe (BE.BEpermiso p, int id)
        {
            bool a = false;
            return a;
        }

        //public List<BE.BEpermiso> ObtenerHijos(BE.BEpermiso permiso)
        //{
        //    List<BE.BEpermiso> hijos = new List<BEpermiso>();// aca agrego todos los hijos
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter("idPermisoPadre",permiso.idPermiso),
        //    };

        //    DataTable data = sqlHelper.ExecuteReader("PermisoConsultaHijo", parameters);
        //    DAL.Mappers.MPpermiso mapp= new DAL.Mappers.MPpermiso();
        //    foreach(DataRow row in data.Rows)
        //    {
        //        hijos.Add(mapp.Map(row));
        //    }
        //    return hijos;
        //}


        //public List<BE.BEpermiso> Consulta( )
        //{
        //    List<BE.BEpermiso> permisos = new List<BEpermiso>();
        //    SqlParameter[] parameters = new SqlParameter[] { };

        //    DataTable data = sqlHelper.ExecuteReader("PermisosSelect", parameters);
        //    DAL.Mappers.MPpermiso mapp = new Mappers.MPpermiso();
        //    foreach(DataRow row in data.Rows)
        //    {
        //        permisos.Add(mapp.Map(row));
        //    }

        //    return permisos;             
        //}

        //public BE.BEpermiso Consultar(string nombrePermiso)
        //{
        //    //SqlParameter[] parameters = new SqlParameter[]
        //    //{
        //    //    new SqlParameter("nombrePermiso",nombrePermiso),
        //    //};

        //    //SqlHelper sqlHelper = new SqlHelper();
        //    //DataTable data = sqlHelper.ExecuteReader("PermisoConsultar", parameters);

        //    //if (data.Rows.Count>0)
        //    //{
        //    //    return mapp.Map(data.Rows[0]);  
        //    //}
        //    //else
        //    //{
        //    //    return null;
        //    //}
        //}


        //public BE.BEpermiso Consultar(int idPermiso)
        //{
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //        new SqlParameter( "idPermiso",idPermiso),
        //    };

        //    SqlHelper sqlHelper = new SqlHelper();
        //    DataTable data = sqlHelper.ExecuteReader("permisoConsultarPorID", parameters);
            
        //    if(data.Rows.Count>0)
        //    {
        //        return mapp.Map(data.Rows[0]);
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //}


        public bool Existe (BE.BEpermiso a, BE.BEpermiso b)
        {
            List<BE.BEpermiso> permisos = new List<BE.BEpermiso>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPadre",b.idPermiso),
                new SqlParameter("idHijo",a.idPermiso),
            };

            SqlHelper sqlHelper =new SqlHelper();
            DataTable data = sqlHelper.ExecuteReader("permisoExiste", parameters);

            if(data.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Existe(string permiso)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("nombrePermiso",permiso),
            };
            SqlHelper sqlHelper = new SqlHelper();
            DataTable data = sqlHelper.ExecuteReader("permisoCreado", parameters);
            if( data.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable ConsultarPermisoPermisoDT (int idPermisoPermiso)
        {
            SqlHelper sqlHelper= new SqlHelper();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPermisoPermiso",idPermisoPermiso),
            };

            DataTable data = sqlHelper.ExecuteReader("permisoPermisoConsultarPorID", parameters);
            return data;


        }


        public void Asignar( BE.BEpermiso a, BE.BEpermiso b)
        {
            List<BE.BEpermiso> permisos = new List<BEpermiso>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPadre", b.idPermiso),
                new SqlParameter("idHijo",a.idPermiso),
            };

            SqlHelper sqlHelper = new SqlHelper();

            int nuevoID = sqlHelper.ExecuteQueryPRUEBA("permisoAsignar", parameters);

            DAL.DALdigitoverificador dvdal = new DAL.DALdigitoverificador();

            int dvh = dvdal.CalcularDVH(ConsultarPermisoPermisoDT(nuevoID), 0);
            dvdal.CargarDVH("PERMISO-PERMISO", nuevoID, dvh);
            int dvv = dvdal.CalcularDVV("PERMISO-PERMISO");
            dvdal.CargarDVV(4, dvv);
        }



        public bool QuitarPermiso (BE.BEpermiso pHijo, BE.BEpermiso pPadre)
        {
            List<BE.BEpermiso> permisos = new List<BEpermiso>();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPadre",pPadre.idPermiso),
                new SqlParameter("idHijo", pHijo.idPermiso),
            };
            return sqlHelper.ExecuteQuery("permisoQuitar", parameters);
          
        }


        public bool QuitarAsignaciones(BE.BEpermiso b)
        {
            DAL.DALdigitoverificador dvdal = new DALdigitoverificador();
            SqlHelper sqlHelper = new SqlHelper();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPeermiso",b.idPermiso),
            };

            return sqlHelper.ExecuteQuery("PermisoQuitarAsignaciones", parameters);
        }


        //public List<BE.BEpermiso> ObtenerPermisosRecursivos(string permiso)
        //{
        //    List<BE.BEpermiso> permisos = new List<BEpermiso>();

        //    var where = "is null";
        //    if(!string.IsNullOrEmpty(permiso))
        //    {
        //        where = permiso;
        //    }

        //    var sql = $@"with  recursivo as(
                                   
        //                    select sp2.idPermisoPadre, sp2.idPermisoHijo from permiso_permiso SP2
        //                    where sp2.idPermisoPadre{where}
        //                    UNION ALL
        //                    select sp.idPermisoPadre, sp.idPermisoHijo from permiso_permiso sp
        //                    inner join recursivo r on r.idPermisoHijo = sp.idPermisoPadre
        //                    )
        //                    select r.idPermisoHijo, p.nombrePermiso, p.esFamilia, p.tipoFamilia
        //                    from recursivo r
        //                    inner join permiso p on r.idPermisoHijo = p.idPermiso";

        //    DataTable data = sqlHelper.ExecuteReader(sql);

        //    DAL.Mappers.MPpermiso mPpermiso = new Mappers.MPpermiso();
        //    foreach(DataRow row in data.Rows)
        //    {
        //        BE.BEpermiso hijo = mapp.Map(row);
        //        permisos.Add(hijo);
        //    }
        //    return permisos;

        //}


        public bool AsignacionDirecta(BE.BEpermiso permisoPadre, BE.BEpermiso permisoHijo)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idPermisoPadre",permisoPadre.idPermiso),
                new SqlParameter("idPermisoHijo",permisoHijo.idPermiso),
            };

            DataTable data = sqlHelper.ExecuteReader("permisoPermisoExisteAsignacion", parameters);
            if(data.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        List<BEpermiso> ICRUd<BEpermiso>.Listar()
        {
            throw new NotImplementedException();
        }

        public IList<BEpermiso> Lista()
        {
            throw new NotImplementedException();
        }
    }
}
