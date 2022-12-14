using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces.Interfaces;

namespace Interfaces.Models
{
    public class Calculadora : ICalculadora // Implementando a classe ICalculadora
    {
        /*
        * Implementando os métodos da interface ICalculadora
        * Obs: é obrigatório implementar todos os métodos, de contrário irá retornar um erro!
        */
        
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}