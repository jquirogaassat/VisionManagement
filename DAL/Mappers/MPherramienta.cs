using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class MPherramienta
    {
        public BE.BEherramientas Map(DataRow row)
        {

            BE.BEherramientas herrameintaBE= new BE.BEherramientas()
            {
                Id = int.Parse(row["idHerramienta"].ToString()),
                Nombre = row["nombre"].ToString(),
                Color = row["color"].ToString(),
                Origen = row["origen"].ToString(),
                Cantidad = int.Parse(row["cantidad"].ToString()),
                precio = row["precio"].ToString()
            };

            return herrameintaBE;


        }
    }
}
