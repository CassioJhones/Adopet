﻿using Alura.Adopet.Console.Modelos;
namespace Alura.Adopet.Console.Utilitario;

internal class LeitorDeArquivo
{
    public List<Pet> RealizaLeitura(string caminhoDoArquivoParaLer)
    {
        List<Pet> listadePet = new List<Pet>();
        using (StreamReader sr = new StreamReader(caminhoDoArquivoParaLer))
        {
            System.Console.WriteLine("------ Serão importados os dados abaixo ------");
            while (!sr.EndOfStream)
            {
                // separa linha usando ponto e vírgula
                string[]? propriedades = sr.ReadLine().Split(';');
                // cria objeto Pet a partir da separação
                Pet pet = new Pet(Guid.Parse(propriedades[0]), propriedades[1],
                    int.Parse(propriedades[2]) == 1 ? TipoPet.Gato : TipoPet.Cachorro);
                listadePet.Add(pet);
            }
        }

        return listadePet;
    }
}