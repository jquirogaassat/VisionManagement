using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALidioma
    {
        SqlHelper sqlHelper = new SqlHelper();


        public List<BE.BEidioma> Consultar()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            };
            DataTable data = sqlHelper.ExecuteReader("idiomaSelect", parameters);
            List<BE.BEidioma> idiomas = new List<BE.BEidioma>();
            Mappers.MPidioma mapp = new Mappers.MPidioma();

            foreach(DataRow row in data.Rows)
            {
                idiomas.Add(mapp.Map(row));
            }
            return idiomas;
        }


        public DataTable ConsultarTraducciones()
        {
            SqlParameter[] parameters = new SqlParameter[]
            {};
            return sqlHelper.ExecuteReader("traduccionesSelect", parameters);
        }



        public List<BE.BEtraduccion> Traducciones()
        {
            DataTable data = ConsultarTraducciones();
            List<BE.BEtraduccion> traduccion = new List<BE.BEtraduccion>();

            Mappers.MPtraduccion mapp = new Mappers.MPtraduccion();

            foreach(DataRow row in data.Rows)
            {
                traduccion.Add(mapp.Map(row));
            }
            return traduccion;
        }


        public BE.BEidioma ConsultarIdioma(int id)
        {
            DAL.Mappers.MPidioma mapp = new Mappers.MPidioma();
            BE.BEidioma idioma = new BE.BEidioma();

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idIdioma",id)
            };

            DataTable data = new DataTable();
            data = sqlHelper.ExecuteReader("idiomaConsultar", parameters);
            DataRow row = data.Rows[0];
            return mapp.Map(row);
        }
    }
}
