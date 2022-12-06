using _26___Método_de_Extensão.Models;

int numero = 20;
bool par = false;

par = numero.EhPar();

string mensagem = $"O número {numero} é {(par? "par" : "impar")}";
Console.WriteLine(mensagem);