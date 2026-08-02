namespace SomaSubtrai;

class Calculadora
{
    public static void Somar(int primeiroNumero, int segundoNumero)
    {
        Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} = {primeiroNumero + segundoNumero}");
    }

    public static void Subtrair(int primeiroNumero, int segundoNumero)
    {
        Console.WriteLine($"A subtração de {primeiroNumero} - {segundoNumero} = {primeiroNumero - segundoNumero}");
    }
}

