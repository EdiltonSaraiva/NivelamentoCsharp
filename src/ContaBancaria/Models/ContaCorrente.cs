namespace ContaBancaria.Models;

public class ContaCorrente : Conta
{
    public ContaCorrente(int numeroConta, string titularConta) 
        : base(numeroConta, titularConta)
    {
    }
}