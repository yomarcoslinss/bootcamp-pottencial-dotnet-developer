using _19___Serialização.Models;
using Newtonsoft.Json; // Para usar o pacote

DateTime dataAtual = DateTime.Now;

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual); // Instanciando uma venda
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);


List<Venda> listaVendas = new List<Venda>();

listaVendas.Add(v1);
listaVendas.Add(v2);


/*
* Usando o método SerializeObject da classe JsonConvert para serializar a minha variavel v1
* Ou seja, o meu objeto irá ser convertido numa string em formato JSON
*/
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); // Quebra de linha para melhor visualização

// Exibindo o formato JSON armazenado na variável serializando
Console.WriteLine(serializado);

// Escrevendo o arquivo JSON
File.WriteAllText("Arquivos/Vendas.json", serializado);