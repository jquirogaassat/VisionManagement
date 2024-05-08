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

              
      
        public static int ReportarBitacoraCambios(BEbitacoraC beBitacoraC)
        {
            string connectionString = @"Data Source=DESKTOP-F8CBKLT;Initial Catalog=VisionTFI;Integrated Security=True;TrustServerCertificate=True";
            int rowsAffected = 0;

           
            string query = "INSERT INTO BitacoraCambio (ultimaModificacion, usuario, activo, idHerramienta, disponible, estado, tipo, nombre, color, origen, codigo, precio) VALUES " +
                            "(@UltimaModificacion, @Usuario, @Activo, @IdHerramienta, @Disponible, @Estado, @Tipo, @Nombre, @Color, @Origen, @Codigo, @Precio)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UltimaModificacion", beBitacoraC.UltimaModificacion);
                command.Parameters.AddWithValue("@Usuario", beBitacoraC.Usuario);
                command.Parameters.AddWithValue("@Activo", beBitacoraC.Activo);
                command.Parameters.AddWithValue("@IdHerramienta", beBitacoraC.IdHerramienta.Id);
                command.Parameters.AddWithValue("@Disponible", beBitacoraC.IdHerramienta.Disponible);
                command.Parameters.AddWithValue("@Estado", beBitacoraC.IdHerramienta.Estado);
                command.Parameters.AddWithValue("@Tipo", beBitacoraC.Tipo);
                command.Parameters.AddWithValue("@Nombre", beBitacoraC.IdHerramienta.Nombre);
                command.Parameters.AddWithValue("@Color", beBitacoraC.IdHerramienta.Color);
                command.Parameters.AddWithValue("@Origen", beBitacoraC.IdHerramienta.Origen);
                command.Parameters.AddWithValue("@Codigo", beBitacoraC.IdHerramienta.Codigo);
                command.Parameters.AddWithValue("@Precio", beBitacoraC.IdHerramienta.Precio);

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected;
        }


        // Método para obtener el último registro activo de la bitácora para una herramienta específica
        public static  BEbitacoraC ObtenerUltimoRegistroActivo(BEbitacoraC bitacoraC)
        {
            string connectionString = @"Data Source=DESKTOP-F8CBKLT;Initial Catalog=VisionTFI;Integrated Security=True;TrustServerCertificate=True";
            BEbitacoraC bitacora = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 * FROM BitacoraCambio WHERE idHerramienta = "+bitacoraC.IdHerramienta.Id +" AND activo =1;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idHerramienta", bitacoraC.IdHerramienta.Id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    bitacora = new BEbitacoraC
                    {
                        Id = Convert.ToInt32(reader["idBitacoraCambio"]),
                        Activo = Convert.ToInt32(reader["Activo"]),
                        Usuario = reader["Usuario"].ToString(),
                        UltimaModificacion = Convert.ToDateTime(reader["UltimaModificacion"]),
                        IdHerramienta = new BEherramientas // Asegúrate de definir la clase BEherramientas adecuadamente
                        {
                            Id= Convert.ToInt32(reader["idHerramienta"]),
                        },
                        Tipo = reader["Tipo"].ToString()
                    };
                }

                reader.Close();
            }

            return bitacora;
        }

        // Método para marcar un registro como activo y los demás como inactivos para una herramienta específica
        public static void MarcarRegistroActivo(int idBit)
        {
            string connectionString = @"Data Source=DESKTOP-F8CBKLT;Initial Catalog=VisionTFI;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE BitacoraCambio SET Activo = 1  WHERE idBitacoraCambio = "+ idBit+";";

                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@idBitacoraCambio", idBit);
                //command.Parameters.AddWithValue("@HerramientaId", herramientaId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static int DesactivarRegistro(int idBit)
        {
            string connectionString = @"Data Source=DESKTOP-F8CBKLT;Initial Catalog=VisionTFI;Integrated Security=True;TrustServerCertificate=True";
            int rowsAffected = 0;

            
            string query = "UPDATE BitacoraCambio SET Activo = 0 WHERE idBitacoraCambio = "+idBit+";";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idBitacoraCambio", idBit);

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected;
        }


        public static List<BEbitacoraC> ListarPorId(int idHerramientaBit)
        {
            string mCommandText = "SELECT * FROM BitacoraCambio WHERE codigo= " + idHerramientaBit + ";";

            SqlHelper _helper = new SqlHelper();

            DataSet mDs = _helper.ExecuteDataSet(mCommandText);
            List<BEbitacoraC> listaBitacora = new List<BEbitacoraC>();

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDs.Tables[0].Rows)
                {
                    BEbitacoraC _bebitacoraC = new BEbitacoraC();
                    ValorizarEntidad(_bebitacoraC, mDr);
                    listaBitacora.Add(_bebitacoraC);
                }
            }
            return listaBitacora;
        }


        internal static void ValorizarEntidad(BEbitacoraC pBitCambio, DataRow pDataRow)
        {            
            pBitCambio.Id = int.Parse(pDataRow["idBitacoraCambio"].ToString());
            pBitCambio.UltimaModificacion = (DateTime)pDataRow["ultimaModificacion"];
            pBitCambio.Usuario = pDataRow["usuario"].ToString();
            pBitCambio.Activo = int.Parse(pDataRow["activo"].ToString());
            pBitCambio.IdHerramienta = new BEherramientas();
            pBitCambio.IdHerramienta.Id = int.Parse(pDataRow["idHerramienta"].ToString());
            pBitCambio.IdHerramienta.Disponible = pDataRow["disponible"].ToString();            
            pBitCambio.IdHerramienta.Estado = int.Parse(pDataRow["estado"].ToString());
            pBitCambio.IdHerramienta.Nombre = pDataRow["nombre"].ToString();
            pBitCambio.IdHerramienta.Color = pDataRow["color"].ToString();
            pBitCambio.IdHerramienta.Origen = pDataRow["origen"].ToString();
            pBitCambio.IdHerramienta.Codigo = int.Parse(pDataRow["codigo"].ToString());
            pBitCambio.IdHerramienta.Precio = int.Parse(pDataRow["precio"].ToString());
            pBitCambio.Tipo = pDataRow["tipo"].ToString();
        }


        public static int ActualizarIdHerramienta(BEbitacoraC bEbitacoraC) 
        {
            string mCommandText = "UPDATE BitacoraCambio SET idHerramienta = " + bEbitacoraC.IdHerramienta.Id + "WHERE idBitacoraCambio = " + bEbitacoraC.Id + ";";
            SqlHelper sqlHelper = new SqlHelper();
            return sqlHelper.ExecuteNonQuery(mCommandText);
        }

        public static List<BEbitacoraC> Listar()
        {
            string mCommandText = "SELECT * FROM BitacoraCambio ;";
            SqlHelper _helper = new SqlHelper();

            DataSet mDs = _helper.ExecuteDataSet(mCommandText);
            List<BEbitacoraC> listaBitacora = new List<BEbitacoraC>();

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDs.Tables[0].Rows)
                {
                    BEbitacoraC _bEbitacoraC = new BEbitacoraC();
                    ValorizarEntidad(_bEbitacoraC, mDr);
                    listaBitacora.Add(_bEbitacoraC);
                }
            }
            return listaBitacora;

        }

        public static List<string> ListarCodigo()
        {
            string mCommandText = "SELECT DISTINCT codigo FROM BitacoraCambio;";
            SqlHelper _helper = new SqlHelper();

            DataSet mDs =_helper.ExecuteDataSet(mCommandText);
            List<string> listaCodigo = new List<string>();
            listaCodigo.Add("");
            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDs.Tables[0].Rows)
                {
                    listaCodigo.Add(mDr["codigo"].ToString());
                }

            }
            return listaCodigo;
        }

        public static List<BEbitacoraC> FiltrarBitacora(string codigo = null, string fechaInicio = null, string fechaFin = null, string nombreUsuario = null)
        {
            string mCommandText = "SELECT * FROM BitacoraCambio WHERE ";

            if (codigo != null && codigo != "")
            {
                if (mCommandText != "SELECT * FROM BitacoraCambio WHERE ")
                {
                    mCommandText += "AND";
                }
                mCommandText += "codigo =" + int.Parse(codigo) + " ";
            }
            if ((fechaInicio != null && fechaFin != null) && (fechaInicio != "" && fechaFin != ""))
            {
                if (mCommandText != "SELECT * FROM BitacoraCambio WHERE ")
                {
                    mCommandText += " AND ";
                }
                mCommandText += "ultimaModificacion BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "' ";
            }
            if (nombreUsuario != null )
            {
                if (mCommandText != "SELECT * FROM BitacoraCambio WHERE ")
                {
                    mCommandText += " AND ";
                }
                mCommandText += "usuario = '" + nombreUsuario + "' ";
            }

            mCommandText += ";";

            SqlHelper _helper = new SqlHelper();
            DataSet mDs = _helper.ExecuteDataSet(mCommandText);
            List<BEbitacoraC> listaBitacora = new List<BEbitacoraC>();

            if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow mDr in mDs.Tables[0].Rows)
                {
                    BEbitacoraC _bitacoraC = new BEbitacoraC();
                    ValorizarEntidad(_bitacoraC, mDr);
                    listaBitacora.Add(_bitacoraC);
                }

            }
            return listaBitacora;
        }
        
    }

}





