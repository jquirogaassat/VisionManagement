using BE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DALbitacoraC
    {
     
        
       public static int ReportarBitacoraCambios(BEbitacoraC bEbitacoraC)
        {
            string cmd = "INSERT INTO BitacoraCambios (ultimaModificacion, usuario, activo, idHerramienta, disponible, estado, tipo) VALUES "
                + "('" + bEbitacoraC.UltimaModificacion + "','" + bEbitacoraC.Usuario + "'," + bEbitacoraC.Activo + ",'" + bEbitacoraC.Herramienta.Id + "','"
                + bEbitacoraC.Herramienta.Disponible + "'," + bEbitacoraC.Herramienta.Estado + ",'" + bEbitacoraC.Tipo + "'); ";
            SqlHelper sqlHelper = new SqlHelper();            
            return sqlHelper.ExecuteNonQuery(cmd);
        }
       public static BEbitacoraC ObtenerActivo(BEbitacoraC bEbitacoraC)
        {
            string commandText = "SELECT * FROM BitacoraCambios WHERE idHerramienta = " + bEbitacoraC.Herramienta.Id + "AND activo =1 ";
            SqlHelper sqlHelper = new SqlHelper();

            DataSet mds= sqlHelper.ExecuteDataSet(commandText);

            if(mds.Tables.Count > 0 && mds.Tables[0].Rows.Count>0 ) 
            {
                BEbitacoraC _beBitacoraC= new BEbitacoraC();
                Valorizar(_beBitacoraC, mds.Tables[0].Rows[0]);
                return _beBitacoraC;
            }
            else
            {
                return null;

            }
        }

        public static void Desactivar(int _idBitacoraC)
        {
            string commandText = "UPDATE BitacoraCambios SET activo = 0 WHERE idHerramienta = " + _idBitacoraC + ";";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.ExecuteNonQuery(commandText);
        }

        public static void Activar( int _idBitacoraC) 
        {
            string commandText= "UPDATE BitacoraCambios SET activo = 1 WHERE idHerramienta = " + _idBitacoraC + ";";
            SqlHelper sqlHelper = new SqlHelper();
            sqlHelper.ExecuteNonQuery(commandText);
        }

        public static List<BEbitacoraC> Listar()
        {
            string mCmd = "SELECT * FROM BitacoraCambios;";

            SqlHelper sqlHelper= new SqlHelper();
            DataSet ds= sqlHelper.ExecuteDataSet(mCmd);
            List<BEbitacoraC> lista= new List<BEbitacoraC> ();

            if(ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    BEbitacoraC _bitacoraC= new BEbitacoraC ();
                    Valorizar(_bitacoraC,dr);
                    lista.Add(_bitacoraC);
                }
            }
            return lista;
        }


        internal static void Valorizar(BEbitacoraC bitacoraC, DataRow pDataRow)
        {
            bitacoraC.Id = int.Parse(pDataRow["idBitacoraC"].ToString());
            bitacoraC.UltimaModificacion = (DateTime)pDataRow["ultimaModificacion"];
            bitacoraC.Usuario = pDataRow["usuario"].ToString();
            bitacoraC.Activo = int.Parse(pDataRow["activo"].ToString());
            bitacoraC.Herramienta = new BEherramientas();
            bitacoraC.Herramienta.Id = int.Parse(pDataRow["idHerramienta"].ToString());
            bitacoraC.Herramienta.Disponible = pDataRow["disponible"].ToString();
            bitacoraC.Herramienta.Estado = int.Parse(pDataRow["estado"].ToString());
            bitacoraC.Tipo= pDataRow["tipo"].ToString();

        }

    }
}
