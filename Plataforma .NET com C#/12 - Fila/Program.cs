Queue<int> fila = new Queue<int>(); // Declarando uma fila

// Adicionando itens na fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila) // Estrutura de repetição foreach para exibir os itens da fila
{
    Console.WriteLine(item);
}

// Irá remover o primeiro item inserido da lista (nesse caso, o 2)
fila.Dequeue();

foreach(int item in fila) // Estrutura de repetição foreach para exibir os itens da fila
{
    Console.WriteLine(item);
}

// Irá me retornar : 4, 6, 8
