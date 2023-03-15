using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ICRUd<T>
    {
        bool Alta(T itemAlta);

        bool Baja(T itemBaja);

        bool Modificar(T itemModifica);

        List<T> Listar();

        IList<T> Lista();
    }
}
