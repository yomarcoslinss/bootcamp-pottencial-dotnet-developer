string? opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
        Console.Clear();
        Console.WriteLine("Cadastro de cliente");
        
        break;

        case "2":
        Console.Clear();
        Console.WriteLine("Busca de cliente");
        break;

        case "3":
        Console.Clear();
        Console.WriteLine("Apagar cliente");
        break;

        case "4":
        Console.Clear();
        Console.WriteLine("Encerrar");
        exibirMenu = false;
        // Enviroment.Exit(0);
        break;

        default:
        Console.Clear();
        Console.WriteLine("Insira um numero válido !! (1 - 4)");
        break;
    }
}

Console.WriteLine("Programa finalizado!");