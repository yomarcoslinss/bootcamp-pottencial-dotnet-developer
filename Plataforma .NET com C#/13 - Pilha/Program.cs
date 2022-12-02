Stack<int> pilha = new Stack<int>(); // Declarando uma pilha

pilha.Push(4); // Insere um objeto no topo da pilha
pilha.Push(6); // Insere um objeto no topo da pilha
pilha.Push(8); // Insere um objeto no topo da pilha
pilha.Push(10); // Insere um objeto no topo da pilha

// Laço de repetição para me retornar os elementos dentro da pilha
foreach(int item in pilha)
{
    Console.WriteLine(item);
}

// Irá me retornar : 10, 8, 6, 4


// Remove e retorna o ultimo elemento adicionado na pilha (que no caso, na pilha ele está no topo,  o 10)
pilha.Pop();

// Laço de repetição para me retornar os elementos dentro da pilha
foreach(int item in pilha)
{
    Console.WriteLine(item);
}

// Irá me retornar: 8, 6, 4