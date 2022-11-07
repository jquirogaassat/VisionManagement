using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLarticulo : BE.ICRUd<BE.BEarticulo>
    {
        #region singleton
        private BLLarticulo()
        {

        }

        private static BLLarticulo instancia;

        public static BLLarticulo GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new BLLarticulo();
            }
            return instancia;
        } 
        #endregion



        public bool Alta(BEarticulo itemAlta)
        {
            return DAL.DALarticulo.GetInstancia().Alta(itemAlta);
        }

        public bool Baja(BEarticulo itemBaja)
        {
            return DAL.DALarticulo.GetInstancia().Baja(itemBaja);
        }

        public IList<BEarticulo> Listar()
        {
            return DAL.DALarticulo.GetInstancia().Listar();
        }

        public bool Modificar(BEarticulo itemModifica)
        {
            return DAL.DALarticulo.GetInstancia().Modificar(itemModifica);
        }
    }
}
