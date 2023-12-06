using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEusuario :IUser
    {
        public int IdUsuario { get; set; }
        public string usuario { get; set; }
        public string UserPass { get; set; }
        public string IsBlocked { get; set; }
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



        // public BEidioma Idioma { get; set; }
        private BEidioma _idioma;
        public BEidioma Idioma
        {
            get
            {
                return _idioma;
            }
            set
            {
                _idioma = value;
                this.Notificar();
            }
        }

        public string ApellidoNombre
        {
            get { return Apellido +","+ Nombre; }
        }




        private List<IObserverForm> _formularios;
        List<BEcomponente> _permsios;

        public BEusuario()
        {
            _formularios = new List<IObserverForm>();
            _permsios = new List<BEcomponente>();
        }

        public List<BEcomponente> Permisos
        {
            get { return _permsios; }
        }

        public override string ToString()
        {
            return Nombre;
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
