
// Declarando uma variável tipo anonimo
var tipoAnonimo = new { Nome = "Marcos", Sobrenome = "Linss", Idade = 19 };

// Não é possível alterar o valor de uma propriedade do tipo anonimo
// tipoAnonimo.Nome = "Linss";  || Irá retornar um erro

Console.WriteLine($"Nome {tipoAnonimo.Nome}");
Console.WriteLine($"Sobrenome {tipoAnonimo.Sobrenome}");
Console.WriteLine($"Idade {tipoAnonimo.Idade}");