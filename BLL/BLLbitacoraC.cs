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
        DALbitacoraC _bitacoraC = new DALbitacoraC();
        BLLencriptacion encriptadora = new BLLencriptacion();

        public void ReportarBitacora(BEbitacoraC bEbitacoraC)
        {
            
            if(bEbitacoraC.Tipo != "AGREGADO")
            {
                BEbitacoraC bitacorC = DALbitacoraC.ObtenerUltimoRegistroActivo(bEbitacoraC);
                if(bitacorC != null)
                {
                    DALbitacoraC.DesactivarRegistro(bitacorC.Id);
                    DALbitacoraC.ReportarBitacoraCambios(bEbitacoraC);
                    return;
                }
                //DALbitacoraC.DesactivarRegistro(bitacorC.Id);
            }            
            DALbitacoraC.ReportarBitacoraCambios(bEbitacoraC);
        }


        public bool Activar(BEbitacoraC bitacoraC)
        {
            //OBTENGO EL REGISTRO A DESACTIVAR
            BEbitacoraC _bebitactivo = DALbitacoraC.ObtenerUltimoRegistroActivo(bitacoraC);

            //DESACTIVVO EL RESGISTRO
            DALbitacoraC.DesactivarRegistro(_bebitactivo.Id);

            //ACTIVO EL NUEVO REGISTRO
            DALbitacoraC.MarcarRegistroActivo(bitacoraC.Id);

            //SI EL CAMBIO IMPLICA ELIMINAR EL REGISTRO
            if (bitacoraC.Tipo == "ELIMINADO")
            {
                if (ValidarSiEsEliminable(bitacoraC.IdHerramienta.Id))
                {
                    DALherramientas.Eliminar(bitacoraC.IdHerramienta.Id);
                    return true;
                }
                return false;

            }
            
            //ACTUALIZO LA TABLA DE HERRAMIENTAS CON EL NUEVO REGISTRO ACTIVO
            if(_bebitactivo.Tipo=="MODIFICADO"||_bebitactivo.Tipo=="AGREGADO")
            {
                DALherramientas.ModificarC(bitacoraC.IdHerramienta);
                return true;
            }
            else if(_bebitactivo.Tipo =="ELIMINADO")
            {
                if(DALherramientas.Obtener(bitacoraC.IdHerramienta.Codigo)==null)
                {
                    DALherramientas.Guardar(bitacoraC.IdHerramienta);
                    BEherramientas herramientaB = DALherramientas.Obtener(bitacoraC.IdHerramienta.Codigo);
                    List<BEbitacoraC> listaBitacora = DALbitacoraC.ListarPorId(bitacoraC.IdHerramienta.Id);
                    foreach(BEbitacoraC item in listaBitacora)
                    {
                        item.IdHerramienta = herramientaB;
                        DALbitacoraC.ActualizarIdHerramienta(item);
                        _herramientaRecuperada = true;
                        _idHerramientaRecuperada = item.IdHerramienta.Id.ToString();
                    }
                    return true;
                }
            }
            return false;
        }


        public bool ValidarSiEsEliminable(int idHerramienta)
        {
            BLprestamo _prestamoBl = new BLprestamo();
            List<BEprestamo> prestamos = _prestamoBl.Consultar();
            BEprestamo prestamoAsociado = prestamos.Find(prestamo=> prestamo.Herramienta.Id == idHerramienta);
            if(prestamoAsociado == null)
            {
                return true;
            }
            return false;
        }

        public List<BEbitacoraC> Listar()
        {
            List<BEbitacoraC> bitacora = new List<BEbitacoraC>();
            bitacora = DALbitacoraC.Listar();
            //foreach(var item in bitacora)
            //{
            //    item.Usuario=encriptadora.desencriptarAes(item.Usuario);
            //}
            return bitacora;
        }

        public List<string>ListarCodigo()
        {
            return DALbitacoraC.ListarCodigo();
        }

        public List<BEbitacoraC> FiltrarBitacora(string codigo = null, string fechaInicio = null, string fechaFin = null, string nombreUsuario = null)
        {
            return DALbitacoraC.FiltrarBitacora(codigo, fechaInicio, fechaFin, nombreUsuario);
        }

    }
}
