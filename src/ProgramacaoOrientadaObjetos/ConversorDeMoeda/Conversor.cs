namespace ConversorDeMoeda;

class Conversor : Padrao
{
    public override void DolarReal(double valor)
    {
        Console.WriteLine($"Valor em Real -> R${valor * 5.12}");
    }

    public override void RealDolar(double valor)
    {
        Console.WriteLine($"Valor em Dólar -> US${valor / 5.12}");
    }
}

