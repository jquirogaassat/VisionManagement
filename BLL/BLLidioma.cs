using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLidioma 
    {
        DAL.DALidioma DALidioma = new DAL.DALidioma();
        

        public List<BE.BEidioma> Consulta()
        {
            return DALidioma.Consultar();
        }
        

        public string Traducir(BE.BEidioma idioma, string cadena )
        {
            List<BE.BEtraduccion> traducciones = DALidioma.Traducciones();
            string traduccion = "";
            int a = 0;


            while (traduccion==""&& a<traducciones.Count)
            {
                if (traducciones[a].Cadena==cadena)
                {
                    traduccion = traducciones.Where(tr => tr.IdCadena == traducciones[a].IdCadena && tr.IdIdioma == idioma.IdIdioma).First().Cadena;
                }
                else
                {
                    a++;
                }
            }

            if(traduccion=="")
            {
                traduccion = "Falta traducción";
            }
            return traduccion;
        }

        public BE.BEidioma ConsultarIdioma(int id)
        {
            DAL.DALidioma idioma = new DAL.DALidioma();
            return idioma.ConsultarIdioma(id);
        }
     
    }
}
