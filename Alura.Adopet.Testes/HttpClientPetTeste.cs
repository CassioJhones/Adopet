using Alura.Adopet.Console.Servicos;
namespace Alura.Adopet.Testes;

public class HttpClientPetTeste
{
    [Fact]
    public async Task TesteDaListaNaoVazia()
    {//Nome do teste deve ser bem explicativo no método

        //ARRANGE = Configuracao do projeto
        var clientePet = new HttpClientPet();

        //ACT - oque testar
        var lista = await clientePet.ListPetsAsync();

        //ASSERT - Quais as expectativas;
        Assert.NotNull(lista);
        Assert.NotEmpty(lista);
    }

    [Fact]
    public async Task TesteApiDesligada()
    {//Nome do teste deve ser bem explicativo no método

        //ARRANGE = Configuracao do projeto
        var clientePet = new HttpClientPet();

        //ACT oque testar + ASSERT Quais as expectativas;
        await Assert.ThrowsAnyAsync<Exception>(() => clientePet.ListPetsAsync());
    }
}