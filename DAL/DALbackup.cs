using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Configuration;

namespace DAL
{
    public class DALbackup : BE.ICRUd<BE.BEbackup>
    {
        #region singleton
        //private DALbackup()
        //{

        //}

        //private static DALbackup instancia;

        //public static DALbackup GetInstancia()
        //{
        //    if (instancia == null)
        //    {
        //        instancia = new DALbackup();
        //    }
        //    return instancia;
        //}

  
        #endregion


        SqlHelper sqlHelper = new SqlHelper();
        string qwery;
        public bool Alta(BEbackup itemAlta)
        {
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("idUsuario",itemAlta.Usuario.IdUsuario),
                new SqlParameter("nombre",itemAlta.Nombre),
                new SqlParameter("fechaAlta",itemAlta.FechaAlta),
                new SqlParameter("particiones",itemAlta.Particiones),
                new SqlParameter("ubicacion",itemAlta.Ubicacion),
            };
            return sqlHelper.ExecuteQuery("backupInsert", parametros);
        }

        public bool Baja(BEbackup itemBaja)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(BEbackup itemModifica)
        {
            throw new NotImplementedException();
        }

        public IList<BEbackup> Listar()
        {
            throw new NotImplementedException();
        }

        public List<BE.BEbackup> Consulta()
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parameters = new SqlParameter[] { };
            DataTable dt = sqlHelper.ExecuteReader("backupSelect", parameters);
            List<BEbackup> backups = new List<BEbackup>();
            Mappers.MPbackup mapper = new Mappers.MPbackup();
            foreach (DataRow row in dt.Rows)
            {
                backups.Add(mapper.Map(row));
            }
            return backups;
        }


        //genero la ruta para la copia
        public void Copiar (string srcFilePath1, string pathDestino)
        {
            string dstFilePath1= Path.Combine(pathDestino, Path.GetFileName(srcFilePath1));
            Directory.CreateDirectory(pathDestino);
            File.Copy(srcFilePath1, dstFilePath1, overwrite: false);
        }


        public void ValorizarEntidad(int particiones, string pathDestino, BE.BEbackup bEbackup)
        {
            DateTime dateTime = DateTime.Now;
            int dia = dateTime.Day;
            int mes = dateTime.Month;
            int anio = dateTime.Year;
            int minuto = dateTime.Minute;
            int segundo = dateTime.Second;
            int hora = dateTime.Hour;
            string fechaHora = dia + " " + mes + " " + anio + " " + hora + " " + minuto + " " + segundo;

            bEbackup.Usuario = BE.BEcontroladorsesion.GetInstance.Usuario;
            bEbackup.Nombre = fechaHora;
            bEbackup.FechaAlta = dateTime;
            bEbackup.Particiones = particiones;
            bEbackup.Ubicacion = pathDestino;
            bEbackup.Nombre = @"VisionManagement_" + fechaHora;
        }



        public void CopiarEnDestino(string pathDestino, BE.BEbackup bEbackup)
        {
            int parte = 1;
            string pathOrigen = "";
            while(parte < bEbackup.Particiones +1)
            {
                pathOrigen = @"C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\" + bEbackup.Nombre + @"_" + parte + @".bak";
                Copiar(pathOrigen, pathDestino);
                parte++;
            }

        }



        public bool GenerarBackup (BE.BEbackup backupBE)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
            SqlConnection conexion = new SqlConnection(ConnectionString);

            if (sqlHelper.comprobarConexion())
            {
                string bd = conexion.Database;
                int parte = 1;
                qwery = @"BACKUP DATABASE " + bd + " ";

                if (backupBE.Particiones == 1)
                {
                    qwery = qwery + @"TO DISK= '" + backupBE.Ubicacion + backupBE.Nombre  + @".bak'";
                }
                else
                {
                    while (parte < (backupBE.Particiones + 1))
                    {
                        if (parte == 1)
                        {
                            qwery = qwery + @"TO DISK = '" + backupBE.Ubicacion + backupBE.Nombre + "_" + parte + @".bak'";
                        }
                        else
                        {
                            qwery = qwery + @", DISK= '" + backupBE.Ubicacion + backupBE.Nombre + "_" + parte + @".bak'";
                        }
                        parte++;
                    }
                }

                sqlHelper.ExecuteQuery(qwery);
                Alta(backupBE);
                return true;
            }
            else
            {
                return false;
            }

            
            

           
        }



        public string Restore( BE.BEbackup bEbackup)
        {
            int parte = 1;
            qwery = @"use master ; ALTER DATABASAE VisionManagement SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE VisionManagement ";

            if(bEbackup.Particiones==1)
            {
                qwery = qwery + @"FROM DISK = '" + bEbackup.Ubicacion + bEbackup.Nombre + @".bak";
            }
            else
            {
                while(parte < (bEbackup.Particiones + 1))
                {
                    if(parte == 1)
                    {
                        qwery = qwery + @"FROM DISK= '" + bEbackup.Ubicacion + bEbackup.Nombre +"_" + parte + @".bak";
                    }
                    else
                    {
                        qwery = qwery + @",DISK ='" + bEbackup.Ubicacion + bEbackup.Nombre + "_" + parte + @".bak";
                    }
                    parte++;
                }
            }

            sqlHelper.ExecuteQuery(qwery);
            return qwery;
        }

        List<BEbackup> ICRUd<BEbackup>.Listar()
        {
            throw new NotImplementedException();
        }

        public IList<BEbackup> Lista()
        {
            throw new NotImplementedException();
        }
    }
}
