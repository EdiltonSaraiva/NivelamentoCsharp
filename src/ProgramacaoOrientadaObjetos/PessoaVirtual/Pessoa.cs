class Pessoa
{
    private string? _nomeDaPessoa;
    private int _idadeDaPessoa;
    private string? _cidadeDaPessoa;

    public Pessoa(string nomePessoa, int idadePessoa, string cidadePessoa)
    {
        _nomeDaPessoa = nomePessoa;
        _idadeDaPessoa = idadePessoa;
        _cidadeDaPessoa = cidadePessoa;

        Mensagem();
    }

    private void Mensagem()
    {
        Console.WriteLine($"Olá, meu nome é {_nomeDaPessoa}, tenho {_idadeDaPessoa} anos e moro em {_cidadeDaPessoa}."); 
    }
}