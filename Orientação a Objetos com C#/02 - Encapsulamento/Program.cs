using _02___Encapsulamento.Models;


ContaCorrente c1 = new ContaCorrente(3597, 200);

//c1.saldo = 5000; // Irá me retornar um erro pois esse campo é inacessível devido a sua proteção

c1.ExibirSaldo();

c1.Sacar(150);

c1.ExibirSaldo();
