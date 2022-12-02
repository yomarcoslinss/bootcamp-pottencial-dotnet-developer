(int, string, string) tupla = (1, "Marcos", "Linss"); // Declarando uma tupla

Console.WriteLine($"ID: {tupla.Item1}"); // Acessando um valor da tupla
Console.WriteLine($"Nome: {tupla.Item2}"); // Acessando um valor da tupla
Console.WriteLine($"Sobrenome: {tupla.Item3}"); // Acessando um valor da tupla

(int Id, string Nome, string Sobrenome) tupla2 = (2, "Maiara", "Martins");

Console.WriteLine($"ID: {tupla2.Id}"); // Acessando um valor da tupla
Console.WriteLine($"Nome: {tupla2.Nome}"); // Acessando um valor da tupla
Console.WriteLine($"Sobrenome: {tupla2.Sobrenome}"); // Acessando um valor da tupla

// Outra sintaxe da tupla

ValueTuple<int , string , string > outraSintaxeTupla = (3, "Manteiguinha", "Linss");