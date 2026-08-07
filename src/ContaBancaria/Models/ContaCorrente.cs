namespace ContaBancaria.Models;

public class ContaCorrente : Conta
{
    public override void Depositar(double valorDeposito)
    {
        throw new NotImplementedException();
    }

    public override void Sacar(double valorSaque)
    {
        throw new NotImplementedException();
    }

    public override void Transferir(double valorTransferencia, ContaCorrente contaDestino)
    {
        throw new NotImplementedException();
    }
}