using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16___Tupla_em_metodos.Models
{
    public class ArquivoLeitura
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Length);
            }
            catch(Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}