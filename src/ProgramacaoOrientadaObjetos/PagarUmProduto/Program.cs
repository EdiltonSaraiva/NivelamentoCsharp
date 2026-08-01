namespace PagarUmProduto;

public class Program
{
    public static void Main()
    {
        Produto produtoComprado = new();
        produtoComprado.NomeDoProduto = "MacBook";
        produtoComprado.ValorDoProduto = 10500;
        produtoComprado.FormaDePagamento = "À vista";
        produtoComprado.MensagemDeCompra();
    }
}