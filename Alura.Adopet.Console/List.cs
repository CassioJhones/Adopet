namespace Alura.Adopet.Console;

[DocComando(instrucao: "list",
            documentacao: "adopet list comando que exibe no terminal o conteúdo cadastrado no banco de dados.")]
internal class List
{
    public async Task ListaDadosPetsAPIAsync()
    {
        var httpListPet = new HttpClientPet();
        IEnumerable<Pet>? pets = await httpListPet.ListPetsAsync();
        System.Console.WriteLine("----- Pets Importados -----");
        foreach (var pet in pets)
        {
            System.Console.WriteLine(pet);
        }

    }
}
