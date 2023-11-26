using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLbitacoraC
    {
       private bool _herramientaRecuperada = false;
        private string _idHerramientaRecuperada = "";

        public void ReportarBitacora(BEbitacoraC bEbitacoraC)
        {
            if(bEbitacoraC.Tipo !="Agregado")
            {
                BEbitacoraC bEbitacoraCactivo = DALbitacoraC.ObtenerActivo(bEbitacoraC);
                if(bEbitacoraCactivo==null)
                {
                    return;
                }
                DALbitacoraC.Desactivar(bEbitacoraCactivo.Id);
            }
            DALbitacoraC.ReportarBitacoraCambios(bEbitacoraC);
        }

        public void Desactivar( int id)
        {
            DALbitacoraC.Desactivar(id);
        }

        public bool Activar(BEbitacoraC _beBitacoraC)
        {
            BEbitacoraC obtenerAvtivo= DALbitacoraC.ObtenerActivo(_beBitacoraC);

            DALbitacoraC.Desactivar(obtenerAvtivo.Id);

            DALbitacoraC.Activar(_beBitacoraC.Id);


            if(obtenerAvtivo.Tipo == "MODIFICADO" || obtenerAvtivo.Tipo=="AGREGADO")
            {
                DALherramientas.ModificarC(_beBitacoraC.Herramienta);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<BEbitacoraC> Listar()
        {
            return DALbitacoraC.Listar();
        }

    }
}
