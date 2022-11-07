using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public interface ICRUD<T>
    {
        bool Alta(T item);

        bool Baja(T item);

        bool Modificar(T item);

        IList<T> Listar(T item);
    }
}
