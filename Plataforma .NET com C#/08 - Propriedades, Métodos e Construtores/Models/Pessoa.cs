using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08___Propriedades__Métodos_e_Construtores.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}