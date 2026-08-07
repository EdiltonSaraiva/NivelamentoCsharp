using ContaBancaria.Models;
using System.Diagnostics;

namespace ContaBancaria.Services;

public class SistemaBancario 
{
    private ContaCorrente _contaCorrente;

    public SistemaBancario()
    {
        _contaCorrente = new ContaCorrente(12345, "Joana");
    }


    public void IniciarSistemaBancario() 
    {
        bool sistemaBancarioAtivo = true;

        while (sistemaBancarioAtivo)
        {
            MostrarOperacoesBancarias();

            int operacaoBancaria = Convert.ToInt32(Console.ReadLine());

            sistemaBancarioAtivo = ExecutarOperacaoBancaria(operacaoBancaria);
        }
    }

    public void MostrarOperacoesBancarias()
    {
        Console.WriteLine("===========================");
        Console.WriteLine("           BANCO           ");
        Console.WriteLine("===========================");
        Console.WriteLine("\n_________OPERAÇÕES_________");
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Transferir");
        Console.WriteLine("4 - Exibir Saldo");
        Console.WriteLine("5 - Exibir Dados da Conta");
        Console.WriteLine("6 - Sair\n");
        Console.Write("Informe a operação que deseja realizar:\t");
    }

    public bool ExecutarOperacaoBancaria(int operacaoEmExecucao)
    {
        switch (operacaoEmExecucao) 
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                return false;
            default:
                Console.WriteLine("Operação inválida. Tente novamente.");
                break;
        }

        return true;
    }

    public void ExibirSaldoDaConta() 
    { 

    }
    public void ExibirDadosDaConta() 
    { 

    }
}
