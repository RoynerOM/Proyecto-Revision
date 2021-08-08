using System.Collections.Generic;
using System.Threading.Tasks;

namespace Utilidades.Interfaces
{
    public interface ICrud<E>
    {
        bool guardarAsync(E e);
        bool eliminar(E e);
        bool modificar(E e);

        Task<List<E>> obtenerTodo();

        E obtenerPorId(E e);
    }
}
