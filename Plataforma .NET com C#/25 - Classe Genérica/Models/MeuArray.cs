using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _25___Classe_Genérica.Models
{
    public class MeuArray<T> // Declarando uma classe genérica
    {                        
        private static int capacidade = 10; // Variável que irá definir a capacidade do meu array
        private int contador = 0;
        private T[] array = new T[capacidade]; // Declarando um array privado do tipo <T> (genérico)
                                               // Obs: A capacidade dele está armazenado na variável "capacidade"

        public void AdicionarElementoArray(T elemento) // Método para adicionar elementos no meu array
        {
            if (contador + 1 < 11)
            {
                array[contador] = elemento; // Enquanto contador for menor do que 11, eu consigo adicionar elementos no meu array
            }

            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        
     }
}  