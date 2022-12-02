// Declarando um Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo"); // Adicionando conjuntos de chave-valor
estados.Add("BA", "Bahia"); // Adicionando conjuntos de chave-valor
estados.Add("MG", "Minas Gerais"); // Adicionando conjuntos de chave-valor

foreach(KeyValuePair<string, string> item in estados) // KeyValuePair<> pode ser substituido por "var"
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
    // Key: retorna a chave do meu dictionary • Value: retorna o vlaor do meu dictionary
}

estados.Remove("BA"); // Removendo uma chave
estados["MG"] = "Rio de Janeiro"; // Alterando um valor

Console.WriteLine(estados["MG"]); // Acessando um valor
