// Episodio ep1 = new(1, "Técnicas de facilitação", 45);
// ep1.AdicionarConvidados("Alice");
// ep1.AdicionarConvidados("Bob");
// ep1.AdicionarConvidados("Charlie");

// Episodio ep2 = new(2, "Entrevista com especialista", 60);
// ep2.AdicionarConvidados("David");
// ep2.AdicionarConvidados("Eva");

// Podcast podcast = new("Tech Talks", "John Doe");
// podcast.AdicionarEpisodio(ep1);
// podcast.AdicionarEpisodio(ep2);
// podcast.ExibirDetalhes();
// Screen Sound
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound!";

// List<string> listaDasBandas = new List<string> {"Linkin Park", "Imagine Dragons", "Coldplay"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 8 });
bandasRegistradas.Add("Imagine Dragons", new List<int>());

void exibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\n" + mensagemDeBoasVindas);
}

void exibirOpcoesDoMenu()
{
    exibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para mostrar a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            registrarBandas();
            break;
        case 2:
            mostrarBandasRegistradas();
            break;
        case 3:
            avaliarUmaBanda();
            break;
        case 4:
            mostrarMediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void registrarBandas()
{
    Console.Clear();
    exibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirOpcoesDoMenu();
}

void mostrarBandasRegistradas()
{
    Console.Clear();
    exibirTituloDaOpcao("Exibindo todas as bandas registradas");
    // for (int i = 0; i < listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    exibirOpcoesDoMenu();
}

void exibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void avaliarUmaBanda()
{
    Console.Clear();
    exibirTituloDaOpcao("Avaliar uma banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a sua nota para a banda {nomeDaBanda}? ");
        string notaDigitada = Console.ReadLine()!;
        int notaNumerica = int.Parse(notaDigitada);
        bandasRegistradas[nomeDaBanda].Add(notaNumerica);
        Console.WriteLine($"\nA nota {notaNumerica} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(2000);
        Console.Clear();
        exibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesDoMenu();
    }
}

void mostrarMediaDaBanda()
{
    Console.Clear();
    exibirTituloDaOpcao("Média da banda");
    Console.Write("Digite o nome da banda que deseja ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        double media = notasDaBanda.Average();
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {media:N1}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal...");
        Console.ReadKey();
        Console.Clear();
        exibirOpcoesDoMenu();
    }
}

exibirOpcoesDoMenu();