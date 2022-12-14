using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07___Classe_Selada.Models
{
    public sealed class Professor : Pessoa
    {
        
        public Professor()
        {

        }

        public Professor(string nome) : base(nome)
        {

        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou o professor {Nome}, tenho {Idade} anos e eu recebo {Salario.ToString("C")} por mês");
        }
    }
}