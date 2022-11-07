using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Mappers
{
    public class MPidioma
    {
        public BE.BEidioma Map(DataRow row )
        {
            BE.BEidioma idioma = new BE.BEidioma()
            {
                IdIdioma = (int)row["idIdioma"],
                Nombre= (string)row["nombreIdioma"],
            
            };
            return idioma;
        }
    }
}
