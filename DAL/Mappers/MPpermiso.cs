using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public class MPpermiso
    {
        public BE.BEpermiso Map(DataRow row)
        {
            BE.BEpermiso permisoBE;
            
            if((string)row[2]=="S")
            {
                permisoBE = new BE.BEfamilia((string)row[1], (string)row[3]);
            }
            else
            {
                {
                    permisoBE = new BE.BEpatente(row[1].ToString());
                }
            }
            permisoBE.idPermiso = (int)row[0];
            return permisoBE; 
        }
    }
}
