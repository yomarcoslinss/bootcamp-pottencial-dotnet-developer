using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models // Obs: é necessário usar o namespace
{
    public class Aluno : Pessoa // Aluno é uma classe filha de Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar() // Definindo que eu estou sobrescrevendo o método apresentar
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}