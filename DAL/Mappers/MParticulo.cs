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
        //#region singleton
        //private MParticulo()
        //{

        //}

        //private static MParticulo instancia;
        //public static MParticulo GetInstancia()
        //{
        //    if (instancia == null)
        //    {
        //        instancia = new MParticulo();
        //    }
        //    return instancia;
        //} 
        //#endregion


        public BE.BEarticulo Map (DataRow row)
        {

            BE.BEarticulo articuloBE = new BE.BEarticulo()
            {
                Id = int.Parse(row["idArticulo"].ToString()),
                Nombre = row["nombre"].ToString(),
                Color = row["color"].ToString(),
                Origen = row["origen"].ToString(),
                Cantidad = int.Parse(row["cantidad"].ToString()),
                precio = row["precio"].ToString()
            };

            return articuloBE;
           

        }
    }
}
