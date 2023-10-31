using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLherramientas
    {
        //Alta Herramienta
        public bool Alta(BEherramientas itemAlta)
        {
            return DAL.DALherramientas.getInstance().Alta(itemAlta);
        }
        //Baja logica de herramientas
        public bool Baja(BEherramientas itemBaja)
        {
            return DAL.DALherramientas.getInstance().Baja(itemBaja); 
        }
        // listar todas las herramientas
        public List<BEherramientas> Listar()
        {
            return DAL.DALherramientas.getInstance().Listar();
        }
        // modificar herramientas
        public bool Modificar(BEherramientas itemModifica)
        {
            return DAL.DALherramientas.getInstance().Modificar(itemModifica);
        }
    }
}
