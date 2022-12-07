using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstração.Models
{
    public class Pessoa
    {
        /*
        *
        * Aqui eu estou abstraindo um objeto do mundo real (uma pessoa).
        * Ou seja, eu analiso o contexto do meu programa e declaro somente propriedades
        * que fará sentido (que eu irei precisar).
        *
        */
        
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}