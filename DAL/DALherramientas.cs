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
        private DALherramientas()
        {

        }
        private static DALherramientas instance;
        public static DALherramientas getInstance()
        {
            if (instance == null)
            {
                instance = new DALherramientas();
            }
            return instance;
        }
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
        // alta de herramienta
        public bool Alta(BEherramientas itemAlta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("nombre", itemAlta.Nombre),
                new SqlParameter("color", itemAlta.Color),
                new SqlParameter("origen", itemAlta.Origen),
                new SqlParameter("cantidad", itemAlta.Cantidad),
                new SqlParameter("precio",itemAlta.precio)
            };

            int nuevoId = sqlHelper.ExecuteQueryPRUEBA("herramientaInsert", parametros);
            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
            int dvh = dvDal.CalcularDVH(consultarHerramientaDT(nuevoId), 0);
            dvDal.CargarDVH("", nuevoId, dvh);
            int dvv = dvDal.CalcularDVV("");

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
                new SqlParameter("cantidad", itemModifica.Cantidad),
                new SqlParameter("precio",itemModifica.precio)
            };

            sqlHelper.ExecuteQuery("herramientaUpdate", parametros);
            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
            int dvh = dvDal.CalcularDVH(consultarHerramientaDT(itemModifica.Id), 0);
            dvDal.CargarDVH("", itemModifica.Id, dvh);
            int dvv = dvDal.CalcularDVV("");

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
    
    }
}
