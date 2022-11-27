// Console.WriteLine("Digite uma letra");
// string? letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("A letra digitada é uma VOGAL");
// }
// else
// {
//     Console.WriteLine("A letra digitada é uma CONSOANTE");
// }



Console.WriteLine("Digite uma letra");
string? letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("A letra digitada é uma VOGAL");
        break;

    default:
        Console.WriteLine("A letra digitada é uma CONSOANTE");
        break;
}
