int quantidadeCompra = 1;


int quantidadeEstoque = 3;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar essa venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Valor inválido !! digite um valor válido");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantia desejada em estoque :(");
}
