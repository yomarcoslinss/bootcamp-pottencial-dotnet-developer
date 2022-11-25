using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04___Usando_a_classe_Pessoa.Models.Pessoa
{
    public class Pessoa
    {
        public string? Nome {get; set;}
        public int? Idade {get; set;}

        public void Descrever()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}