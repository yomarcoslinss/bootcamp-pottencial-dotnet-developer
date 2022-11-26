int quantidadeEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeEstoque >= quantidadeCompra;


if (quantidadeCompra == 0)
{
    Console.WriteLine("Insira um valor caso queira comprar um produto!");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe, não temos a quantia desejada em estoque :(");
}
