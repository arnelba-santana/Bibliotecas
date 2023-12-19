// using System;

// Randon dado = new Randon();
// int lados = dado.Next(1,7);
// Console.WriteLine(lados);

// float numero = 81;
// Console.Write(Math.Sqrt(numero));

// Caminho do arquivo.
string caminhoDoArquivo = @"C:\Users\ARNELBA\Desktop\SENAI\Codificação Back End\C-SHARP\ExemplosSintaxeBasica\arquivo.txt";

// Instancia um objeto do tipo StreamWriter com o caminho do arquivo como argumento.
var stream = new StreamWriter(caminhoDoArquivo);

// Escreve uma linha no arquivo
stream.WriteLine("Linha 1...");
stream.WriteLine("Linha 2...");
stream.WriteLine("Linha 3...");

// Fecha o objeto atual e o fluxo adjacente.
stream.Close();

// O using finaliza a instrução no final do bloco de execução
// streamreader para ler um arquivo
using (var reader = new
StreamReader(caminhoDoArquivo))
{

    // Lê linha por linha até o final do arquivo.
    var linha = " ";
    while ((linha = reader.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
}




