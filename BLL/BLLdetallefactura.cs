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
        #region Singleton
        private BLLdetallefactura() { }

        private static BLLdetallefactura instance;

        public static BLLdetallefactura getInstance()
        {
            if (instance == null)
            {
                instance = new BLLdetallefactura();
            }
            return instance;
        } 
        #endregion


        public bool Add(BEdetallefactura itemAlta)
        {
            return DAL.DALdetallefactura.get
        }


    }
}
