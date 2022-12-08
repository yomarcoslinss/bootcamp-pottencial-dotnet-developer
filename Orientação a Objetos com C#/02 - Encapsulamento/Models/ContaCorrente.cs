using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02___Encapsulamento.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo; 

        public void Sacar(decimal valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Você sacou R$ {valor} da sua conta, seu novo saldo R$ {saldo}");
            }
            else
            {
                Console.WriteLine("Não foi possível realizar o saque !! Você informou um valor maior que o saldo disponível em conta");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo atual é R${saldo}");
        }
    }
}