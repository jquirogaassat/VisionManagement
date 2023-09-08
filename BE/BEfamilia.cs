using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEfamilia : BEcomponente
    {


        //public BEfamilia(string nombrePermiso, string tipo) : base(nombrePermiso)
        //{
        //    esFamilia = true;
        //    tipoFamilia = tipo;
        //}

        private IList<BEcomponente> _hijos;
        public BEfamilia()
        {
            _hijos= new List<BEcomponente>();
        }

        public override IList<BEcomponente> Hijos
        {
            get
            {
                return _hijos.ToArray();
            }
        }

        public override void AgregarHijo(BEcomponente c)
        {
            _hijos.Add(c);
        }

        public override void VaciarHijos()
        {
            _hijos = new List<BEcomponente>();
        }
    }
}
