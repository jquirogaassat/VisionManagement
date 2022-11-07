using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEusuario :IUser
    {
        //public BEusuario()
        //{
        //    _permisos = new List<BEcomponente>();
        //}

        //List<BEcomponente> _permisos;

        //public List<BEcomponente> Permisos
        //{
        //    get { return _permisos; }
        //}

        public int IdUsuario { get; set; }

        private BEidioma _idioma;
        public BEidioma Idioma
        {
            get
            {
                return _idioma;
            }
            set 
            {
                _idioma= value;
                this.Notificar();
            }
        }

        public string usuario { get; set; }
        public string UserPass { get; set; }
        public bool IsBlocked { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string  UserName { get; set; }
        public DateTime FechaAlta { get; set; }
        public int intentosFallidos { get; set; }
        public int DVH { get; set; }
        public List<BEpermiso> Permisos { get; set; }
       
        
       // public BEidioma Idioma { get; set; }
       

       


        private List<IObserverForm> _formularios;

        public BEusuario()
        {
            _formularios = new List<IObserverForm>();
        }


        public void Agregar (IObserverForm form)
        {
            if (!_formularios.Contains(form))
            {
                _formularios.Add(form);
            }
            else
            {
                throw new Exception($"Ya existe una suscripción para {((string)usuario)}");
            }
        }

        public void Notificar()
        {
            foreach(var form in _formularios)
            {
                form.Actualizar(this);
            }
        }


        public void Quitar(IObserverForm form)
        {
            if (_formularios.Contains(form))
            {
                _formularios.Remove(form);
            }
            else
            {
                throw new Exception($"No existe una suscripción para {((string)usuario)}");
            }
        }
    }
}
