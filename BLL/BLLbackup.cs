using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace BLL
{
    public class BLLbackup : BE.ICRUd<BE.BEbackup>
    {

        DAL.DALbackup DALbackup = new DAL.DALbackup();
        public bool Alta(BEbackup itemAlta)
        {
            throw new NotImplementedException();
        }

        public bool Baja(BEbackup itemBaja)
        {
            throw new NotImplementedException();
        }

        public IList<BEbackup> Listar()
        {
            throw new NotImplementedException();
            
        }

        public List<BE.BEbackup> Consulta()
        {
            DAL.DALbackup dALbackup = new DAL.DALbackup();
            return dALbackup.Consulta();
        }

        public bool Modificar(BEbackup itemModifica)
        {
            throw new NotImplementedException();
        }


        public void Comprimir (string pathDestino)
        {
            var outFileName = Path.GetFileNameWithoutExtension("VisionManagement") + ".zip";
            var fileNameToAdd = Path.Combine(@"" + pathDestino, "VisionManagement.bak");
            var zipFileName = Path.Combine("@" + pathDestino, outFileName);

            using (ZipArchive archivo = ZipFile.Open(zipFileName, ZipArchiveMode.Create))
            {
                archivo.CreateEntryFromFile(fileNameToAdd, Path.GetFileName(fileNameToAdd));
            }
        }



        public bool GenerarBackup(BE.BEbackup backupBE)
        {
            return DALbackup.GenerarBackup(backupBE);
        }

        public string Restore(BE.BEbackup bEbackup)
        {
            return DALbackup.Restore(bEbackup);
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
