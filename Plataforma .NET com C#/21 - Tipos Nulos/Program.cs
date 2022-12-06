bool? desejaReceberEmail = null;

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber e-mail");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
}

// Irá me retornar o else,