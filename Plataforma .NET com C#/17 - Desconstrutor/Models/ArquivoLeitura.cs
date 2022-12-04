using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17___Desconstrutor.Models
{
    public class ArquivoLeitura
    {
        // Declarando a tupla
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Length);
            }
            catch (Exception)
            {
                // Os tipos de retorno devem ter a mesma ordem da declaração da tupla
                return (false, new string[0], 0); 
            }
        }
    }
}