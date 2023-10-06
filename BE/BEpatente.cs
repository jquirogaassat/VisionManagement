using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEpatente : BEcomponente
    {
        // oficia de archivo en el ejemplo de youtube
        public override IList<BEcomponente> Hijos
        {
            get
            {
                return new List<BEcomponente>();
            }
        }
        public override void AgregarHijo(BEcomponente c)
        {
            
        }

        public override void VaciarHijos()
        {
            
        }
    }
}
