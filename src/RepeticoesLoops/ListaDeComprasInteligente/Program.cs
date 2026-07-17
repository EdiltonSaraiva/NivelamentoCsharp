using System.Security.Authentication;

namespace ListaDeComprasInteligente;

public class Program
{
    public static void Main()
    {
        string MensagemLista = "--------LISTA DE COMPRAS--------";
        string MensagemComprasConcluidas = "-------COMPRAS CONCLUÍDAS-------";

        Console.WriteLine(MensagemLista);

        List<string> ListaDeCompras = new List<string>();
        List<string> ComprasConcluidas = new List<string>();

        bool PararListaDeCompras = false;
        string Separador = "--------------------------------";
        string AdicionaItem = "";
        int NumeroItemUsario = 0;

        while (PararListaDeCompras == false)
        {
            if (PararListaDeCompras == false)
            {
                if (ListaDeCompras.Count == 0)
                {
                    Console.WriteLine("A lista de compras está vazia. Adicione itens para continuar.");
                    Console.Write("\nDigite o nome do item que deseja adicionar:\t");
                    AdicionaItem = Console.ReadLine();
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
                Console.WriteLine("3. Marcar item comprado");
                Console.WriteLine("4. Sair\n");

                Console.Write("Digite o número da opção desejada:\t");
                int OpcaoEscolhida = Convert.ToInt32(Console.ReadLine());

                switch (OpcaoEscolhida)
                {
                    case 1:
                        Console.Write("\nDigite o nome do item que deseja adicionar:\t");
                        AdicionaItem = Console.ReadLine();

                        ListaDeCompras.Add(AdicionaItem);

                        Console.WriteLine("\n" + Separador);
                        Console.WriteLine($"'{AdicionaItem}' adicionado com SUCESSO!");
                        Console.WriteLine(Separador + "\n");

                        Console.WriteLine("Lista ATUALIZADA!\n");
                        break;
                    case 2:
                        Console.WriteLine("\n" + MensagemLista);
                        foreach (string ItemNaLista in ListaDeCompras)
                        {
                            Console.WriteLine($"{ContaItens}. {ItemNaLista}");
                            ContaItens++;
                        }
                        Console.WriteLine(Separador);

                        Console.Write("\nDigite o número do item que deseja remover:\t");
                        NumeroItemUsario = Convert.ToInt32(Console.ReadLine());
                        int RemoveItem = NumeroItemUsario - 1;

                        if (ListaDeCompras.Count > 0)
                        {
                            ContaItens = 1;

                            Console.WriteLine("\n" + MensagemLista);
                            foreach (string ItemNaLista in ListaDeCompras)
                            {
                                Console.WriteLine($"{ContaItens}. {ItemNaLista}");
                                ContaItens++;
                            }
                            Console.WriteLine(Separador);

                            Console.WriteLine("\n" + Separador);
                            Console.WriteLine($"'{ListaDeCompras[RemoveItem]}' removido com SUCESSO!");
                            Console.WriteLine(Separador + "\n");

                            ListaDeCompras.RemoveAt(RemoveItem);

                            Console.WriteLine("Lista ATUALIZADA!\n");
                            break;
                        }
                        else if (RemoveItem > ListaDeCompras.Count)                         
                        {
                            Console.WriteLine($"\nNúmero INVÁLIDO, não EXISTE um item {NumeroItemUsario} na Lista!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nResposta INVÁLIDA. Tente novamente!");
                            break;
                        }
                    case 3:
                        Console.WriteLine(MensagemLista);
                        foreach (string ItemNaLista in ListaDeCompras)
                        {
                            Console.WriteLine($"{ContaItens}. {ItemNaLista}");
                            ContaItens++;
                        }
                        Console.WriteLine(Separador);

                        Console.Write("\nDigite o número do item que já foi comprado:\t");
                        NumeroItemUsario = Convert.ToInt32(Console.ReadLine());
                        int CompraItem = NumeroItemUsario - 1;

                        if (ListaDeCompras.Count > 0)
                        {
                            //ContaItens = 1;
                            //Console.Write(MensagemComprasConcluidas);

                            //foreach (string ItemComprado in ComprasConcluidas)
                            //{
                            //    Console.WriteLine($" - {ItemComprado}");
                            //    ContaItens++;
                            //}
                            //Console.WriteLine(Separador + "\n");

                            ComprasConcluidas.Add(ListaDeCompras[CompraItem]);

                            Console.WriteLine("\n" + Separador);
                            Console.WriteLine($"'{ListaDeCompras[CompraItem]}' comprado com SUCESSO!");
                            Console.WriteLine(Separador + "\n");

                            ListaDeCompras.RemoveAt(CompraItem);

                            Console.WriteLine("Lista ATUALIZADA!\n");
                            break;
                        }
                        else if (ListaDeCompras.Count == 0)
                        { 
                            Console.WriteLine("\nNão há NENHUM item na sua lista.\nAdicione itens para conseguir MARCAR como comprado.");
                        }
                        else
                        {
                            Console.WriteLine("\nResposta INVÁLIDA. Tente novamente!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nCompras ENCERRADAS!");
                        PararListaDeCompras = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;
                }
                if (ComprasConcluidas.Count == 0)
                {
                    Console.WriteLine(MensagemComprasConcluidas);
                    Console.WriteLine("Nenhum item foi comprado ainda.");
                    Console.WriteLine(Separador);
                }
                else
                {
                    ContaItens = 1;
                    Console.WriteLine(MensagemComprasConcluidas);

                    foreach (string ItemComprado in ComprasConcluidas)
                    {
                        Console.WriteLine($" - {ItemComprado}");
                        ContaItens++;
                    }
                    Console.WriteLine(Separador + "\n");
                }
            }
        }
    }
}