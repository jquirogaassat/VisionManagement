﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionTFI
{
    public static class Globa
    {

        public static List<string> tiposDoc = new List<string>();
        public static List<string> nivelCriticidad= new List<string>(); 
        public static MenuPrincipal menuPrincipal = new MenuPrincipal();
        public static BE.BEarticulo articuloBE= new BE.BEarticulo();
        public static BE.BEcliente cllienteBE= new BE.BEcliente();  
        public static BE.BEherramientas herramientaBE = new BE.BEherramientas();
        public static BE.BEprestamo prestamoBe= new BE.BEprestamo();
        public static string motivoLoginFallido;
        public static ABMusuarios abmUsuarioAlta;
        public static AdministrarUsers administrarUsers = new AdministrarUsers();
        public static GestionarUsuarios gestionarUsuarios = new GestionarUsuarios();
        public static BE.BEusuario usuarioBE = new BE.BEusuario();
        public static BE.BEpermiso permisoBE;
        public static string tipoProceso = null;        
        public static IniciarSesion IniciarSesion = new IniciarSesion();
        public static BE.BEbackup backupBE = new BE.BEbackup();
        public static List<BE.BEerror> errores = new List<BE.BEerror>();
        public static Backup Backup = new Backup();
        public static ABMcliente ABMcliente = new ABMcliente();
        public static GestionarSocio GestionarCliente = new GestionarSocio();// cliente
        public static ABMarticulos ABMarticulos = new ABMarticulos();
        public static GestionarArticulo GestionarArticulo = new GestionarArticulo();
        public static GestionarHerramientsa GestionarHerramienta = new GestionarHerramientsa();
        public static Restore restore = new Restore();
        public static Reporte reporte;
        public static CambiarContraseña cambiarPass = new CambiarContraseña();
        public static AdministrarPrestamos administrarPrestamos = new AdministrarPrestamos();
        public static FrmPrimerosPasos primeros= new FrmPrimerosPasos();

            

    }
}
