string a = "15-";
int b = 0;

// O TryParse irá tentar realizar a conversão, porém ele está ciente que possa dar erro
// Caso ele não consiga realizar a conversão, o código irá continuar normalmente (SEM APRESENTAR ERRO) 
int.TryParse(a, out b);
// Tentou converter para numero o valor da string a, e passou o valor para b
Console.WriteLine(b); // Como não foi possível realizar a conversão, o valor de b continuou como 0
Console.WriteLine("Conversão realizada!");