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
                new SqlParameter("idUsuario",itemAlta.Usuario.idUsuario),
                new SqlParameter("nombre",itemAlta.Nombre),
                new SqlParameter("fechaCreacion",itemAlta.FechaAlta),
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



        public string GenerarBackup (int particiones, string pathDestino)
        {
            BE.BEbackup bEbackup = new BE.BEbackup();
            ValorizarEntidad(particiones, pathDestino, bEbackup);

            int parte = 1;
            qwery = @"BACKUP DATABASE VisionManagement";

            if(particiones==1)
            {
                qwery = qwery + @"TO DISK= '" + bEbackup.Ubicacion + bEbackup.Nombre + "_" + parte + @".bak";
            }
            else
            {
               while(parte< (bEbackup.Particiones +1))
                {
                    if(parte==1)
                    {
                        qwery = qwery + @"TO DISK = '" + bEbackup.Ubicacion + bEbackup.Nombre + "_" + parte + @".bak";
                    }
                    else
                    {
                        qwery = qwery + @", DISK= ' " + bEbackup.Ubicacion + bEbackup.Nombre + "_" + parte + @".bak";
                    }
                    parte++;
                }
            }

            sqlHelper.ExecuteQuery(qwery);
            Alta(bEbackup);
            return qwery;
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
    }
}
