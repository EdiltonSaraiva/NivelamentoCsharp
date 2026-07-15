namespace TabuadaInterativa;

public class Program 
{
    public static void Main()
    { 
        Console.WriteLine("--------------TABUADA INTERATIVA--------------");

        bool PedirParada = false;
        string RespostaUsuario = "";

        while (PedirParada == false)
        {
            Console.Write("Digite um número de 1 a 10 para ver a tabuada:\t");
            int NumeroEscolhido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma das 4 operações:\n");
            Console.WriteLine("1 - Adição  --------- | +");
            Console.WriteLine("2 - Subtração  ------ | -");
            Console.WriteLine("3 - Multiplicação  -- | *");
            Console.WriteLine("4 - Divisão  -------- | /");

            if (NumeroEscolhido >= 1 || NumeroEscolhido <= 10)
            {
                Console.Write("\nDigite o número da operação desejada:\t");
                int OperacaoEscolhida = Convert.ToInt32(Console.ReadLine());

                if (OperacaoEscolhida == 1)
                {
                    Console.WriteLine($"\nTabuada do número: {NumeroEscolhido} | Operação: Adição");
                    for (int OperandoAdicao = 1; OperandoAdicao <= 10; OperandoAdicao++)
                    {
                        Console.WriteLine($"{OperandoAdicao} + {NumeroEscolhido} = {OperandoAdicao + NumeroEscolhido}");
                    }                            
                }
                else if (OperacaoEscolhida == 2) 
                {
                    int PararSubtracao = 1;

                    Console.WriteLine($"\nTabuada do número: {NumeroEscolhido} | Operação: Subtração");
                    for (int OperandoSubtracao = NumeroEscolhido + 1; PararSubtracao <= 10; OperandoSubtracao++)
                    {
                        Console.WriteLine($"{OperandoSubtracao} - {NumeroEscolhido} = {OperandoSubtracao - NumeroEscolhido}");
                        PararSubtracao++;
                    }
                }
                else if (OperacaoEscolhida == 3) 
                {
                    Console.WriteLine($"\nTabuada do número: {NumeroEscolhido} | Operação: Adição");
                    for (int OperandoMultiplicacao = 1; OperandoMultiplicacao <= 10; OperandoMultiplicacao++)
                    {
                        Console.WriteLine($"{OperandoMultiplicacao} * {NumeroEscolhido} = {OperandoMultiplicacao * NumeroEscolhido}");
                    }
                }
                else if (OperacaoEscolhida == 4)
                {
                    int PararDivisao = 1;
                    Console.WriteLine($"\nTabuada do número: {NumeroEscolhido} | Operação: Adição");
                    for (int OperandoDivisao = NumeroEscolhido; PararDivisao <= 10; OperandoDivisao += NumeroEscolhido)
                    {
                        Console.WriteLine($"{OperandoDivisao} / {NumeroEscolhido} = {OperandoDivisao / NumeroEscolhido}");
                        PararDivisao++;
                    }
                }
                else
                {
                    Console.WriteLine("\nNúmero INVÁLIDO! Escolha um número de 1 a 1O.\n");
                }

                Console.Write("\nDeseja ver a tabuada de outro número? Sim ou Não?\t");
                RespostaUsuario = Console.ReadLine();
                
                if (RespostaUsuario == "SIM" || RespostaUsuario == "Sim" || RespostaUsuario == "sim" || RespostaUsuario == "S" || RespostaUsuario == "s")
                {
                    Console.WriteLine("\nREINICIADO!\n");
                }
                else if (RespostaUsuario == "NÃO"|| RespostaUsuario == "Não" || RespostaUsuario == "não" || RespostaUsuario == "N" || RespostaUsuario == "n")
                {
                    PedirParada = true;
                    Console.WriteLine("Tabuada ENCERRADA com sucesso!");
                }
                else
                {
                    PedirParada = true;
                    Console.WriteLine("Resposta NÃO IDENTIFICADA!");
                }
            }
        }
    }
}