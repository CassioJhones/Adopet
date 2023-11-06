﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Console
{
    internal class Show
    {
        public void ExibeConteudoArquivo(string caminhoDooArquivoASerExibido)
        {
            using (StreamReader sr = new StreamReader(caminhoDooArquivoASerExibido))
            {
                System.Console.WriteLine("------ Serão importados os dados abaixo ------");
                while (!sr.EndOfStream)
                {
                    // separa linha usando ponto e vírgula
                    string[]? propriedades = sr.ReadLine().Split(';');
                    // cria objeto Pet a partir da separação
                    Pet pet = new Pet(Guid.Parse(propriedades[0]), propriedades[1], TipoPet.Cachorro);
                    System.Console.WriteLine(pet);
                }
            }
        }
    }
}
