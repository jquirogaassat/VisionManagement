using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Mappers
{
    internal class MPusuario
    {
        public BE.BEusuario Map(DataRow row)
        {
            DAL.DALidioma idioma = new DAL.DALidioma();
            BE.BEusuario usuario = new BE.BEusuario()
            {
                IdUsuario =(int)row["id_usuario"],
                Nombre= (string)row["usuario"],
                Apellido= (string)row["apellido"],
                DVH= (int)row["dvh"],
                Direccion= (string)row["direccion"],
                FechaNacimiento = (DateTime)row["fechaNacimiento"],
                FechaAlta= (DateTime)row["fechaAlta"],
                //Idioma= idioma.ConsultaIdioma((int)row["idioma"]),
                Mail= (string)row["mail"],
                UserName= (string)row["userName"],
                UserPass= (string)row["pass"],
                NumeroDocumento= (int)row["dni"],
                Telefono= (int)row["telefono"]
            };
            return usuario;
        }
    }
}
