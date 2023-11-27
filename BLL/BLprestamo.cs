using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLprestamo
    {
        DAL.DALprestamo _prestamoD =new DAL.DALprestamo();
        public bool Alta(BEprestamo itemAlta)
        {
            return _prestamoD.Alta(itemAlta);
        }

        public bool Modificar(BEprestamo itemModificar)
        {
            throw new NotImplementedException();
        }
        
        public bool Eliminar (BEprestamo itemElimina)
        {
            throw new NotImplementedException();
        }

        public List<BEprestamo> Consultar()
        {
            return _prestamoD.Consultar();
        }

        public BEprestamo ConsultarPrestamo(int idPrestamo)
        {
            return _prestamoD.ConsultarPrestamo(idPrestamo);
        }
    }
}
