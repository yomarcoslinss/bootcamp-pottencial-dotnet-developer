using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Models
{
    public class Professor : Pessoa
    {
        // Além de herdar propriedades e métodos da classe pessoa, a classe professor tem como exclusivo a propriedade "Salario"

        public decimal Salario { get; set; }
    }
}