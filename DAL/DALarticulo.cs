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


        
        SqlHelper sqlHelper = new SqlHelper();

        public bool Alta(BEarticulo itemAlta)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("nombre", itemAlta.Nombre),
                new SqlParameter("color", itemAlta.Color),
                new SqlParameter("origen", itemAlta.Origen),
                new SqlParameter("cantidad", itemAlta.Cantidad),                
                new SqlParameter("precio",itemAlta.precio)
            };

            int nuevoId = sqlHelper.ExecuteQueryPRUEBA("articuloInsert", parameters);
            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
            int dvh = dvDal.CalcularDVH(consultarArticuloDT(nuevoId), 0);
            dvDal.CargarDVHa("Articulo1", nuevoId, dvh);
            int dvv = dvDal.CalcularDVVa("Articulo1");
            //DAL.DALarticulo articuloDal= new DALarticulo();

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
            SqlParameter[] parametros = new SqlParameter[] { };
            DataTable dt = sqlHelper.ExecuteReader("articuloSelect", parametros);
            List<BEarticulo> articulos = new List<BEarticulo>();
            Mappers.MParticulo map = new Mappers.MParticulo();
            foreach(DataRow row in dt.Rows)
            {
                articulos.Add(map.Map(row));
            }
            return articulos;
        }


        public DataTable consultarArticuloDT(int idArticulo)
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idArticulo",idArticulo),
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
