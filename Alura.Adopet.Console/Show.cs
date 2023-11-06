namespace Alura.Adopet.Console;

[DocComando(instrucao: "show",
            documentacao: "adopet show <ARQUIVO> comando que exibe no terminal o conteúdo do arquivo importado")]
internal class Show
{
    public void ExibeConteudoArquivo(string caminhoDooArquivoASerExibido)
    {
        LeitorDeArquivo leitor = new LeitorDeArquivo();
        var listadePets = leitor.RealizaLeitura(caminhoDooArquivoASerExibido);

        foreach (var pet in listadePets)
            System.Console.WriteLine(pet);
    }
}
