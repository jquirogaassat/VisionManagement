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
            _bitacoraC = new BEbitacoraC();
            _bitacoraC.UltimaModificacion = DateTime.Now;
            _bitacoraC.Usuario= nombreUsuario;
            _bitacoraC.Activo = 1;
            _bitacoraC.Tipo = "AGREGADO";
            _bitacoraC.Herramienta = DALherramientas.Obtener(itemAlta.Codigo);
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
