
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL.Mappers
{
    public class MPbitacora
    {
        public BE.BEgestionbitacora Map(DataRow row)
        {
            BE.BEgestionbitacora bitacora = new BE.BEgestionbitacora()
            {
                IdBitacora = (int)row["idBITTACORA"],
                idPatente = (int)row["idPatente"],
                IdUsuario = (int)row["idUsuario"],
                FechaHora = (DateTime)row["fechaHora"],
                Criticidad = (string)row["nivelCriticidad"],
                Descripcion = (string)row["descripcion"],
                Dvh = (int)row["dvh"]
            };
            return bitacora;
        }
    }
}
