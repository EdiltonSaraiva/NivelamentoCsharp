namespace ConversorDeMoeda;

public class Program 
{
    public static void Main()
    {
        Conversor conversao = new Conversor();
        conversao.RealDolar(100);
        conversao.DolarReal(100);
    }
}