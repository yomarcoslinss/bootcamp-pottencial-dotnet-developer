// Declarando uma variável dinâmica:

dynamic variavelDinamica = 4;
Console.WriteLine($"O tipo da variável é: {variavelDinamica.GetType()} e o seu valor é: {variavelDinamica}");
// Retorno: O tipo da variável é: System.Int32 e o seu valor é: 4



// Em uma variável dinâmica, é possível sobrescrever o seu valor, por um valor de outro tipo
variavelDinamica = "Texto";
Console.WriteLine($"O tipo da variável é: {variavelDinamica.GetType()} e o seu valor é: {variavelDinamica}");
// Retorno: O tipo da variável é: System.String e o seu valor é: Texto


variavelDinamica = true;
Console.WriteLine($"O tipo da variável é: {variavelDinamica.GetType()} e o seu valor é: {variavelDinamica}");
// Retorno: O tipo da variável é: System.Boolean e o seu valor é: True