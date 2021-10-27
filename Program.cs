using System;

namespace LocadoraDeVeiculo
{
    class Program
    {
        static Garagem garagemV = new Garagem();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario(); 

            while (opcaoUsuario.ToUpper() !="x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    ListarVeiculo();
                    break;
                    case "2":
                    InserirVeiculo();
                    break;
                    case "3":
                    AtualizaVeiculo();
                    break;
                    case "4":
                    ExcluirVeiculo();
                    break;                                
                    case "c":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.ReadLine();

        }    
            private static void ExcluirVeiculo()
        {
            Console.Write("Digite o Id do Veiculo: ");
            int indiceVeiculo = int.Parse(Console.ReadLine());

            garagemV.Exclui(indiceVeiculo);
        }
       

           private static void AtualizaVeiculo()
        {
            Console.Write("Digite o id do Veiculo: ");
            int indiceVeiculo = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Marca)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Marca), i));
            }
            Console.Write("Digite o Marca entre as opções acima: ");
            int entradaMarca = int.Parse(Console.ReadLine());

            Console.Write("Digite a Modelo do Veiculo: ");
            string entradaModelo = Console.ReadLine();

            Console.Write("Digite o Ano do  do Veiculo: ");
            int entradaAno = int.Parse(Console.ReadLine());

            
            Console.Write("Digite a Placa do veiculo: ");
            string entradaPlaca = Console.ReadLine();

            Veiculo atualizaVeiculo = new Veiculo(id: indiceVeiculo,
                                        marca: (Marca)entradaMarca,
                                        modelo: entradaModelo,
                                        ano: entradaAno,
                                        placa: entradaPlaca);
            garagemV.Atualiza(indiceVeiculo, atualizaVeiculo);


        }

        private static void ListarVeiculo()
        {
            Console.WriteLine("Listar Veiculo");
            var lista = garagemV.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Veiculo cadastrado");
                return;
            }
            foreach (var Veiculo in lista)
            {
                var excluido = Veiculo.retornaExcluido();
               
                Console.WriteLine("#ID {0}: Placa {1} - Modelo {2} - Ano {3} - {4}", Veiculo.retornaId(), Veiculo.retornaPlaca(), Veiculo.retornaModelo(), Veiculo.retornaAno(), (excluido ? "Excluido" : ""));
            }
        }

        private static void InserirVeiculo()
        {
            Console.WriteLine("Inserir novo Veiculo");

            foreach (int i in Enum.GetValues(typeof(Marca)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Marca), i));

            }
            Console.Write("Digite a Marca entre as opcções acima: ");
            int entradaMarca = int.Parse(Console.ReadLine());

            Console.Write("Digite a Modelo do Veiculo: ");
            string entradaModelo = Console.ReadLine();

            Console.Write("Digite o Ano do Veiculo: ");
            int entradaAno = int.Parse(Console.ReadLine());

            
            Console.Write("Digite a Placa do Veiculo: ");
            string entradaPlaca = Console.ReadLine();

            Veiculo novoVeiculo = new Veiculo(id: garagemV.ProximoId(),
                                        marca: (Marca)entradaMarca,
                                        modelo: entradaModelo,
                                        ano: entradaAno,
                                        placa: entradaPlaca);
            garagemV.Insere(novoVeiculo);
        }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("LyonsS Locação a seu Dispor!!");
            Console.WriteLine();
            Console.WriteLine("Informe a opcção desejada:");
            Console.WriteLine();
            Console.WriteLine("1- Lista Veiculos");
            Console.WriteLine("2- Inserir Novo Veiculo");
            Console.WriteLine("3- Atualizar Veiculos");
            Console.WriteLine("4- Excluir Veiculo");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;  
        }
        
    }
}
