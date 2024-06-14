using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLarticulo : BE.ICRUd<BE.BEarticulo>
    {
        //Alta articulo
        public bool Alta(BEarticulo itemAlta)
        {
            return DAL.DALarticulo.GetInstancia().Alta(itemAlta);
        }
        //Baja logica de articulo
        public bool Baja(BEarticulo itemBaja)
        {
            return DAL.DALarticulo.GetInstancia().Baja(itemBaja);
        }
        // listar todos los articulos
        public List<BEarticulo> Listar()
        {
            return DAL.DALarticulo.GetInstancia().Listar();
        }
        // modificar articulos
        public bool Modificar(BEarticulo itemModifica)
        {
            return DAL.DALarticulo.GetInstancia().Modificar(itemModifica);
        }
        //No implementado!!!!
        List<BEarticulo> ICRUd<BEarticulo>.Listar()
        {
            throw new NotImplementedException();
        }
        //No implementado!!!
        public IList<BEarticulo> Lista()
        {
            throw new NotImplementedException();
        }

        public DataTable CargarInforme()
        {
            return DAL.DALarticulo.GetInstancia().CargarInforme();
        }
    }
}
