using System;
using System.Collections.Generic;
using LocadoraDeVeiculo.Interfaces;


namespace LocadoraDeVeiculo
{
    public class Garagem : IGaragem<Veiculo>
    {
        private List<Veiculo> listaVeiculo = new List<Veiculo>();
        public void Atualiza(int id, Veiculo objeto)
        {
            listaVeiculo[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaVeiculo[id].Excluir();
        }

        public void Insere(Veiculo objeto)
        {
            listaVeiculo.Add(objeto);
        }

        public List<Veiculo> Lista()
        {
            return listaVeiculo;
        }

        public int ProximoId()
        {
            return listaVeiculo.Count;
        }

        public Veiculo RetornaPOrId(int id)
        {
            return listaVeiculo[id];
        }
    }
}