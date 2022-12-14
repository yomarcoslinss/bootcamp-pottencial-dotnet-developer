using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface ICalculadora
    {
        /*
        * Implementando 4 métodos sem corpo, o seu bloco de código
        * será definido uma classe implementar essa interface
        */
        
        int Somar(int num1, int num2);  
        int Subtrair(int num1, int num2);  
        int Multiplicar(int num1, int num2);  
        int Dividir(int num1, int num2);  
    }
}