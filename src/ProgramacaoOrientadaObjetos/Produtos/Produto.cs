namespace Produtos;

class Produto
{
    protected string? NomeProduto;
    protected string? MarcaProduto;
    protected double ValorProduto;

    protected void ExibirInformacoesProduto()
    {
        Console.WriteLine($"Nome do Produto: {NomeProduto}");
        Console.WriteLine($"Marca do Produto: {MarcaProduto}");
        Console.WriteLine($"Valor do Produto: R${ValorProduto}");
    }
}