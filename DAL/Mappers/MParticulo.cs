using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Mappers
{
    internal class MParticulo
    {
        #region singleton
        private MParticulo()
        {

        }

        private static MParticulo instancia;
        public static MParticulo GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new MParticulo();
            }
            return instancia;
        } 
        #endregion


        public List<BE.BEarticulo> Map(DataSet dt)
        {
            List<BE.BEarticulo> articulos= new List<BE.BEarticulo> ();

            foreach (DataRow row in dt.Tables[0].Rows)
            {
                articulos.Add(new BE.BEarticulo()
                {
                    Id= int.Parse(row["id_articulo"].ToString()),
                    Cantidad = int.Parse(row["cantidad"].ToString()),
                    Color = row["color"].ToString(),
                    Nombre = row["nombre"].ToString(),
                    Origen= row["origen"].ToString(),
                    Peso = int.Parse(row["peso"].ToString()),
                    Tamanio = int.Parse(row["tamaño"].ToString()),
                });
            }
            return articulos;

        }
    }
}
