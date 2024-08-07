﻿using System;
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
           
            BE.BEusuario usuario = new BE.BEusuario()
            {
                IdUsuario =(int)row["idUsuario"],
                Nombre= (string)row["nombre"],
                Apellido= (string)row["apellido"],
                DVH= (int)row["dvh"],
                Direccion= (string)row["direccion"],
                FechaNacimiento = (DateTime)row["fechaNacimiento"],              
               // IsBlocked = (string)row["IsBlocked"],              
                Mail= (string)row["mail"],
                usuario= (string)row["usuario"],
                UserPass= (string)row["userPass"],
                NumeroDocumento= (int)row["numeroDocumento"],
                Telefono= (int)row["telefono"]
            };
            return usuario;
        }
    }
}
