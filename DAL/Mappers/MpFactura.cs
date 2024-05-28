using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class MpFactura
    {
        #region Singleton

        private MpFactura() { }

        private static MpFactura instancia;
        public static MpFactura getInstancia()
        {
            if (instancia == null)
            {
                instancia = new MpFactura();
            }
            return instancia;
        } 
        #endregion


        public List<BEfactura>Map(DataSet ds)
        {
            List<BEfactura> bEfacturas = new List<BEfactura>();
            foreach(DataRow row in ds.Tables[0].Rows) 
            {
                bEfacturas.Add(new BEfactura()
                {
                    Id = int.Parse(row["idFactu"].ToString()),
                    Fecha = DateTime.Parse(row["fecha"].ToString()),
                    IdCliente = int.Parse(row["idCliente"].ToString())
                });
            }
            return bEfacturas;
        }



    }
}
