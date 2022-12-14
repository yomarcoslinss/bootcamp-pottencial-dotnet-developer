using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07___Classe_Selada.Models
{
    public class Aluno : Pessoa // Aluno é uma classe filha de Pessoa
    {

        public Aluno(string nome) : base(nome) // base() passa o parâmetro nome do construtor, para a classe pai (Pessoa)
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar() 
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}