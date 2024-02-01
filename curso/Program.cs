using System.Runtime;
using System.Runtime.CompilerServices;

string boasVindas = "Boas Vindas ao App";
Dictionary<string, List<int>> listaBandas = new Dictionary<string, List<int>>();

void TextoInicial()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(boasVindas); 
}

void OpcoesMenu()
{
    Console.WriteLine("\n1 - Registrar uma banda");
    Console.WriteLine("2 - Consultar bandas registradas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir avalições de bandas");
    Console.WriteLine("5 - Sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoUsuario = Console.ReadLine()!;
    int opcaoUsuarioNum = int.Parse(opcaoUsuario);

    switch (opcaoUsuarioNum)
    {
        case 1:
            MenuRegistrar();
            break;
        case 2:
            BandasRegistradas();
            break;
        case 3:
            RegistroNotas();
            break;
        case 4:
            ConsultaNota();
            break;
        case 5:
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

TextoInicial();
OpcoesMenu();

void MenuRegistrar()
{
    Console.Clear();
    Console.WriteLine(@"

██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝  ██████╦╝███████║██╔██╗██║██║░░██║███████║
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝");

    Console.Write("\nDigite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda, new List<int>());

    Console.WriteLine($"\nBanda {nomeBanda} registrada com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    TextoInicial();
    OpcoesMenu();
}

void BandasRegistradas()
{
    Console.Clear();
    Console.WriteLine(@"

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░

██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░░█████╗░░██████╗
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██║░░██║███████║╚█████╗░
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██║░░██║██╔══██║░╚═══██╗
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██████╔╝██║░░██║██████╔╝
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░
");

        if (listaBandas.Keys.Count < 1)
        {
            Console.WriteLine("\nNenhuma banda registrada");
            Console.WriteLine("\nDigite qualquer tecla para voltar");
            Console.ReadKey();
            Console.Clear();
            TextoInicial();
            OpcoesMenu();
        } else { 

        
        foreach (string banda in listaBandas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        TextoInicial();
        OpcoesMenu();

    }
}

//Função que exibe no console uma linha de asteriscos de tamanho conforme o parametro que você fornecer à ela
void tituloAsterisco(string titulo)
{
    int tamanho = titulo.Length;
    string tituloCerto = string.Empty.PadLeft(titulo.Length, '*');
    Console.WriteLine(tituloCerto);
}

void RegistroNotas()
{
    string titulo = @"
░█████╗░██╗░░░██╗░█████╗░██╗░░░░░██╗░█████╗░██████╗░  ██╗░░░██╗███╗░░░███╗░█████╗░
██╔══██╗██║░░░██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗  ██║░░░██║████╗░████║██╔══██╗
███████║╚██╗░██╔╝███████║██║░░░░░██║███████║██████╔╝  ██║░░░██║██╔████╔██║███████║
██╔══██║░╚████╔╝░██╔══██║██║░░░░░██║██╔══██║██╔══██╗  ██║░░░██║██║╚██╔╝██║██╔══██║
██║░░██║░░╚██╔╝░░██║░░██║███████╗██║██║░░██║██║░░██║  ╚██████╔╝██║░╚═╝░██║██║░░██║
╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═╝░░╚═╝╚═╝░░╚═╝  ░╚═════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗
██████╦╝███████║██╔██╗██║██║░░██║███████║
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝";

    Console.Clear();
    Console.WriteLine(titulo);
    Console.Write("\nQual banda deseja avaliar: ");
    string banda = Console.ReadLine()!;

    if (listaBandas.ContainsKey(banda))
    {
        Console.Write("\nDigite a nota: ");
        string notaString = Console.ReadLine()!;
        int nota = int.Parse(notaString);
        listaBandas[banda].Add(nota);
        Console.WriteLine("Nota registrada!");
        Thread.Sleep(2000);
        Console.Clear();
        TextoInicial();
        OpcoesMenu();
    } 
    else

    Console.Clear();
    Console.WriteLine(titulo);
    Console.WriteLine($"Banda: {banda} não registrada");
    Console.WriteLine("1 - Registrar banda");
    Console.WriteLine("Outra tecla - Voltar ao Menu principal");
    Console.Write("\nOque deseja: ");
    string opcaoS = Console.ReadLine()!;
    
    int opcao = int.Parse(opcaoS);

    switch (opcao)
    {
         case 1: 
         Console.Clear();
         MenuRegistrar();
         break;

         default:
         Console.Clear();
         TextoInicial();
         OpcoesMenu();;
         break;

    }
    
}

void ConsultaNota()
{
    Console.Clear();
    Console.WriteLine(@"
███╗░░██╗░█████╗░████████╗░█████╗░░██████╗██╗
████╗░██║██╔══██╗╚══██╔══╝██╔══██╗██╔════╝╚═╝
██╔██╗██║██║░░██║░░░██║░░░███████║╚█████╗░░░░
██║╚████║██║░░██║░░░██║░░░██╔══██║░╚═══██╗░░░
██║░╚███║╚█████╔╝░░░██║░░░██║░░██║██████╔╝██╗
╚═╝░░╚══╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░╚═╝");
    Console.Write("\nQual banda deseja consultar as notas: ");
    string banda = Console.ReadLine()!;

    if (listaBandas.ContainsKey(banda))
    {
        List<int> notasBandas = listaBandas[banda];

        if (notasBandas.Count > 0)
        {

            Console.Clear();
            Console.WriteLine(@"
███╗░░██╗░█████╗░████████╗░█████╗░░██████╗██╗
████╗░██║██╔══██╗╚══██╔══╝██╔══██╗██╔════╝╚═╝
██╔██╗██║██║░░██║░░░██║░░░███████║╚█████╗░░░░
██║╚████║██║░░██║░░░██║░░░██╔══██║░╚═══██╗░░░
██║░╚███║╚█████╔╝░░░██║░░░██║░░██║██████╔╝██╗
╚═╝░░╚══╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░╚═╝
");

            Console.WriteLine($"A média de avalição da banda: {banda} é de: {notasBandas.Average()}" +
                $"");

            foreach (int nota in notasBandas)
            {
                Console.WriteLine($"Avaliação: {nota}");
            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            TextoInicial();
            OpcoesMenu();

        }

        else
        {
            Console.WriteLine($"A banda: {banda} não possui avaliações ainda");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            TextoInicial();
            OpcoesMenu();
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Banda: {banda} não existe!");
        Thread.Sleep(2000);
        Console.Clear();
        TextoInicial();
        OpcoesMenu();
    }
}



