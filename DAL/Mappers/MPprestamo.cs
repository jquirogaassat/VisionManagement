using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class MPprestamo
    {
        public BEprestamo Map(DataRow row)
        {
           DALherramientas _herramientaD= new DALherramientas();
           DALcliente _cliente= new DALcliente();
           MPcliente _clienteM = new MPcliente();
           MPherramienta _herramientaM = new MPherramienta();
            BEprestamo prestamos = new BEprestamo()
            {
                IdPrestamo = (int)row["idPrestamo"],
                Herramienta = _herramientaM.Map(_herramientaD.consultarHerramientaDT((int)row["idHerramienta"]).Rows[0]),
                Cliente = _clienteM.Map(_cliente.ConsultarClienteDT((int)row["idCliente"]).Rows[0]),
                FechaInicio = (DateTime)row["fechaInicio"],
                FechaDevolucion = (DateTime)row["fechaDevolucion"],
                Estado = (string)row["estado"],
                Observaciones = (string)row["observaciones"],
                Dvh = (int)row["dvh"]
            };
            return prestamos;
        }
    }
}
