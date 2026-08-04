namespace BeneficiosColaborador;

class Colaborador : IDesconto, IBonus
{
    public void PremioFaltas(int faltas)
    {
        Console.WriteLine(faltas == 0 ? "Bônus de R$300,00" : "Sem bônus!");     
    }
    public void ValeTransporte(double salarioBruto)
    {
        Console.WriteLine($"O desconto do vale transporte será de R${salarioBruto * 0.06}");
    }
}