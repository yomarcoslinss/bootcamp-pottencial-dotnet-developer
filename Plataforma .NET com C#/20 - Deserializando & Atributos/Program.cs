using _20___Deserializando.Models;
using Newtonsoft.Json;

// Declarando uma variável string que irá ler o arquivo JSON
string conteudoArquivo = File.ReadAllText("Arquivos/Vendas.json");

// Declarando uma lista da classe venda, que irá receber o arquivo JSON desserializado
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// Laço de repetição para me retornar cada objeto dentro de listaVenda
foreach(Venda objeto in listaVenda)
{
    Console.WriteLine($"ID: {objeto.Id} - Produto: {objeto.Produto} - Valor {objeto.Preco.ToString("C")} - Data: {objeto.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}