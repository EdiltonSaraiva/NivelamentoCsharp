namespace ContaBancaria.Models;

public abstract class Conta
{
    public int NumeroDaConta { get; set; }
    public string? TitularDaConta { get; set; }
    public decimal SaldoDaConta { get; protected set; }

    public Conta(int numeroConta, string titularConta) 
    { 
        NumeroDaConta = numeroConta;
        TitularDaConta = titularConta;
        SaldoDaConta = 0;
    }

    public bool Depositar(decimal valorDeposito)
    {
        if (valorDeposito <= 0)
        {
            return false;
        }

        SaldoDaConta += valorDeposito;
        return true;
    }

    public bool Sacar(decimal valorSaque)
    {
        if (valorSaque <= 0 || valorSaque > SaldoDaConta)
        {
            return false;
        }

        if (valorSaque > SaldoDaConta)
        {
            return false;
        }

        SaldoDaConta -= valorSaque;
        return true;
    }

    public bool Transferir(decimal valorTransferencia, Conta contaDestino)
    {
        if (contaDestino == null) 
        { 
            return false;
        }

        if (!Sacar(valorTransferencia))
        {
            return false;
        }

        contaDestino.Depositar(valorTransferencia);
        return true;
    }
}