using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05___Classe_Abstrata.Models
{
    // Definindo que a minha classe é abstrata ! ou seja, ela só pode ser herdada (não pode ser instanciada diretamente)
    public abstract class Conta
    {
        // protected:  protegido contra alterações externas, com exceção das suas classes filhas
        protected decimal saldo;

        // Definindo um método como abstrato ! ou seja, depois de herdar, eu preciso implementar ele (inserir bloco de código)
        public abstract void Creditar(decimal valor); // Um método abstrato não possuí escopo {}

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo em conta {saldo.ToString("C")}");
        }
    }
}