namespace ContaBancaria;

abstract class Padrao
{
    public abstract void Depositar(double valor);
    public abstract void Sacar(double valor);
    public abstract void Transferir(double valor, ContaBancaria contaDestino);
    public abstract void ExibirSaldo();
    public abstract void ExibirDados();

    public void MenuDeOperacoesBancarias()
    {
        Console.WriteLine("_________OPERAÇÕES_________");
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Transferir");
        Console.WriteLine("4 - Exibir Saldo");
        Console.WriteLine("5 - Exibir Dados da Conta");
        Console.WriteLine("6 - Sair");
    }
}