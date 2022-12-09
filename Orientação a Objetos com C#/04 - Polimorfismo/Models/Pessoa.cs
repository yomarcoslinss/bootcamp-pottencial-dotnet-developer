using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class Pessoa
    {
        
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() // Definindo que o meu método, é um método virtual e pode ser sobrescrito
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}