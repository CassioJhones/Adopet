﻿using Alura.Adopet.Console.Modelos;
namespace Alura.Adopet.Console.Comandoos;

[DocComando(instrucao: "import",
            documentacao: "adopet import <arquivo> comando que realiza a importação do arquivo de pets.")]
internal class Import
{
    public async Task ImportacaoAquivoPetAsync(string caminhoDoArquivoImportacao)
    {
        var leitor = new LeitorDeArquivo();
        List<Pet> listaDePet = leitor.RealizaLeitura(caminhoDoArquivoImportacao);
        foreach (var pet in listaDePet)
        {
            System.Console.WriteLine(pet);
            try
            {
                var httpCreatePet = new HttpClientPet();
                await httpCreatePet.CreatePetAsync(pet);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        System.Console.WriteLine("Importação concluída!");
    }
}