using _25___Classe_Genérica.Models;

// Instanciando um array, da classe MeuArray, do tipo inteiro:
MeuArray<int> arrayInteiro = new MeuArray<int>();

// Utilizando o método para adicionar um elemento no meu array
arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);



// Instanciando um novo array, da classe MeuArray, do tipo string:
MeuArray<string> arrayString = new MeuArray<string>();

// Utilizando o método para adicionar um elemento no meu array
arrayString.AdicionarElementoArray("Marcos");

Console.WriteLine(arrayString[0]);

