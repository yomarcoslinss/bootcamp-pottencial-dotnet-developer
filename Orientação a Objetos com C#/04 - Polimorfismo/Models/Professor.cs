using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models // Obs: é necessário usar o namespace
{
    public class Professor : Pessoa // Professor é uma classe filha de Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar() // Definindo que eu estou sobrescrevendo o método Apresentar
        {
            Console.WriteLine($"Olá, eu sou o professor {Nome}, tenho {Idade} anos e eu recebo {Salario.ToString("C")} por mês");
        }
    }
}