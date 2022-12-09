using Heranca.Models;

// Instanciando um Aluno (que está herdando propriedadades e métodos da classe Pessoa)

Aluno a1 = new Aluno(); 

a1.Nome = "Marcos";
a1.Idade = 19;

// Obs: A propriedade Nota é exclusiva da classe Aluno (não está disponivel na classe Pessoa)
a1.Nota = 8.5;

a1.Apresentar();
