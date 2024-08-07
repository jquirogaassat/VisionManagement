﻿using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALherramientas
    {
        
      
        public SqlHelper sqlHelper = new SqlHelper();

        //consulto el id
        public DataTable consultarHerramientaDT(int idHerramienta)
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idHerramienta",idHerramienta),
            };

            DataTable dt = sqlHelper.ExecuteReader("herramientaConsulta", parametros);
            return dt;
        }

        public DataTable ConsultarHerramientaEstadoDT(int idEstadoHerramienta)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("idEstadoHerramienta",idEstadoHerramienta),
            };

            DataTable dt = sqlHelper.ExecuteReader("herramientaEstadoConsultar", parameters);
            return dt;
        }
        // alta de herramienta
        public bool Alta(BEherramientas itemAlta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("nombre", itemAlta.Nombre),
                new SqlParameter("color", itemAlta.Color),
                new SqlParameter("origen", itemAlta.Origen),
                new SqlParameter("codigo", itemAlta.Codigo),
                new SqlParameter("precio",itemAlta.Precio),
                new SqlParameter("estado", itemAlta.Estado),
                new SqlParameter("disponible",itemAlta.Disponible),
                new SqlParameter("ultimaModificacion",itemAlta.UltimaModificacion),
            };

            int nuevoId = sqlHelper.ExecuteQueryPRUEBA("herramientaInsert", parametros);
            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
            int dvh = dvDal.CalcularDVH(consultarHerramientaDT(nuevoId), 0);
            dvDal.CargarDVH("Herramienta", nuevoId, dvh);
            int dvv = dvDal.CalcularDVV("Herramienta");

            //dvDal.CargarDVV(6, dvv);
            return dvDal.CargarDVV(5, dvv);
        }
        // Baja logica de la herramienta
        public bool Baja(BEherramientas itemBaja)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idHerramienta",itemBaja.Id)
            };

            bool resultado = sqlHelper.ExecuteQuery("herramientaBajaLogica", parametros);

            if(resultado)
            {
                return true;
            }

            return (resultado);
        }
        // modificar la herramienta
        public bool Modificar(BEherramientas itemModifica)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("idHerramienta",itemModifica.Id),
                new SqlParameter("nombre", itemModifica.Nombre),
                new SqlParameter("color", itemModifica.Color),
                new SqlParameter("origen", itemModifica.Origen),
                new SqlParameter("codigo", itemModifica.Codigo),
                new SqlParameter("precio",itemModifica.Precio),
                new SqlParameter("estado",itemModifica.Estado),
                new SqlParameter("disponible",itemModifica.Disponible),
                new SqlParameter("ultimaModificacion",itemModifica.UltimaModificacion),
            };

            sqlHelper.ExecuteQuery("herramientaUpdate", parametros);
            DAL.DALdigitoverificador dvDal = new DALdigitoverificador();
            int dvh = dvDal.CalcularDVH(consultarHerramientaDT(itemModifica.Id), 0);
            dvDal.CargarDVH("Herramienta", itemModifica.Id, dvh);
            int dvv = dvDal.CalcularDVV("Herramienta");

            //dvDal.CargarDVV(3, dvv);
            return dvDal.CargarDVV(5, dvv);
        }

        // traigo todas las herramientas
        public List<BEherramientas> Listar()
        {
            SqlParameter[] parametros = new SqlParameter[] { };
            DataTable dt = sqlHelper.ExecuteReader("herramientaSelect", parametros);
            List<BEherramientas> herramientas = new List<BEherramientas>();
            Mappers.MPherramienta map = new Mappers.MPherramienta();
            foreach (DataRow row in dt.Rows)
            {
                herramientas.Add(map.Map(row));
            }
            return herramientas;
        }


      
        public static int ModificarC(BEherramientas _herramienta)
        {
            string cmd = "UPDATE Herramienta SET nombre = @Nombre, color = @Color, origen = @Origen, codigo = @Codigo, " +
                         "precio = @Precio, estado = @Estado, disponible = @Disponible, ultimaModificacion = @UltimaModificacion " +
                         "WHERE idHerramienta = @Id";

            SqlHelper sqlHelper = new SqlHelper();

            SqlParameter[] parametros = new SqlParameter[]
            {
             new SqlParameter("@Nombre", _herramienta.Nombre),
             new SqlParameter("@Color", _herramienta.Color),
             new SqlParameter("@Origen", _herramienta.Origen),
             new SqlParameter("@Codigo", _herramienta.Codigo),
             new SqlParameter("@Precio", _herramienta.Precio),
             new SqlParameter("@Estado", _herramienta.Estado),
             new SqlParameter("@Disponible", _herramienta.Disponible),
             new SqlParameter("@UltimaModificacion", _herramienta.UltimaModificacion),
             new SqlParameter("@Id", _herramienta.Id)
            };

            int val = sqlHelper.ExecuteNonQuery(cmd, parametros);
            return val;
        }



        public static BEherramientas Obtener(int codigo)
        {
            string cmd= "SELECT * FROM Herramienta WHERE codigo= '"+ codigo + "';";
            SqlHelper sqlHelper = new SqlHelper();
            DataSet ds = sqlHelper.ExecuteDataSet(cmd);

            if(ds.Tables.Count > 0 && ds.Tables[0].Rows.Count>0) 
            {
                BEherramientas bEherramientas = new BEherramientas();
                ValorizarEntidad(bEherramientas, ds.Tables[0].Rows[0]);
                return bEherramientas;
            }
            else { return null; }
        }


        public static void ValorizarEntidad(BEherramientas bEherramientas, DataRow dr)
        {
            bEherramientas.Id = int.Parse(dr["idHerramienta"].ToString());
            bEherramientas.Nombre = dr["nombre"].ToString();
            bEherramientas.Color = dr["color"].ToString();
            bEherramientas.Origen = dr["origen"].ToString();
            bEherramientas.Codigo = int.Parse(dr["codigo"].ToString());
            bEherramientas.Precio = int.Parse(dr["precio"].ToString());
            bEherramientas.Estado = int.Parse(dr["estado"].ToString());
            bEherramientas.Disponible = dr["disponible"].ToString();
            bEherramientas.UltimaModificacion = (DateTime)dr["ultimaModificacion"];
        }

        public static int Eliminar(int idHerramienta)
        {
            SqlHelper helper = new SqlHelper();
            string query = "DELETE Herramienta  WHERE idHerramienta = " + idHerramienta;
            return helper.ExecuteNonQuery(query);
        }

        public static int Guardar(BEherramientas pherramienta)
        {
            string cmd = "INSERT INTO Herramienta (nombre, color, origen, codigo, precio, estado, disponible, ultimaModificacion) " +
                         "VALUES (@Nombre, @Color, @Origen, @Codigo, @Precio, @Estado, @Disponible, @UltimaModificacion)";

            SqlHelper sqlHelper = new SqlHelper();

            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@Nombre", pherramienta.Nombre),
        new SqlParameter("@Color", pherramienta.Color),
        new SqlParameter("@Origen", pherramienta.Origen),
        new SqlParameter("@Codigo", pherramienta.Codigo),
        new SqlParameter("@Precio", pherramienta.Precio),
        new SqlParameter("@Estado", pherramienta.Estado),
        new SqlParameter("@Disponible", pherramienta.Disponible),
        new SqlParameter("@UltimaModificacion", pherramienta.UltimaModificacion)
            };

            int val = sqlHelper.ExecuteNonQuery(cmd, parametros);
            return val;
        }

       


    }
}
