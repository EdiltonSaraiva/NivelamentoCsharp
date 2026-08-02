namespace Produtos;

public class Program 
{
    public static void Main()
    {
        Smarphone smartphone = new Smarphone("iPhone 17 pro max", "Apple", 15000, "iOS");
        Console.WriteLine();
        Geladeira geladeira = new Geladeira("Geladeira simples", "Philco", 3500, 430);
    }
    
}