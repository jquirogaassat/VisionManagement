using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLdigitoverificador 
    {
      DAL.DALdigitoverificador dvDal = new DAL.DALdigitoverificador();

        public List<BE.BEerror> ComprobarIntegridad()
        {
            return dvDal.ComprobarIntegridad();
        }
    }
}
