using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Daos
{
    internal class DAOarticulo : BE.ICRUd<BE.BEarticulo>
    {

        private string connstring= @"Data Source=.\sqlexpress;Initial Catalog=VisionManagement;Integrated Security=True";
        private SqlConnection cnn;
        private string spInsert = "ArticuloInsert";
        private string spUpdate = "ArticloUpdate";
        private string spDelete = "ArticuloDelete";
        private string spSelectAll = "ArticuloSelectAll";

        private DataSet dt;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        private SqlHelper _sqlHelper;

        #region singleton
        private DAOarticulo()
        {

        }
        private static DAOarticulo instancia;

        public static DAOarticulo GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new DAOarticulo();
            }
            return instancia;
        } 
        #endregion
        public bool Alta(BEarticulo itemAlta)
        {
            _sqlHelper.ExecuteQuery("");
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("cantidad", itemAlta.Cantidad));
            parametros.Add(new SqlParameter("color", itemAlta.Color));
            parametros.Add(new SqlParameter("nombre", itemAlta.Nombre));
            parametros.Add(new SqlParameter("origen", itemAlta.Origen));
            parametros.Add(new SqlParameter("peso", itemAlta.Peso));
            parametros.Add(new SqlParameter("tamaño", itemAlta.Tamanio));

            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                    spInsert,
                    parametros
                );
            return returnValue;
                
        }

        public bool Baja(BEarticulo itemBaja)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_articulo", itemBaja.Id));

            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                 spDelete,
                 parametros
                );
            return returnValue;
        }

        public IList<BEarticulo> Listar()
        {
            dt = new DataSet("Articulos");
            da = new SqlDataAdapter();

            cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = spSelectAll;

            da.SelectCommand = cmd;

            da.Fill(dt);

            return Mappers.MParticulo.GetInstancia().Map(dt);

        }

        public bool Modificar(BEarticulo itemModifica)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("id_articulo",itemModifica.Id));
            parametros.Add(new SqlParameter("cantidad", itemModifica.Cantidad));
            parametros.Add(new SqlParameter("color", itemModifica.Color));
            parametros.Add(new SqlParameter("nombre", itemModifica.Nombre));
            parametros.Add(new SqlParameter("origen", itemModifica.Origen));
            parametros.Add(new SqlParameter("peso", itemModifica.Peso));
            parametros.Add(new SqlParameter("tamaño", itemModifica.Tamanio));


            bool returnValue = SqlHelper.getInstancia(connstring).ExecuteQuery
                (
                    spUpdate,
                    parametros
                );
            return returnValue;
        }
    }
}
