using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08___Propriedades__Métodos_e_Construtores.Models
{
    public class Pessoa
    {

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome 
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade {

            get => _idade;

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Insira uma idade válida!");
                }

                _idade = value;
            }

        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}