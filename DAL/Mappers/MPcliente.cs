using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Mappers
{
    internal class MPcliente
    {
        //#region Singleton
        //private MPcliente()
        //{

        //}

        //private static MPcliente instancia;

        //public static MPcliente GetInstancia()
        //{
        //    if (instancia == null)
        //    {
        //        instancia = new MPcliente();
        //    }
        //    return instancia;
        //}
        //#endregion


        //public List <BE.BEcliente> Map (DataSet ds)
        //{
        //    List<BE.BEcliente> clientes = new List<BE.BEcliente>();

        //    foreach(DataRow row in ds.Tables[0].Rows)
        //    {
        //        clientes.Add(new BE.BEcliente()
        //        {
        //            IdCliente= int.Parse(row["idCliente"].ToString()),
        //            Apellido= row["apellido"].ToString(),
        //            Nombre = row["nombre"].ToString(),
        //            Cuit= row["cuit"].ToString(),
        //            Email= row["mail"].ToString(),
        //            Direccion= row["direccion"].ToString(),
        //            Localidad= row["localidad"].ToString(),
        //            Telefono= row["telefono"].ToString()
        //        });
        //    }
        //    return clientes;
        //}

        public BE.BEcliente Map (DataRow row)
        {
            BE.BEcliente cliente = new BE.BEcliente()
            {
                IdCliente = int.Parse(row["idCliente"].ToString()),
                Apellido = row["apellido"].ToString(),
                Nombre = row["nombre"].ToString(),
                Cuit = row["cuit"].ToString(),
                Email = row["mail"].ToString(),
                Direccion = row["direccion"].ToString(),
                Localidad = row["localidad"].ToString(),
                Telefono = row["telefono"].ToString()
            };
            return cliente;
        }
    }
}
