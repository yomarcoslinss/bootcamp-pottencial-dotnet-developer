using  _16___Tupla_em_metodos.Models;

ArquivoLeitura arquivo = new ArquivoLeitura();

// Descartando a terceira atribuição da minha tupla
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucesso)
{
    // Console.WriteLine("Quantidade de linhas no arquivo: " + quantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}