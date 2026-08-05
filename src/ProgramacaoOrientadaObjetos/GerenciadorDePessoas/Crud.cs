namespace GerenciadorDePessoas;

class Crud : Padrao
{
    public override void Alterar()
    {
        Console.WriteLine("\n------LISTA DE PESSOAS------\n");

        for (int pessoaNaLista = 0; pessoaNaLista < Armazenamento.pessoas.Count; pessoaNaLista++)
        {
            Console.WriteLine($"{pessoaNaLista + 1}) {Armazenamento.pessoas[pessoaNaLista].NomeDaPessoa}");
        }

        Console.Write("Informe o código da pessoa que deseja alterar os dados:\t");
        int codigoDaPessoa = Convert.ToInt16(Console.ReadLine());

        Pessoa pessoa = new Pessoa();

        Console.Write("\nInforme o nome da pessoa:\t");
        pessoa.NomeDaPessoa = Console.ReadLine();

        Console.Write("Informe o nome da cidade:\t");
        pessoa.NomeCidade = Console.ReadLine();

        Console.Write("Informe a idade da pessoa:\t");
        pessoa.IdadeDaPessoa = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"{pessoa.NomeDaPessoa} foi alterado com sucesso!\n");

        Armazenamento.pessoas[codigoDaPessoa - 1] = pessoa;
    }

    public override void Cadastrar()
    {
        Pessoa pessoa = new Pessoa();

        Console.Write("\nInforme o nome da pessoa:\t");
        pessoa.NomeDaPessoa = Console.ReadLine();

        Console.Write("Informe o nome da cidade:\t");
        pessoa.NomeCidade = Console.ReadLine();

        Console.Write("Informe a idade da pessoa:\t");
        pessoa.IdadeDaPessoa = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine($"{pessoa.NomeDaPessoa} foi cadastrado com sucesso!\n");

        Armazenamento.pessoas.Add(pessoa);
    }

    public override void Remover()
    {
        Console.WriteLine("\n------LISTA DE PESSOAS------\n");

        for (int pessoaNaLista = 0; pessoaNaLista < Armazenamento.pessoas.Count; pessoaNaLista++)
        {
            Console.WriteLine($"{pessoaNaLista + 1}) {Armazenamento.pessoas[pessoaNaLista].NomeDaPessoa}");
        }

        Console.Write("Informe o código da pessoa que deseja remover da lista:\t");
        int codigoDaPessoa = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Removido com sucesso!\n");

        Armazenamento.pessoas.RemoveAt(codigoDaPessoa - 1);
    }

    public override void Selecionar()
    {
        Console.WriteLine("\n------LISTA DE PESSOAS------\n");

        for (int pessoaNaLista = 0; pessoaNaLista < Armazenamento.pessoas.Count; pessoaNaLista++)
        {
            Console.WriteLine($"Nome: {Armazenamento.pessoas[pessoaNaLista].NomeDaPessoa}");
            Console.WriteLine($"Cidade: {Armazenamento.pessoas[pessoaNaLista].NomeCidade}");
            Console.WriteLine($"Idade: {Armazenamento.pessoas[pessoaNaLista].IdadeDaPessoa}\n");
        }
    }
}