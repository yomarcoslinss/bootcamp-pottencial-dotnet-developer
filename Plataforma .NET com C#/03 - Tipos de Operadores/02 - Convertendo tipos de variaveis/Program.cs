// Cast ou Casting, se refere a conversão de tipos de variáveis

// Usando a classe Convert para converter um número string para um numero inteiro:
int a = Convert.ToInt32("5");
Console.WriteLine(a);

//Outra maneira de resolução
int b = int.Parse("5");
Console.WriteLine(b);

// A diferença entre as duas soluções acima, é como elas tratam um valor null
// Caso a classe Convert recebá um valor null, ela irá retornar 0 (recomendado)
// E no caso do Parse, ele não aceita o null e retorna um erro


// Nesse caso de conversão, não é possível utilizar o método Parse
int inteiro = 5;
string c = inteiro.ToString(); // TODOS os tipos podem ser representados em String
