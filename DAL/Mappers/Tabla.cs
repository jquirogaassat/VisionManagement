using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Mappers
{
    internal class Tabla
    {
        public BE.BEtabla Map(DataRow row)
        {
            BE.BEtabla tabla = new BE.BEtabla()
            {
                idDVV = (int)row["idTabla"],
                DVV = (int)row["dvv"]
            };
            return tabla;
        }

    }
}
