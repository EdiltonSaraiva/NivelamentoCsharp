using System.Security.Authentication;

namespace ListaDeComprasInteligente;

public class Program
{
    public static void Main()
    {
        string MensagemLista = "--------LISTA DE COMPRAS--------";

        Console.WriteLine(MensagemLista);

        List<string> ListaDeCompras = new List<string>();
        List<string> ComprasConcluidas = new List<string>();

        bool PararCompras = false;
        string Separador = "--------------------------------";

        while (PararCompras == false)
        {
            if (PararCompras == false)
            {
                if (ListaDeCompras.Count == 0)
                {
                    Console.WriteLine("A lista de compras está vazia. Adicione itens para continuar.");
                    Console.Write("\nDigite o nome do item que deseja adicionar:\t");
                    string AdicionaItem = Console.ReadLine();
                    ListaDeCompras.Add(AdicionaItem);
                    Console.WriteLine("\n" + Separador);
                    Console.WriteLine($"'{AdicionaItem}' adicionado com SUCESSO!");
                    Console.WriteLine(Separador + "\n");
                    Console.WriteLine("Lista ATUALIZADA!\n");

                }

                Console.WriteLine(MensagemLista);

                int ContaItens = 1;
                foreach (string ItemNaLista in ListaDeCompras)
                {
                    Console.WriteLine($"{ContaItens}. {ItemNaLista}");
                    ContaItens++;
                }
                Console.WriteLine(Separador);

                ContaItens = 1;

                Console.WriteLine("\nEscolha uma opção:\n");
                Console.WriteLine("1. Adicionar item");
                Console.WriteLine("2. Remover item");
                Console.WriteLine("3. Marcar item como concluído");
                Console.WriteLine("4. Sair\n");

                Console.Write("Digite o número da opção desejada:\t");
                int OpcaoEscolhida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n" + MensagemLista);
                foreach (string ItemNaLista in ListaDeCompras)
                {
                    Console.WriteLine($"{ContaItens}. {ItemNaLista}");
                    ContaItens++;
                }
                Console.WriteLine(Separador);
            }
        }
    }
}