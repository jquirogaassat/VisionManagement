using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLpermiso 
    {
        PermisosRepository _permisos;
       
        public BLLpermiso()  
        {
            _permisos = new PermisosRepository();
        }//ok
      
        public bool Existe (BEcomponente c, int id)
        {
            bool existe = false;
            if(c.Id.Equals(id))
                existe = true;
            else

            foreach(var item in c.Hijos)
                {
                    existe=Existe(item,id);
                    if(existe) return true;
                }
            return existe;
        }//ok


        public Array GetAllPermission()
        {
            return _permisos.GetAllPermission();
        }//ok

        public BEcomponente GuardarComponente(BEcomponente p, bool esFamilia)
        {
            return _permisos.GuardarComponente(p, esFamilia);
        }//ok
       
        public void GuardarFamilia(BEfamilia f)
        {
            _permisos.GuardarFamilia(f);
        }//ok

        public IList<BEfamilia> GetAllFamilias()
        {
            return _permisos.GetAllFamilias();
        }//ok

        public IList<BEcomponente> GetAll(string familia)
        {
            return _permisos.GetAll(familia);
        }//ok

        public void FillUserComponents(BEusuario u)
        {
            _permisos.FillUserComponents(u);
        }//ok

        public void FillFamilyComponents(BEfamilia f)
        {
            _permisos.FillFamilyComponents(f);
        }//ok

        public IList<BEpatente> GetAllPatentes()
        {
            return _permisos.GetAllPatentes();
        }//ok
      
        

      

       




    }
}
