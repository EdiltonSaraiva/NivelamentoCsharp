namespace DiaDaSemana;

public class Program 
{
    public static void Main()
    {
        Console.WriteLine("------------------------DIA DA SEMANA------------------------");

        Console.Write("\nDigite um número de 1 a 7 para saber o dia da semana correspondente:\t");
        int DiaDaSemana = Convert.ToInt32(Console.ReadLine());

        switch (DiaDaSemana) 
        {
            case 1:
                Console.WriteLine("\n-Domingo");
                break;
            case 2:
                Console.WriteLine("\n-Segunda-feira");
                break;
            case 3:
                Console.WriteLine("\n-Terça-feira");
                break;  
            case 4:
                Console.WriteLine("\n-Quarta-feira");
                break;
            case 5:
                Console.WriteLine("\n-Quinta-feira");
                break;
            case 6:
                Console.WriteLine("\n-Sexta-feira"); 
                break;
            case 7:
                Console.WriteLine("\n-Sábado");
                break;
            default:
                Console.WriteLine("\nDia INVÁLIDO! Por favor, digite um número de 1 a 7.");
                break;
        }
    }
}