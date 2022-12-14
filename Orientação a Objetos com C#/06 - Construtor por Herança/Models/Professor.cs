using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06___Construtor_por_Herança.Models
{
    public class Professor : Pessoa // Professor é uma classe filha de Pessoa
    {
        
        public Professor()
        {

        }

        public Professor(string nome) : base(nome) // base() serve para passar o parâmetro para a classe pai
        {

        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou o professor {Nome}, tenho {Idade} anos e eu recebo {Salario.ToString("C")} por mês");
        }
    }
}