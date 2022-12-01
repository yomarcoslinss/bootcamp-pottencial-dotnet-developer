using _09___Manipulando_Valores.Models;



Pessoa p1 = new Pessoa(nome: "Marcos", sobrenome: "Linss"); // não é obrigatório inserir o nome dos parâmetros
Pessoa p2 = new Pessoa("Maiara", "Martins");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
