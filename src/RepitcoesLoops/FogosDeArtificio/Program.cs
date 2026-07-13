namespace FogosDeArtificio;

public class Program
{
    public static void Main()
    {
        Console.Write("Digite o ano da explosão de fogos:\t");
        int AnoDaExplosao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\n----------EXPLOSÃO DE FOGOS ANO {AnoDaExplosao}---------\n");

        int NumeroDeContagem = 10;

        Console.WriteLine("Contagem regressiva para a explosão de fogos:\n");

        do
        {
            Console.Write($"{NumeroDeContagem}  ");
            NumeroDeContagem--;
        } while (NumeroDeContagem >= 0);

        int ContagemDeFogos = 1;
        Console.WriteLine("\n");

        do
        {
            Console.WriteLine(".+.°.+´.º+.´´.º+.°.+´.º+.´´.º+.°.+´.º+.´´.º.");
            ContagemDeFogos++;
        } while (ContagemDeFogos <= 5);

        Console.WriteLine($"\n                FELIZ {AnoDaExplosao + 1}!\n");

    }
}