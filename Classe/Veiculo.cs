using System;

namespace LocadoraDeVeiculo
{
    public class Veiculo : Base
    {
        
        private Marca Marca {get; set;}
        private string Modelo {get; set;}
        private string Placa {get; set;}
        private int Ano {get; set;}  
        private bool Excluido { get; set;}

        public Veiculo(int id, Marca marca, string placa, string modelo, int ano)
        {
            this.Id = id;
            this.Marca = marca;
            this.Placa = placa;
            this.Modelo = modelo;            
            this.Ano =  ano;
            this.Excluido = false;

        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Placa"  + this.Placa + Environment.NewLine;
            retorno += "Modelo"  + this.Modelo + Environment.NewLine;
            retorno += "Ano Marca"  + this.Ano + Environment.NewLine;
            retorno += "Excluido"  + this.Excluido;
            return retorno;
        }
        

        public string retornaPlaca()
        {
            return this.Placa;
        }

          public string retornaModelo()
        {
            return this.Modelo;
        }

         public int retornaAno()
        {
            return this.Ano;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}