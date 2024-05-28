using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class Mpdetalle
    {

        private Mpdetalle() { }

        private static Mpdetalle instance;

        public static Mpdetalle GetInstance()
        {
            if (instance== null)
            {
                instance = new Mpdetalle();
            }
            return instance;
        }
        public List<BEdetallefactura>Map(DataSet ds)
        {
            List<BEdetallefactura> detalles = new List<BEdetallefactura>();

            foreach(DataRow item in ds.Tables[0].Rows)
            {
                detalles.Add(new BEdetallefactura()
                {
                    Id = int.Parse(item["idDetalleFactu"].ToString()),
                    IdArticulo = int.Parse(item["idArticulo"].ToString()),
                    IdFactura = int.Parse(item["idFactu"].ToString()),
                    Cantidad = int.Parse(item["cantidad"].ToString())
                });
            }

            return detalles;
        }

    }
}
