namespace CalculadoraSimplesComCsharp;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---- CALCULADORA SIMPLES ----");

        bool Continuar = true;

        while (Continuar == true)
        {
            Console.Write("1º Número:\t");
            double PrimeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("2º Número:\t");
            double SegundoNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEscolha uma das operações:\n");
            Console.WriteLine("1. Adição --------- |  +");
            Console.WriteLine("2. Subtração ------ |  -");
            Console.WriteLine("3. Multiplicação -- |  *");
            Console.WriteLine("4. Divisão -------- |  /\n");

            Console.Write("Digite o número da operação:\t");
            int Operacao = Convert.ToInt32(Console.ReadLine());

            double Resultado = 0;

            if (Operacao == 1)
            {
                Resultado = PrimeiroNumero + SegundoNumero;
            }
            else if (Operacao == 2)
            {
                Resultado = PrimeiroNumero - SegundoNumero;
            }
            else if (Operacao == 3)
            {
                Resultado = PrimeiroNumero * SegundoNumero;
            }
            else if (Operacao == 4)
            {
                if (SegundoNumero == 0)
                {
                    Console.WriteLine("\n-Não é possível dividir por zero.");
                }
                else
                {
                    Resultado = PrimeiroNumero / SegundoNumero;
                }
            }
            else
            {
                Console.WriteLine("\n-Número da Operação não Existe.");
            }

            Console.WriteLine($"\nResultado:    {Resultado}\n");

            Console.WriteLine("\nDeseja fazer outro cálculo Sim ou Não?");

            string Resposta = Console.ReadLine();

            if (Resposta == "SIM" || Resposta == "Sim" || Resposta == "sim" || Resposta == "S" || Resposta == "s")
            {
                Console.WriteLine("--------------------------------\n");
            }
            else if (Resposta == "NÃO" || Resposta == "Não" || Resposta == "não" || Resposta == "N" || Resposta == "n")
            {
                Continuar = false;
            }
            else
            {
                Console.WriteLine("\n-Resposta não indentificada.");
            }
            Console.WriteLine("-Calculadora ENCERRADA.");
        }

    }
}