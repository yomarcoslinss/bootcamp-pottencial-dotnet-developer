int[] arrayInteiros = new int[3]; // Declarando uma array int com 3 valores

 arrayInteiros[0] = 72; // Adicionando valores
 arrayInteiros[1] = 64; // Adicionando valores
 arrayInteiros[2] = 50; // Adicionando valores

// Usando um laço de repetição para imprimir os valores da array, linha por linha
 for(int i = 0; i < arrayInteiros.Length; i++)
 {
    Console.WriteLine($"Na posição N° {i} da array, eu tenho o valor: {arrayInteiros[i]}");
 }