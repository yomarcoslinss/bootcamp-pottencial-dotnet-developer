int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número! (Digite 0 para encerrar o programa)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
    Console.WriteLine($"Valor atual da soma = {soma}");

} while(numero != 0);

Console.WriteLine($"Programa encerrado !!! Total da soma dos numeros = {soma}");