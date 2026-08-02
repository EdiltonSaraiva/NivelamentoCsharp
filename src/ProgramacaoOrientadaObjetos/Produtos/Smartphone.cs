using System.Security.AccessControl;

namespace Produtos;

class Smarphone : Produto
{
    private string? _sistemaOperacional;

    public Smarphone(string nomeSmartphone, string marcaSmartphone, double  valorSmartphone, string sistemaOperacional)
    {
        NomeProduto = nomeSmartphone;
        MarcaProduto = marcaSmartphone;
        ValorProduto = valorSmartphone;
        _sistemaOperacional = sistemaOperacional;

        ExibirInformacoesProduto();
        ExibirInformacoesSmarphone();
    }

    private void ExibirInformacoesSmarphone()
    {
        Console.WriteLine($"Sistema Operacional: {_sistemaOperacional}");
    }
}

