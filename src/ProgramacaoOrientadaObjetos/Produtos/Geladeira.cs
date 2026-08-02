namespace Produtos;

class Geladeira : Produto
{
    private int _capacidadeDeArmazenamento;

    public Geladeira(string nomeGeladeira, string marcaGeladeira, double valorGeladeira, int capacidadeGeladeira)
    {
        NomeProduto = nomeGeladeira;
        MarcaProduto = marcaGeladeira;
        ValorProduto = valorGeladeira;
        _capacidadeDeArmazenamento = capacidadeGeladeira;

        ExibirInformacoesProduto();
        ExibirInformacoesGeladeira();
    }

    private void ExibirInformacoesGeladeira()
    {
        Console.WriteLine($"Capacidade de armazenamento: {_capacidadeDeArmazenamento} litros");
    }
}
