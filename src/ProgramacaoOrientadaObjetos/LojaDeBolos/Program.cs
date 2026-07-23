namespace LojaDeBolos;

public class Program
{
    public static void Main()
    {
        Bolo boloDeMorango = new Bolo();

        boloDeMorango.IdBolo = 1;
        boloDeMorango.NomeDoBolo = "Morango Fantástico";
        boloDeMorango.SaborDoBolo = "Morango & Ninho";
        boloDeMorango.DescricaoBolo = "Uma combinação saborosa de morango e ninho, com recheio de geleia de morango\nsem açucar inrresistível. Contém leite, não indicado para intolerantes a lactose.";
        boloDeMorango.ComRecheio = true;
        boloDeMorango.PrecoBolo = 85;

        Bolo boloDeChocolate = new Bolo();

        boloDeChocolate.IdBolo = 2;
        boloDeChocolate.NomeDoBolo = "Cocolatudo";
        boloDeChocolate.SaborDoBolo = "Chocalate Amargo";
        boloDeChocolate.DescricaoBolo = "Clássico bolo de chocalate com cacau 70%. Contém leite, não indicado para intolerantes a lactose.";
        boloDeChocolate.ComRecheio = false;
        boloDeChocolate.PrecoBolo = 90;

        List<Bolo> listaDeBolos = new List<Bolo>();

        listaDeBolos.Add(boloDeMorango);
        listaDeBolos.Add(boloDeChocolate);

        Console.WriteLine("-------------------------------------------------OS BOLOS-------------------------------------------------\n");

        foreach (Bolo boloNaLista in listaDeBolos)
        {
            Console.WriteLine("NOME: " + boloNaLista.NomeDoBolo);
            Console.WriteLine("SABOR: " + boloNaLista.SaborDoBolo);
            Console.WriteLine("DESCRIÇÃO: " + boloNaLista.DescricaoBolo);
            Console.WriteLine("PREÇO: R$" + boloNaLista.PrecoBolo);
            Console.WriteLine("CÓDIGO: " + boloNaLista.IdBolo);
            Console.WriteLine("RECHEIO: " + boloNaLista.ComRecheio);
            Console.WriteLine();
        }
    }
}