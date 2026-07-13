using System.Diagnostics;

namespace ContadorDeNumeros;

public class Program
{
    public static void Main()
    { 
        Console.WriteLine("------------CONTADOR DE NÚMEROS--------------");

        Console.WriteLine("Ordens de contagem disponíveis:");
        Console.WriteLine("\n1 - Crescente");
        Console.WriteLine("2 - Decrescente\n");

        Console.Write("Digite o NÚMERO da ordem de contagem desejada:\t");
        int OrdemDeContagem = Convert.ToInt32(Console.ReadLine());

        if (OrdemDeContagem != 1 && OrdemDeContagem != 2)
        {
            Console.WriteLine("\n-Opção INVÁLIDA! Escolha 1 para CRESCENTE ou 2 para DECRESCENTE.");
        }
        else 
        {
            Console.Write("Digite em que número deseja inicar a contagem:\t");
            int NumeroDeContagem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite em que número a contagem deve parar:\t");
            int NumeroDeParada = Convert.ToInt32(Console.ReadLine());

            bool CondicaoDeParada = false;
            bool ErroDeOrdem = false;

            Console.WriteLine();

            switch (OrdemDeContagem)
            {
                case 1:
                    while (CondicaoDeParada == false)
                    {
                        if (ErroDeOrdem == false)
                        {
                            if (NumeroDeContagem == NumeroDeParada)
                            {
                                Console.WriteLine(NumeroDeContagem);
                                Console.WriteLine("\nContagem Finalizada!");
                                break;
                            }
                            else if (NumeroDeContagem < NumeroDeParada)
                            {
                                Console.Write($"{NumeroDeContagem} ");
                                NumeroDeContagem++;
                            }
                            else
                            {
                                ErroDeOrdem = true;
                                Console.WriteLine("-Ordem CRESCENTE escolhida!\nO número de PARADA deve ser MAIOR que o número de INÍCIO.");
                                break;
                            }
                        }
                    }
                    break;

                case 2:
                    while (CondicaoDeParada == false)
                    {
                        if (ErroDeOrdem == false)
                        {
                            if (NumeroDeContagem == NumeroDeParada)
                            {
                                Console.WriteLine(NumeroDeContagem);
                                Console.WriteLine("\nContagem Finalizada!");
                                break;

                            }
                            else if (NumeroDeContagem > NumeroDeParada)
                            {
                                Console.Write($"{NumeroDeContagem} ");
                                NumeroDeContagem--;
                            }
                            else
                            {
                                ErroDeOrdem = true;
                                Console.WriteLine("-Ordem DECRESCENTE escolhida!\nO número de PARADA deve ser MENOR que o número de INÍCIO.");
                                break;
                            }
                        }
                    }
                    break;
            }
        }
    }
}