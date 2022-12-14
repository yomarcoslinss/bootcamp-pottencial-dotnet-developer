using _05___Classe_Abstrata.Models;

// Conta c = new Conta(); // Irá retornar um erro, pois não é possível instanciar diretamente uma classe abstrata
Corrente c = new Corrente();

// Instanciando a minha classe Corrente
c.Creditar(500); 
c.ExibirSaldo();