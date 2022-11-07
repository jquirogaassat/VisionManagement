using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Mappers
{
    public class MPtraduccion
    {
        public BE.BEtraduccion Map(DataRow row)
        {
            BE.BEtraduccion b = new BE.BEtraduccion()
            {
                IdTraduccion = (int)row["idTraduccion"],
                IdCadena = (int)row["idCadena"],
                IdIdioma = (int)row["idIdioma"],
                Cadena = (string)row["cadena"],

            };
            return b;
        }
    }
}
