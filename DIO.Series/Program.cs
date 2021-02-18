using System;
using DIO.Series.Classes;

namespace DIO.Series
{
    class Program
    {
        //Declaração
        static SerieRepository repositorio = new SerieRepository();
        //Opções
        static void Main(String[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario.ToUpper() != "x")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();                       
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços !");
            Console.WriteLine();
        }
        // Service ListarSeries
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.Write("#ID {0}: - {1} - {}", serie.retornaId(), serie.retornaTitulo(), (excluido? "Sucesso ao excluir série !" : "Falha ao excluir série !"));
            }
            Console.WriteLine();
        }

        // Service InserirSeries
        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o ID da série:");
            int indiceSerie = int.Parse(Console.ReadLine());

            // https://docs.microsoft.com/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/dotnet/api/system.enum.getname?view=netcore-3.1

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i , Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao
            );
            repositorio.Atualizar(indiceSerie, atualizaSerie);
        }

        //Service AtualizarSerie

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            // https://docs.microsoft.com/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/dotnet/api/system.enum.getname?view=netcore-3.1

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i , Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao
            );
            repositorio.Insere(novaSerie);
        }

        // Service ExcluirSerie

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(indiceSerie);
        }

        // Service VisualizarSerie
        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RertornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        //Program execute ...
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Qual séries você deseja assistir");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar nova série ");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
