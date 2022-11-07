using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class SqlHelper
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        public SqlHelper()
        {

        }
        private SqlConnection connection;
        private DataSet DataSet;
        private SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private DataTable dt;


       
        public string connectionString { get; private set; }

        #region Singleton
        private SqlHelper(string connStr)
        {
            this.connectionString = connStr;
        }

        private static SqlHelper instancia;

        public static SqlHelper getInstancia(string connStr)
        {
            if (instancia == null)
            {
                instancia = new SqlHelper(connStr);
            }
            return instancia;
        }
        #endregion


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

        #region Executequery
        public bool ExecuteQuery(string query)
        {
            bool returnValue = false;

            try
            {
                using (connection = new SqlConnection(this.connectionString))
                {
                    using (command = new SqlCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = query;
                        command.Connection = connection;

                        connection.Open();

                        if (command.ExecuteNonQuery() > 0)
                        {
                            returnValue = true;
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return returnValue;
        }
        #endregion

        public bool ExecuteQuery(string storedProcedure, SqlParameter[] parameters) //CONECTADO
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }



        }


        #region ExecuteQuery storeprocedure and list
        public bool ExecuteQuery(string storeprocedure, List<SqlParameter> parametros)
        {
            bool returnValue = false;

            try
            {
                using (connection = new SqlConnection(this.connectionString))
                {
                    using (command = new SqlCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = storeprocedure;
                        command.Connection = connection;

                        if (parametros != null)
                        {
                            foreach (SqlParameter parameter in parametros)
                            {
                                command.Parameters.Add(parametros);
                            }
                        }
                        connection.Open();

                        if (command.ExecuteNonQuery() > 0)
                        {
                            returnValue = true;
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }
        #endregion

        #region ExecuteQuery storeProcedure, List sqlparameter and params parametros array
        public bool ExecuteQuery(string storeprocedure, List<SqlParameter> parametros, params SqlParameter[] parametrosArray)
        {
            bool returnValue = false;

            try
            {
                using (connection = new SqlConnection(this.connectionString))
                {
                    using (command = new SqlCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = storeprocedure;
                        command.Connection = connection;

                        if (parametros != null)
                        {
                            foreach (SqlParameter parameter in parametros)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }

                        if (parametrosArray != null)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddRange(parametrosArray);
                        }

                        connection.Open();

                        if (command.ExecuteNonQuery() > 0)
                        {
                            returnValue = true;
                        }
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnValue;
        }

        #endregion

        public int ExecuteQueryPRUEBA(string storedProcedure, SqlParameter[] parameters) //CONECTADO
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    command.Parameters.AddRange(parameters);
                    connection.Open();

                    int a = (Int32)(command.ExecuteScalar());
                    return a;
                }
            }
        }

        public int ExecuteQueryPRUEBA(string qwery) //CONECTADO
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = qwery;
                    connection.Open();

                    return (Int32)command.ExecuteScalar();
                }
            }
        }

        public DataTable ExecuteReader(string query)
        {
            DataSet = new DataSet();

            using (connection = new SqlConnection(this.connectionString))
            {
                using (command = new SqlCommand())
                {
                    adapter = new SqlDataAdapter();

                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Connection = connection;

                    adapter.SelectCommand = command;
                    adapter.Fill(DataSet);
                }
            }
            return DataSet.Tables[0];
        }

        public DataTable ExecuteReader(string storePrecedure, List<SqlParameter> parametros)
        {
            DataSet = new DataSet();

            using (connection = new SqlConnection(this.connectionString))
            {
                using (command = new SqlCommand())
                {
                    adapter = new SqlDataAdapter();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storePrecedure;
                    command.Connection = connection;

                    if (parametros != null)
                    {
                        command.Parameters.AddRange(parametros.ToArray());
                    }
                    adapter.SelectCommand = command;
                    adapter.Fill(DataSet);

                }
                return DataSet.Tables[0];
            }



        }

        public DataTable ExecuteReader(string storePrecedure, List<SqlParameter> parametros, params SqlParameter[] paramSqlparametros)
        {
            DataSet = new DataSet();

            using (connection = new SqlConnection(this.connectionString))
            {
                using (command = new SqlCommand())
                {
                    adapter = new SqlDataAdapter();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storePrecedure;
                    command.Connection = connection;

                    if (parametros != null)
                    {
                        command.Parameters.AddRange(parametros.ToArray());
                    }

                    if (paramSqlparametros != null)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddRange(paramSqlparametros);
                    }
                    adapter.SelectCommand = command;
                    adapter.Fill(DataSet);
                }
            }
            return DataSet.Tables[0];
        }



        public DataTable ExecuteReader(string storePrecedure, SqlParameter[] parameters=null)
        {
            using(SqlConnection connection= new SqlConnection(this.connectionString))
                using(SqlCommand command= new SqlCommand())
            {
                command.Connection= connection;
                command.CommandType=CommandType.StoredProcedure;
                command.CommandText = storePrecedure;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;

            }
        }

    }
}

