int[] arrayInteiros = new int[3]; // Declarando uma array int com 3 valores

 arrayInteiros[0] = 72; // Adicionando valores
 arrayInteiros[1] = 64; // Adicionando valores
 arrayInteiros[2] = 50; // Adicionando valores

// Aumentando o tamanho da array
Array.Resize(ref arrayInteiros, arrayInteiros.Length + 2);

// Copiando os dados de uma array, para uma nova array
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2]; // Declaração
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Percorrendo o Array com o FOREACH
int contadorForEach = 0;
 foreach(int valor in arrayInteirosDobrado)
 {
    Console.WriteLine($"Na índice N°{contadorForEach} eu tenho o valor = {valor}");
    contadorForEach++;
 }
