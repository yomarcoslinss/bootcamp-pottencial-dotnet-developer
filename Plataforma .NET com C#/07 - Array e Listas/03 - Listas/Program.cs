List<string> listaString = new List<string>(); // Declarando uma lista

listaString.Add("SP"); // Incrementando um valor na lista
listaString.Add("BA"); // Incrementando um valor na lista
listaString.Add("MG"); // Incrementando um valor na lista

// Percorrendo a lista com o laço FOR
for (int contador = 0 ; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Na posição N° {contador} = {listaString[contador]}");
}