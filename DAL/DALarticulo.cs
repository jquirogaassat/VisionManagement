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
    public class DALarticulo : BE.ICRUd<BE.BEarticulo>
    {
        #region Singleton

        private DALarticulo()
        {

        }

        private static DALarticulo instancia;

        public static DALarticulo GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DALarticulo();
            }
            return instancia;
        }


        #endregion


        DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
        SqlHelper sqlHelper = new SqlHelper();

        public bool Alta(BEarticulo itemAlta)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("cantidad", itemAlta.Cantidad),
                new SqlParameter("color", itemAlta.Color),
                new SqlParameter("nombre", itemAlta.Nombre),
                new SqlParameter("origen", itemAlta.Origen),
                new SqlParameter("peso", itemAlta.Peso),
                new SqlParameter("tamaño",itemAlta.Tamanio)
            };

            int nuevoId = sqlHelper.ExecuteQueryPRUEBA("articuloInsert", parameters);

            int dvh = dvDal.CalcularDVH(consultarArticuloDT(nuevoId), 0);
            dvDal.CargarDVH("ARTICULO", nuevoId, dvh);
            int dvv = dvDal.CalcularDVV("ARTICULO");
            DAL.DALarticulo articuloDal= new DALarticulo();

            dvDal.CargarDVV(0, dvv);

            return dvDal.CargarDVV(0, dvv);
        }

        public bool Baja(BEarticulo itemBaja)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEarticulo itemModifica)
        {
            throw new NotImplementedException();
        }

        public List<BEarticulo> Listar()
        {
            throw new NotImplementedException();
        }


        public DataTable consultarArticuloDT(int idArticulo)
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("id",idArticulo),
            };

            DataTable dt = sqlHelper.ExecuteReader("articuloConsulta", parametros);
            return dt;
        }

        public IList<BEarticulo> Lista()
        {
            throw new NotImplementedException();
        }
    }
}
