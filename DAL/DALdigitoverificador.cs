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
        SqlHelper sqlHelper = new SqlHelper();

        public bool CargarDVV(int idTabla, int dvv)
        {
            string query = "";
            query = @"update dvv set dvv=" + dvv + @" where idTabla=" + idTabla;
            return sqlHelper.ExecuteQuery(query);
        }

        public int CalcularDVH(DataTable dt, int id = 0)
        {
            int cantidadColumnas = dt.Columns.Count;
            int a = 0;
            string str0 = "";
            int sumaASCII = 0;
            while (a < cantidadColumnas - 1)
            {
                str0 = str0 + (dt.Rows[id][a]).ToString();
                a++;
            }

            for (int i = 0; i < Encoding.ASCII.GetBytes(str0.ToString()).Count(); i++)
            {
                sumaASCII += (Encoding.ASCII.GetBytes(str0.ToString())[i]) * i;
            }
            return sumaASCII;
        }


        public int CalcularDVV(string nombreTabla)
        {
            string idCampo = "id" + nombreTabla;

            string query = "if((select COUNT(" + idCampo + ") from " + nombreTabla + ")>0) select sum(dvh)" + "from "
                                                            + nombreTabla + " else select 0";

            return sqlHelper.ExecuteQueryPRUEBA(query);
        }

        public int CalcularDVVb(string nombreTabla)
        {
            string idCampo = "idBitacora";

            string query = "if((select COUNT(" + idCampo + ") from " + nombreTabla + ")>0) select sum(dvh)" + "from "
                                                            + nombreTabla + " else select 0";

            return sqlHelper.ExecuteQueryPRUEBA(query);
        }

        public bool CargarDVH(string nombreTabla, int id, int dvh)
        {
            string query = @"update " + nombreTabla + " set dvh = " + dvh + " where id" + nombreTabla + "=" + id;
            return sqlHelper.ExecuteQuery(query);
        }

        public bool CargarDVHb(string nombreTabla, int id, int dvh)
        {
            string query = @"update " + nombreTabla + " set dvh = " + dvh + " where idBitacora" + "=" + id;
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
            nombresTablas.Add("BITACORA");
            nombresTablas.Add("USUARIO");
            nombresTablas.Add("USUARIO-PERMISO");
            nombresTablas.Add("PERMISO-PERMISO");
            // nombresTablas.Add()

            List<BE.BEtabla> digitosVerticales = Consulta();

            int t = 0;


            while(t< digitosVerticales.Count)
            {
                query= @"select * from " + nombresTablas[t];
                DataTable tabla = sqlHelper.ExecuteReader(query);
                int i = 0;
                int filas = tabla.Rows.Count;


                string idTabla = "id" + nombresTablas[t];
                while(i<filas)
                {
                    int idDVH = (int)tabla.Rows[i][idTabla];
                    int dvhCalculo = CalcularDVH(tabla, i);
                    int dvhDb= (int)tabla.Rows[i]["dvh"];
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

        public List<BE.BEtabla> Consulta()
        {
            SqlParameter[] parameters = new SqlParameter[] {};
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
