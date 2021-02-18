using System.Collections.Generic;

namespace DIO.Series.Interface
{
    public interface IRepository<T>
    {
         List<T> Lista();
         T RertornaPorId(int id);
         void Insere(T entidade);
         void Excluir(int id);
         void Atualizar(int id, T entidade);
         int ProximoId();
    }
}