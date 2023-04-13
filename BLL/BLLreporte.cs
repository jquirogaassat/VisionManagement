using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLreporte
    {
        public int Alta(BE.BEreporte reporte)
        {
            DAL.DALreporte reporteDAL = new DAL.DALreporte();
            return reporteDAL.Alta(reporte);
        }
    }