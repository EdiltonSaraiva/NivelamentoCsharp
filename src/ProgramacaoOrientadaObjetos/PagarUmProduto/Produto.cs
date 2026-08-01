class Produto
{
    public string? NomeDoProduto {get; set;}
    public double ValorDoProduto {get; set;}
    public string? FormaDePagamento {get; set;}

    public void MensagemDeCompra()
    {
        double valorProduto = ValorDoProduto >= 500 && FormaDePagamento == "À vista" ? ValorDoProduto * 0.9 : ValorDoProduto;

        Console.WriteLine($"O produto: {NomeDoProduto} será pago de maneira: {FormaDePagamento} no valor de {valorProduto}");
    }

}
