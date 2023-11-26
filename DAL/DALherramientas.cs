using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALherramientas
    {
        #region Singleton
        //private DALherramientas()
        //{

        //}
        //private static DALherramientas instance;
        //public static DALherramientas getInstance()
        //{
        //    if (instance == null)
        //    {
        //        instance = new DALherramientas();
        //    }
        //    return instance;
        //}
        #endregion

        private SqlHelper sqlHelper = new SqlHelper();

        //consulto el id
        public DataTable consultarHerramientaDT(int idHerramienta)
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idHerramienta",idHerramienta),
            };

            DataTable dt = sqlHelper.ExecuteReader("herramientaConsulta", parametros);
            return dt;
        }

        public DataTable ConsultarHerramientaEstadoDT(int idEstadoHerramienta)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idEstadoHerramienta",idEstadoHerramienta),
            };

            DataTable dt = sqlHelper.ExecuteReader("herramientaEstadoConsultar", parameters);
            return dt;
        }
        // alta de herramienta
        public bool Alta(BEherramientas itemAlta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("nombre", itemAlta.Nombre),
                new SqlParameter("color", itemAlta.Color),
                new SqlParameter("origen", itemAlta.Origen),
                new SqlParameter("codigo", itemAlta.Codigo),
                new SqlParameter("precio",itemAlta.Precio),
                new SqlParameter("estado", itemAlta.Estado),
                new SqlParameter("disponible",itemAlta.Disponible),
                new SqlParameter("ultmiaModificacion",itemAlta.UltimaModificacion),
            };

            int nuevoId = sqlHelper.ExecuteQueryPRUEBA("herramientaInsert", parametros);
            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
            int dvh = dvDal.CalcularDVH(consultarHerramientaDT(nuevoId), 0);
            dvDal.CargarDVH("Herramienta", nuevoId, dvh);
            int dvv = dvDal.CalcularDVV("Herramienta");

            dvDal.CargarDVV(3, dvv);
            return dvDal.CargarDVV(3, dvv);
        }
        // Baja logica de la herramienta
        public bool Baja(BEherramientas itemBaja)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idHerramienta",itemBaja.Id)
            };

            bool resultado = sqlHelper.ExecuteQuery("herramientaBajaLogica", parametros);

            if(resultado)
            {
                return true;
            }

            return (resultado);
        }
        // modificar la herramienta
        public bool Modificar(BEherramientas itemModifica)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idHerramienta",itemModifica.Id),
                new SqlParameter("nombre", itemModifica.Nombre),
                new SqlParameter("color", itemModifica.Color),
                new SqlParameter("origen", itemModifica.Origen),
                new SqlParameter("codigo", itemModifica.Codigo),
                new SqlParameter("precio",itemModifica.Precio),
                new SqlParameter("estado",itemModifica.Estado),
                new SqlParameter("disponible",itemModifica.Disponible),
                new SqlParameter("ultmiaModificacion",itemModifica.UltimaModificacion),
            };

            sqlHelper.ExecuteQuery("herramientaUpdate", parametros);
            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
            int dvh = dvDal.CalcularDVH(consultarHerramientaDT(itemModifica.Id), 0);
            dvDal.CargarDVH("Herramienta", itemModifica.Id, dvh);
            int dvv = dvDal.CalcularDVV("Herramienta");

            dvDal.CargarDVV(3, dvv);
            return dvDal.CargarDVV(3, dvv);
        }

        // traigo todas las herramientas
        public List<BEherramientas> Listar()
        {
            SqlParameter[] parametros = new SqlParameter[] { };
            DataTable dt = sqlHelper.ExecuteReader("herramientaSelect", parametros);
            List<BEherramientas> herramientas = new List<BEherramientas>();
            Mappers.MPherramienta map = new Mappers.MPherramienta();
            foreach (DataRow row in dt.Rows)
            {
                herramientas.Add(map.Map(row));
            }
            return herramientas;
        }


        public static int ModificarC(BEherramientas _herramienta)
        {
            string cmd= "UPDATE Herramienta  SET nombre = '"+_herramienta.Nombre + "', color = '"+_herramienta.Color +"',origen='"+_herramienta.Origen+
                        "',codigo= '"+_herramienta.Codigo +"',precio ='"+_herramienta.Precio + "',estado='"+_herramienta.Estado +
                        "',disponible ='"+_herramienta.Disponible + "', ultimaModificacion='"+_herramienta.UltimaModificacion +
                        "WHERE idHerramienta ='"+ _herramienta.Id + "';";
            SqlHelper sqlHelper = new SqlHelper();
            int val = sqlHelper.ExecuteNonQuery(cmd);
            return val;
        }


        public static BEherramientas Obtener(int codigo)
        {
            string cmd= "SELECT * FROM Herramienta WHERE codigo= '"+ codigo + "';";
            SqlHelper sqlHelper = new SqlHelper();
            DataSet ds = sqlHelper.ExecuteDataSet(cmd);

            if(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count>0) 
            {
                BEherramientas bEherramientas = new BEherramientas();
                ValorizarEntidad(bEherramientas, ds.Tables[0].Rows[0]);
                return bEherramientas;
            }
            else { return null; }
        }


        public static void ValorizarEntidad(BEherramientas bEherramientas, DataRow dr)
        {
            bEherramientas.Id = int.Parse(dr["idHerramienta"].ToString());
            bEherramientas.Nombre = dr["nombre"].ToString();
            bEherramientas.Color = dr["color"].ToString();
            bEherramientas.Origen = dr["origen"].ToString();
            bEherramientas.Codigo = int.Parse(dr["codigo"].ToString());
            bEherramientas.Precio = int.Parse(dr["precio"].ToString());
            bEherramientas.Estado = int.Parse(dr["estado"].ToString());
            bEherramientas.Disponible = dr["disponible"].ToString();
            bEherramientas.UltimaModificacion = (DateTime)dr["ultimaModificacion"];
        }
    
    }
}
