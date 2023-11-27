using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLherramientas
    {
        internal BEbitacoraC _bitacoraC=null;
        internal BLLbitacoraC _llBitacoraC=null;
        //Alta Herramienta
        public bool Alta(BEherramientas itemAlta, string nombreUsuario)
        {
            DAL.DALherramientas herramientaD=new DALherramientas();
            return herramientaD.Alta(itemAlta);         
        }
        //Baja logica de herramientas
        public bool Baja(BEherramientas itemBaja)
        {
            DAL.DALherramientas herramientaD = new DALherramientas();
            return herramientaD.Baja(itemBaja);
        }
        // listar todas las herramientas
        public List<BEherramientas> Listar()
        {
            DAL.DALherramientas herramientaD = new DALherramientas();
            return herramientaD.Listar();
        }
        // modificar herramientas
        public bool Modificar(BEherramientas itemModifica)
        {
            DAL.DALherramientas herramientaD = new DALherramientas();
            return herramientaD.Modificar(itemModifica);
        }
    }
}
