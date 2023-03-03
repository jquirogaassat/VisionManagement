using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Mappers
{
    internal class MPbackup
    {
        public BE.BEbackup Map(DataRow row)
        {
            BE.BEusuario bEusuario = new BE.BEusuario()
            {
                IdUsuario = (int)row["idUsuario"]
            };
            DAL.DALusuario usuarioDal = new DAL.DALusuario();
            BE.BEbackup backup = new BE.BEbackup()
            {
                IdBackup = (int)row["idBackup"],
                Usuario = (BE.BEusuario)usuarioDal.ConsultarUsuario(bEusuario),
                Nombre = (string)row["nombre"],
                FechaAlta = (DateTime)row["fechaAlta"],
                Particiones = (int)row["particiones"],
                Ubicacion = (string)row["ubicacion"],
            };
            // DAL.da
            return backup;
        }
    }
}
