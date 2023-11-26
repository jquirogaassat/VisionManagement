using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Common;

namespace DAL
{
    public class SqlHelper
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString);
     
        //private SqlConnection connection;
        //private DataSet DataSet;
        //private SqlCommand command;
        //private SqlDataReader reader;
        //private SqlDataAdapter adapter;
        //private DataTable dt;



        //public string connectionString { get; private set; }

        //#region Singleton
        //private SqlHelper(string connStr)
        //{
        //    this.connectionString = connStr;
        //}

        //private static SqlHelper instancia;

        //public static SqlHelper getInstancia(string connStr)
        //{
        //    if (instancia == null)
        //    {
        //        instancia = new SqlHelper(connStr);
        //    }
        //    return instancia;
        //}
        //#endregion


        public bool comprobarConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConnectionString);
                conexion.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }

      
        public bool ExecuteQuery(string storedProcedure, SqlParameter[]parameters)//con
        {
            using( SqlConnection conexion = new SqlConnection(ConnectionString))
            {
                    using( SqlCommand comm= new SqlCommand())
                {
                    comm.Connection = conexion;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = storedProcedure;
                    comm.Parameters.AddRange(parameters);
                    conexion.Open();
                    return comm.ExecuteNonQuery() > 0;
                }
            }
        }


        public int ExecuteQueryPRUEBA(string storedProcedure, SqlParameter[]parameters)//con
        {
            using(SqlConnection conexion= new SqlConnection(ConnectionString))
            {
                using(SqlCommand comm= new SqlCommand())
                {
                    comm.Connection = conexion;
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.CommandText = storedProcedure;
                    comm.Parameters.AddRange(parameters);
                    conexion.Open();


                    int a = (Int32)comm.ExecuteScalar();
                    //int a = comm.ExecuteScalar();
                    return a;
                }
            }
        }



        public string ExecuteQueryString( string storedPrcedure, SqlParameter[]parameters)//con
        {
            using(SqlConnection conexion= new SqlConnection(ConnectionString))
            {
                using ( SqlCommand comm= new SqlCommand())
                {
                    comm.Connection = conexion;
                    comm.CommandType= CommandType.StoredProcedure;
                    comm.CommandText = storedPrcedure;
                    comm.Parameters.AddRange(parameters);
                    conexion.Open();


                    string a = (string)comm.ExecuteScalar();
                    return a;

                }
            }
        }


        public int ExecuteQueryPRUEBA(string qwery)// con
        {
            using( SqlConnection conexion = new SqlConnection(ConnectionString))
            {
                using ( SqlCommand comm= new SqlCommand())
                {
                    comm.Connection = conexion;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = qwery;
                    conexion.Open();

                    return (Int32)comm.ExecuteScalar();

                }
            }
        }



        public bool ExecuteQuery( string qwery)// con
        {
            using(SqlConnection conexion= new SqlConnection (ConnectionString))
            {
                using( SqlCommand comm= new SqlCommand())
                {
                    comm.Connection = conexion;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = qwery;
                    conexion.Open();

                    return comm.ExecuteNonQuery() > 0;
                }
            }
        }


        public DataTable ExecuteReader(string storedProcedure, SqlParameter[]parameters=null)//desc
        {
            using(SqlConnection conexion= new SqlConnection(ConnectionString))
            
                using(SqlCommand comm = new SqlCommand())
                {
                comm.Connection = conexion;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = storedProcedure;
                if(parameters!= null)
                {
                    comm.Parameters.AddRange(parameters);
                }
                conexion.Open ();
                SqlDataReader reader = comm.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                return data;

                }                
            
        }


        public DataTable ExecuteReader( string qwery)
        {
            using (SqlConnection conexion= new SqlConnection(ConnectionString))
                using( SqlCommand comm= new SqlCommand())
            {
                comm.Connection = conexion;
                comm.CommandType = CommandType.Text;
                comm.CommandText = qwery;
                conexion.Open();
                SqlDataReader reader = comm.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(reader);
                return data;
            }
        }

        public DataSet ExecuteDataSet(string CommandText)
        {
            using (SqlConnection conexion = new SqlConnection(ConnectionString))
            {
                try
                {
                    SqlDataAdapter Adapter = new SqlDataAdapter(CommandText, conexion);
                    DataSet ds = new DataSet();
                    Adapter.Fill(ds);
                    return (ds);

            }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    if(conexion.State != ConnectionState.Closed)
                        conexion.Close();
                }
            }
          
        }


        public int ExecuteNonQuery(string CommandText) 
        {
            try
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    SqlCommand comm = new SqlCommand(CommandText, conexion);
                    comm.Transaction = transaccion;
                    int resp=comm.ExecuteNonQuery();
                    transaccion.Commit();
                    return resp;
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
                throw;
            }
            finally
            {
                if(conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
        }

      


    }
}

