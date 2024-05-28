using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class BLLdetallefactura 
    {
      

        private DAL.DALdetallefactura _daldetalle = new DALdetallefactura();
        public bool Add(BEdetallefactura itemAlta)
        {
            return _daldetalle.Add(itemAlta);
        }

        public bool Add(BEdetallefactura itemAlta, BEfactura factura)
        {
            return _daldetalle.Add(itemAlta, factura);
        }

        public bool Delete(BEdetallefactura itemDel)
        {
            return _daldetalle.Delete(itemDel);
        }

        public List<BEdetallefactura> GetAll(BEfactura facDet)
        {
            return _daldetalle.GetAll(facDet);
        }
    }
}
