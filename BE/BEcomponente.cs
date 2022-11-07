using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEcomponente
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

        public abstract IList<BEcomponente> Hijos { get; }

        public abstract void AgregarHijo(BEcomponente c);

        public abstract void VaciarHijos();
        public BEtipoPermiso Permiso { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
