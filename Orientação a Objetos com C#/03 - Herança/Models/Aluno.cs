using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca.Models // obs: é necessário usar o namespace
{
    public class Aluno : Pessoa // Declarando que Aluno está Herdando de Pessoa usando " : "
    {
        // Além de herdar propriedades e métodos da classe pessoa, a classe aluno tem como exclusivo a propriedade "Nota"
        public double Nota { get; set; }
    }
}