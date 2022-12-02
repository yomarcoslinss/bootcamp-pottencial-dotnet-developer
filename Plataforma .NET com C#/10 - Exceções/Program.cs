try
{

    string[] linhas = File.ReadAllLines("Arquivos/a/arquivoLeitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch(FileNotFoundException ex)
{
	// Linha de código que trata o erro mais específico
	Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
	// Linha de código que trata o erro mais específico
	Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho não encontrado {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica {ex.Message}");
}
