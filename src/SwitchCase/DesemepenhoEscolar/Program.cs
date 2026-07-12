using System.Diagnostics.Contracts;

namespace DesemepenhoEscolar;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--------DESEMPENHO ESCOLAR--------");

        Console.WriteLine("Por favor, digite a sua nota:\t");
        int SuaNota = Convert.ToInt32(Console.ReadLine());

        switch (SuaNota) 
        {
            case 10:
            case 9:
                Console.WriteLine("\n-EXECELENTE!");
                break;
            case 8:
            case 7:
                Console.WriteLine("\n-MUITO BOM!");
                break;
            case 6:
                Console.WriteLine("\n-REGULAR!");
                break;
            case 5:
                Console.WriteLine("\n-INSATISFATÓRIO!");
                break;
            default:
                Console.WriteLine("\n-RUIM!");
                break;
        }
    }
}