using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05___Classe_Abstrata.Models
{
    public class Corrente : Conta // Herdando da classe conta, que é uma classe abstrata
    {
        public override void Creditar(decimal valor) // Implementando a minha classe abstrata
        {
            saldo += valor;
        }
    }
}