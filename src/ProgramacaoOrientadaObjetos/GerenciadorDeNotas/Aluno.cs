class Aluno
{
    public string? NomeDoAluno { get; set; }
    public double NotaUm { get; set; }
    public double NotaDois { get; set; }

    private double MediaDasNotas()
    {
        return (NotaUm + NotaDois) / 2;
    }

    private string SitaucaoDoAluno(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    public void MensagemDeSituacao()
    {
        double obterMedia = MediaDasNotas();
        string obterSituacao = SitaucaoDoAluno(obterMedia);
        Console.WriteLine($"O aluno {NomeDoAluno} está {obterSituacao} com média {obterMedia}");
    }
}