using System.Reflection;

namespace Alura.Adopet.Console;


[DocComando(instrucao: "help",
            documentacao: "adopet help <parametro> ous simplemente adopet help comando que exibe informações de ajuda dos comandos.")]
internal class Help{

    private Dictionary<string, DocComando> docs;
    public Help()
    {
        docs = Assembly.GetExecutingAssembly().GetTypes().
            Where(x => x.GetCustomAttributes<DocComando>().Any()).
            Select(x => x.GetCustomAttribute<DocComando>()!).ToDictionary(d => d.Instrucao);
    }
    public void ExibeDocumentacao(string parametros){

        System.Console.WriteLine("Lista de comandos.");
        // se não passou mais nenhum argumento mostra help de todos os comandos
        if (parametros.Length == 1){
            System.Console.WriteLine("adopet help <parametro> ous simplemente adopet help comando que exibe informações de ajuda dos comandos.");
            System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
            System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");
            System.Console.WriteLine("Comando possíveis: ");
            System.Console.WriteLine($" adopet import <arquivo> comando que realiza a importação do arquivo de pets.");
            System.Console.WriteLine($" adopet show   <arquivo> comando que exibe no terminal o conteúdo do arquivo importado.\n\n\n\n");
            System.Console.WriteLine("Execute 'adopet.exe help [comando]' para obter mais informações sobre um comando.\n\n\n");
        }
        else if (parametros.Length == 2){
            string comandoaSerExibido = parametros;
            if (comandoaSerExibido.Equals("import")){
                System.Console.WriteLine(" adopet import <arquivo> " +
                    "comando que realiza a importação do arquivo de pets.");
            }
            if (comandoaSerExibido.Equals("show")){
                System.Console.WriteLine(" adopet show <arquivo>  comando que " +
                    "exibe no terminal o conteúdo do arquivo importado.");
            }
        }
    }
}


