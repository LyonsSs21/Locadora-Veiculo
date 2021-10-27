using System.Collections.Generic;

namespace LocadoraDeVeiculo.Interfaces
{
    public interface IGaragem<T>
    {
         List<T> Lista();
         T RetornaPOrId(int id);
         void Insere (T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);

         int ProximoId();
    }
}