namespace ContaBancaria.Models;

public abstract class Conta
{
    public int NumeroDaConta { get; set; }
    public string? TitularDaConta { get; set; }
    public decimal SaldoDaConta { get; protected set; }

    public abstract void Depositar(double valorDeposito);
    public abstract void Sacar(double valorSaque);
    public abstract void Transferir(double valorTransferencia, ContaCorrente contaDestino);
}