namespace GerenciadorDeNotas;

public class Program
{
    public static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.NomeDoAluno = "Edilton Saraiva Lopes";
        aluno.NotaUm = 10;
        aluno.NotaDois = 10;
        aluno.MensagemDeSituacao();
    }
}