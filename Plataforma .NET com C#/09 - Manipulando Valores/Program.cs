using _09___Manipulando_Valores.Models;

// Formatando valores monetarios
using System.Globalization; // para alterar a minha localização (muda a formatação de real)
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // muda a formatação de real para dolar
decimal valorMonetario = 89.40M;
Console.WriteLine($"{valorMonetario:C}"); // :C converte o valor recebido para um valor em dinheiro

// Outra maneira de resolução:
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // Alterando a localização da cultura


// Formatando DateTime

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yy HH:mm"));

DateTime data2 = DateTime.Now;
Console.WriteLine(data2.ToShortDateString());





// Pessoa p1 = new Pessoa(nome: "Marcos", sobrenome: "Linss"); // não é obrigatório inserir o nome dos parâmetros
// Pessoa p2 = new Pessoa("Maiara", "Martins");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
