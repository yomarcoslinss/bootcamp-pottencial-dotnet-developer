using Polimorfismo.Models;

Aluno a1 = new Aluno();
a1.Nome = "Marcos";
a1.Idade = 19;
a1.Nota = 8.5;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Leonardo";
p1.Idade = 26;
p1.Salario = 1000;
p1.Apresentar();

// Retorno:
// a1 = Olá, meu nome é Marcos, tenho 19 anos e sou um aluno nota 8,5
// p1 = Olá, eu sou o professor Leonardo, tenho 26 anos e eu recebo R$ 1.000,00 por mês