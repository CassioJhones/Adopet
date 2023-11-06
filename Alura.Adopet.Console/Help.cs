using System.Reflection;
namespace Alura.Adopet.Console;

[DocComando(instrucao: "help",
            documentacao: "adopet help <parametro> comando que exibe informações de ajuda dos comandos. \n adopet help <COMANDO> para acessar a ajuda de um comando especifico")]
internal class Help
{
    private Dictionary<string, DocComando> docs;
    public Help()
    {
        docs = Assembly.GetExecutingAssembly().GetTypes().
            Where(x => x.GetCustomAttributes<DocComando>().Any()).
            Select(x => x.GetCustomAttribute<DocComando>()!).ToDictionary(d => d.Instrucao);
    }
    public void ExibeDocumentacao(string[] parametros)
    {
        System.Console.WriteLine("Lista de comandos.");

        if (parametros.Length == 1)
        {
            System.Console.WriteLine("adopet help <parametro> ous simplemente adopet help comando que exibe informações de ajuda dos comandos.");
            System.Console.WriteLine("Adopet (1.0) - Aplicativo de linha de comando (CLI).");
            System.Console.WriteLine("Realiza a importação em lote de um arquivos de pets.");
            System.Console.WriteLine("Comando possíveis: ");
            System.Console.WriteLine("Execute 'adopet.exe help [comando]' para obter mais informações sobre um comando.\n\n\n");

            foreach (var doc in docs.Values)
                System.Console.WriteLine(doc.Documentacao);
        }
        else if (parametros.Length == 2)
        {
            string comandoaSerExibido = parametros[1];
            if (docs.ContainsKey(comandoaSerExibido))
            {
                var comando = docs[comandoaSerExibido];
                System.Console.WriteLine(comando.Documentacao);
            }
        }
    }
}


