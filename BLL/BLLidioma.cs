using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BLL
{
    public static class BLLidioma 
    {
        //public static Dictionary<string, string> info = new Dictionary<string, string>();

        //public static void Cargar(string archivo)
        //{
        //    foreach (string linea in File.ReadLines("lang//" + archivo))
        //    {
        //        info.Clear();
        //        if (linea.Contains("="))
        //        {
        //            string[] parts = linea.Split(new char[] { '='});
        //            info.Add(parts[0], parts[1]);
        //        }
        //    }
        //}
        //public static void CambiarIdioma(string archivo)
        //{
        //    Properties.Settings config = new Properties.Settings();
        //    config.lang = archivo;
        //    config.Save();
        //    Cargar(archivo);
        //}

        //public static void controles(Form f)
        //{
        //    foreach( string control in info.Keys)
        //    {
        //        try
        //        {
        //            f.Controls[control].Text = info[control];
        //        }
        //        catch (Exception e)
        //        {
                   
                  
        //        }
                
        //    }

        //}


        //DAL.DALidioma DALidioma = new DAL.DALidioma();
        

        //public List<BE.BEidioma> Consulta()
        //{
        //    return DALidioma.Consultar();
        //}
        

        //public string Traducir(BE.BEidioma idioma, string cadena )
        //{
        //    List<BE.BEtraduccion> traducciones = DALidioma.Traducciones();
        //    string traduccion = "";
        //    int a = 0;


        //    while (traduccion==""&& a<traducciones.Count)
        //    {
        //        if (traducciones[a].Cadena==cadena)
        //        {
        //            traduccion = traducciones.Where(tr => tr.IdCadena == traducciones[a].IdCadena && tr.IdIdioma == idioma.IdIdioma).First().Cadena;
        //        }
        //        else
        //        {
        //            a++;
        //        }
        //    }

        //    if(traduccion=="")
        //    {
        //        traduccion = "Falta traducción";
        //    }
        //    return traduccion;
        //}

        //public BE.BEidioma ConsultarIdioma(int id)
        //{
        //    DAL.DALidioma idioma = new DAL.DALidioma();
        //    return idioma.ConsultarIdioma(id);
        //}
     
    }
}
