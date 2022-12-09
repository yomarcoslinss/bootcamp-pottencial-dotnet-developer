using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo.Models
{
    public class Calculadora
    {
        // Caso eu instancie com dois parâmetros, será usado esse primeiro método
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        // Caso eu instancie com três parâmetros, será usado esse segundo método

        public int Somar(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
    }
}