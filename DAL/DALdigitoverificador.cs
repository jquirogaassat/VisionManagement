using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALdigitoverificador
    {
         private SqlHelper sqlHelper = new SqlHelper();

        public bool CargarDVV(int idTabla, int dvv)
        {          
            string query = "";
            query = @"update Dvv set dvv=" + dvv + @" where idTabla=" + idTabla;
            return sqlHelper.ExecuteQuery(query);
        }  // generico

    
        //este es una version mejorada, lo voy a probar
        public int CalcularDVH(DataTable dt, int id = 0)
        {
            if (dt == null || dt.Rows.Count == 0)
                throw new ArgumentException("La tabla de datos está vacía.");

            if (id < 0 || id >= dt.Rows.Count)
                throw new ArgumentOutOfRangeException("El id proporcionado está fuera del rango de filas.");

            int cantidadColumnas = dt.Columns.Count;
            if (cantidadColumnas == 0)
                throw new ArgumentException("La tabla de datos no tiene columnas.");

            StringBuilder str0 = new StringBuilder();

            for (int a = 0; a < cantidadColumnas - 1; a++)
            {
                if (dt.Rows[id][a] != DBNull.Value)
                    str0.Append(dt.Rows[id][a].ToString());
            }

            int sumaASCII = 0;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(str0.ToString());
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                sumaASCII += asciiBytes[i] * (i + 1); // (i + 1) para evitar multiplicar por 0
            }

            return sumaASCII;
        }


        public int CalcularDVV(string nombreTabla)
        {
            string idCampo = "id" + nombreTabla;
            if (idCampo == "idFactura")
                idCampo = "idFactu";
            string query = "if((select COUNT(" + idCampo + ") from " + nombreTabla + ")>0) select sum(dvh)" + "from "
                                                            + nombreTabla + " else select 0";

            return sqlHelper.ExecuteQueryPRUEBA(query);
        } // generico

        public int CalcularDVVp(string nombreTabla)
        {
            string idCampo = "idEstadoHerramienta";

            string query = "if((select COUNT(" + idCampo + ") from " + nombreTabla + ")>0) select sum(dvh)" + "from "
                                                            + nombreTabla + " else select 0";

            return sqlHelper.ExecuteQueryPRUEBA(query);
        }

     

        public bool CargarDVH(string nombreTabla, int id, int dvh)
        {
            if (nombreTabla == "Factura")
            {
                var nombreTabla1 = nombreTabla;
                nombreTabla1 = "Factu";
                string query1 = @"update " + nombreTabla + " set dvh = " + dvh + " where id" + nombreTabla1 + "=" + id;
                return sqlHelper.ExecuteQuery(query1);
            }
           
            
           string query = @"update " + nombreTabla + " set dvh = " + dvh + " where id" + nombreTabla + "=" + id;
           return sqlHelper.ExecuteQuery(query);
        }  // generico

        public bool CargarDVHp(string nombreTabla, int id, int dvh)
        {
            string query = @"update " + nombreTabla + " set dvh = " + dvh + " where idEstadoHerramienta" + "=" + id;
            return sqlHelper.ExecuteQuery(query);
        }
   

     
        public void ArreglarDigitos(List<string> nombreTabla, List<BE.BEtabla> tablas)
        {

            int t = 0;
            while (t < tablas.Count)
            {
                string query = @"select * from " + nombreTabla[t];
                DataTable tabla = sqlHelper.ExecuteReader(query);
                int i = 0;
                int filas = tabla.Rows.Count;
                string idTabla = "id" + nombreTabla[t];
                if (idTabla == "idFactura")
                    idTabla = "idFactu";
                while (i < filas)
                {
                    int idDVH = (int)tabla.Rows[i][idTabla];
                    int dvhCalculo = CalcularDVH(tabla, i);
                    int DVHdb = (int)tabla.Rows[i]["dvh"];

                    if (dvhCalculo != DVHdb)
                    {
                        CargarDVH(nombreTabla[t], idDVH, dvhCalculo);
                    }
                    i++;
                }

                int dvvCalculo = CalcularDVV(nombreTabla[t]);
                int DVVdb = tablas[t].DVV;
                if (dvvCalculo != DVVdb)
                {
                    CargarDVV(tablas[t].idDVV, dvvCalculo);
                }
                t++;
            }
        }


        public List<BE.BEerror> ComprobarIntegridad()
        {
            int idError = 0;
            List<BE.BEerror> errores = new List<BE.BEerror>();
            string query;

            List<string> nombresTablas = new List<string>();
            nombresTablas.Add("Bitacora"); // si 
            //nombresTablas.Add("Usuario");//si
            nombresTablas.Add("Articulo");//si
            nombresTablas.Add("Cliente");// si
            nombresTablas.Add("Herramienta");//si
            nombresTablas.Add("Factura");// si
            nombresTablas.Add("Prestamo");// si

            List<BE.BEtabla> digitosVerticales = Consulta(nombresTablas);

            int t = 0;


            while(t< digitosVerticales.Count)
            {
                query= @"select * from " + nombresTablas[t];
                DataTable tabla = sqlHelper.ExecuteReader(query);
                int i = 0;
                int filas = tabla.Rows.Count;


                string idTabla = "id" + nombresTablas[t];
                if (idTabla == "idFactura")
                    idTabla = "idFactu";
                while(i<filas)
                {
                    int idDVH = (int)tabla.Rows[i][idTabla];
                    int dvhCalculo = CalcularDVH(tabla, i);
                    int dvhDb = 0;
                    dvhDb= (int)tabla.Rows[i]["dvh"];
                    if (dvhCalculo != dvhDb)
                    {
                        idError++;
                        errores.Add(new BE.BEerror(idError, nombresTablas[t], "dvh", idDVH));
                    }
                    i++;
                }

                int dvvCalculo = CalcularDVV(nombresTablas[t]);
                int dvvDb = digitosVerticales[t].DVV;
                if(dvvCalculo != dvvDb)
                {
                    idError++;
                    errores.Add(new BE.BEerror(idError, nombresTablas[t], "DVV", digitosVerticales[t].idDVV));
                }
                t++;
            }

            ArreglarDigitos(nombresTablas, digitosVerticales);

            return errores;


        }

        public List<BE.BEtabla> Consulta(List<string> tabla)
        {
            SqlParameter[] parameters = new SqlParameter[] {};
            //parameters = tabla;
            DataTable dt = sqlHelper.ExecuteReader("dvvConsulta", parameters);
            List<BE.BEtabla> tablas = new List<BE.BEtabla>();
            Mappers.Tabla mapper = new Mappers.Tabla();
            foreach(DataRow row in dt.Rows)
            {
                tablas.Add(mapper.Map(row));
            }

            return tablas; 
        }
    }
}
