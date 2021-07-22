using System.Collections.Generic;

namespace cadastroSeries.NET.Interfaces
{
    public interface iRepositorio<T>
    {
        List<T> Lista();
        T RetornaId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}