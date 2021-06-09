using System.Collections.Generic;

namespace Utilidades.Interfaces
{
    public interface ICrud<E>
    {
        bool guardar(E e);
        bool eliminar(E e);
        bool modificar(E e);
        IEnumerable<E> obtenerTodo(E e);
        E obtenerPorId(E e);
    }
}
