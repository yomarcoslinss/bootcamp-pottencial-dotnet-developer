using _08___Propriedades__Métodos_e_Construtores.Models;



Pessoa p1 = new Pessoa(nome: "Marcos", sobrenome: "Linss");
Pessoa p2 = new Pessoa("Maiara", "Martins");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();










// // Instanciando 
// Pessoa p1 = new Pessoa(); 
// p1.Nome = "Marcos";
// p1.Sobrenome = "Linss";
// p1.Idade = 19;
// p1.Apresentar();
