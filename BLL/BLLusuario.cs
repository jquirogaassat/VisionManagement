using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace BLL
{
    public class BLLusuario : BE.ICRUd<BE.BEusuario>
    {

        BLL.BLLencriptacion encriptadora = new BLLencriptacion();
        DAL.DALusuario usuarioDAL = new DAL.DALusuario();
        DAL.DALpermiso permisoDAL = new DAL.DALpermiso();
        DAL.UsuarioRepository _usuarios= new DAL.UsuarioRepository();
        public bool Alta(BEusuario itemAlta)
        {
            return usuarioDAL.Alta(itemAlta);
        }

        public bool Baja(BEusuario itemBaja)
        {
            return usuarioDAL.Baja(itemBaja);
        }

        public IList<BEusuario> Listar()
        {
            return usuarioDAL.Listar();
            //throw new NotImplementedException();
        }

        public void GuardarPermisos(BEusuario u)
        {
            _usuarios.GuardarPermisos(u);
        }

        public List<BEusuario> GetAll()
        {
            return _usuarios.GetAll();
        }
        public List<BE.BEusuario> Consulta()
        {
            List<BEusuario> usuarios = new List<BEusuario> ();
            usuarios= usuarioDAL.Consulta();
            foreach (var u in usuarios)
            {
                u.usuario = encriptadora.desencriptarAes(u.usuario);
            }
            return usuarios;
        }

        public bool Modificar(BEusuario itemModifica)
        {
            return usuarioDAL.Modificar(itemModifica);
        }

        public bool DesbloquearUsuario(BEusuario itemDesbloquear)
        {
            return usuarioDAL.DesbloquearUsuario(itemDesbloquear);
        }

        public bool QuitarAsignaciones(BE.BEusuario bEusuario)
        {
            return usuarioDAL.quitarAsignaciones(bEusuario);    
        }


        public BE.BEreusltadoLog Login(BE.BEusuario bEusuario)
        {
            if(BE.BEcontroladorsesion.GetInstance==null)
            {
                BE.BEusuario usuarioRegistrado = ConsultarUsuario(bEusuario);

                if(usuarioRegistrado!=null)
                {
                    if(bEusuario.UserPass==usuarioRegistrado.UserPass)
                    {
                        usuarioRegistrado.intentosFallidos = 0;
                        usuarioDAL.Modificar(usuarioRegistrado);
                        return BE.BEcontroladorsesion.Log(usuarioRegistrado);
                    }
                    else
                    {
                        int intentos = ActualizarIntentos(usuarioRegistrado);

                        if(intentos==0)
                        {
                            return BE.BEreusltadoLog.RegeneracionPass;
                        }
                        else
                        {
                            return BE.BEreusltadoLog.PasswordIncorrecta;
                        }
                    }
                }
                else
                {
                    return BE.BEreusltadoLog.UsuarioInexistente;
                }
            }
            else
            {
                return BE.BEreusltadoLog.SesionActiva;
            }
        }


        public string GenerarPassword()
        {
            char[]chars=
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] bytes=new byte[10];
            using(RNGCryptoServiceProvider crypto= new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(bytes);
            }
            StringBuilder resultado= new StringBuilder(10);
            foreach(byte b in bytes)
            {
                resultado.Append(chars[b % (chars.Length)]);
            }
            return resultado.ToString();
        }


        public bool Logout(BE.BEusuario bEusuario)
        {
            return BE.BEcontroladorsesion.Logout();
        }

        public BE.BEusuario ConsultarUsuario(BE.BEusuario bEusuario)
        {
            return usuarioDAL.ConsultarUsuario(bEusuario);
        }

        public BE.BEusuario Encriptar(BE.BEusuario bEusuario)
        {
            BLLencriptacion encriptadora = new BLLencriptacion();
            bEusuario.usuario = encriptadora.encriptarAES(bEusuario.usuario);
            bEusuario.UserPass = encriptadora.encriptarSha256(bEusuario.UserPass);
            return bEusuario;
        }

        public BE.BEusuario Desencriptar (BE.BEusuario usuarioBe)
        {
            BLLencriptacion encriptadora = new BLLencriptacion();
            usuarioBe.usuario= encriptadora.desencriptarAes(usuarioBe.usuario);
            return usuarioBe;
        }

        public  int ActualizarIntentos(BE.BEusuario bEusuario)
        {
            BLL.BLLencriptacion encriptadora = new BLLencriptacion();

            if(bEusuario.intentosFallidos<3)
            {
                bEusuario.intentosFallidos = bEusuario.intentosFallidos + 1;
            }
            else
            {
                string password = GenerarPassword();

                string directorio = @"C:\Users\jair\Desktop";
                string nombreArchivo = "pass.txt";
                bool overWritting = true;
                bool salida = GuardarArchivo(directorio, nombreArchivo, password, overWritting);

                bEusuario.intentosFallidos = 0;
                BLL.BLLusuario bLLusuario= new BLLusuario();
                bEusuario.UserPass = encriptadora.encriptarSha256(password);
            }

            Modificar(bEusuario);
            return bEusuario.intentosFallidos;
        }

        


        public bool AsignacionDirecta(BE.BEusuario usuario, BE.BEpermiso permisoHijo)
        {
            return usuarioDAL.AsignacionDirecta(usuario,permisoHijo);
        }

     


        public void Asignar(BE.BEusuario usuario, BE.BEpermiso permiso)
        {
            usuarioDAL.Asignar(usuario, permiso);
        }
        public bool QuitarPermiso(BE.BEusuario usuario, BE.BEpermiso permiso)
        {
            return usuarioDAL.QuitarPermisos(usuario, permiso);
        }



        public bool GuardarArchivo(string path, string nombre, string contenido, bool sobrescribir)
        {
            string nom = path + "\\" + nombre;

            try
            {
                if(!File.Exists(nom)||(File.Exists(nom)&& sobrescribir))
                {
                    File.WriteAllText(nom, contenido);
                    return true;
                }
                else
                {
                    using(StreamWriter e= File.AppendText(nom))
                    {
                        e.WriteLine(contenido);
                        return true;
                    }
                }
            }
            catch 
            {

                return false;
            }

        }


        


        public List<BE.BEusuario> FamiliaMiembro( BE.BEpermiso permiso)
        {
            return usuarioDAL.FamiliaMiembros(permiso);
        }


        public List<BE.BEusuario> UsuariosNoPertenecientes (BE.BEpermiso p)
        {
            List<BE.BEusuario> userMiembro = FamiliaMiembro(p);
            List<BE.BEusuario> userTotal = usuarioDAL.Consulta();
            List<BE.BEusuario> userNoMiembro = new List<BEusuario>();

            foreach (BE.BEusuario user in userTotal)
            {
                if (!userMiembro.Exists(u => u.IdUsuario == user.IdUsuario))
                {
                    userNoMiembro.Add(user);
                }
            }

            return userNoMiembro;
        }

        List<BEusuario> ICRUd<BEusuario>.Listar()
        {
            throw new NotImplementedException();
        }

        public IList<BEusuario> Lista()
        {
            throw new NotImplementedException();
        }
    }
}
