/*
*   Criando um programa para verificar se um número é par ou impar
*/


// SEM o IF Ternario
int numero = 20;
if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par!");
}
else
{
    Console.WriteLine($"O número {numero} é impar!");
}

// IF Ternario
int numero2 = 20;
bool ehPar = false;

ehPar = numero2 % 2 == 0;

Console.WriteLine($"O número {numero2} é " + (ehPar ? "par!" : "impar!"));