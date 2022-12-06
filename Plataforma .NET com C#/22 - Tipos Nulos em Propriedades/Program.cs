using _20___Nulos.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/Vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda objeto in listaVenda)
{
    Console.WriteLine($"ID: {objeto.Id} - Produto: {objeto.Produto} - Valor" +
    $"{objeto.Preco.ToString("C")} - Data: " +
    $"{objeto.DataVenda.ToString("dd/MM/yyyy HH:mm")} - " +
    $"{(objeto.Desconto.HasValue ? $"Desconto: {objeto.Desconto}": "")}");
}