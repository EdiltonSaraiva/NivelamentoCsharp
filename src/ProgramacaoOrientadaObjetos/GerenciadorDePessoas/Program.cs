namespace GerenciadorDePessoas;

public class Program 
{
    public static void Main()
    {
        int acaoDesejada;

        Crud crud = new Crud();

        do 
        {
            Console.WriteLine("-------GERENCIADOR DE PESSOAS-------");
            Console.WriteLine("1 | Cadastrar");
            Console.WriteLine("2 | Selecionar");
            Console.WriteLine("3 | Alterar");
            Console.WriteLine("4 | Remover");
            Console.WriteLine("5 | Finalizar");
            Console.Write("Informe o número da ação que deseja executar:\t");
            acaoDesejada = Convert.ToInt16(Console.ReadLine());

            switch (acaoDesejada)
            {
                case 1:
                    crud.Cadastrar();
                    break;
                case 2:
                    crud.Selecionar();
                    break;
                case 3:
                    crud.Alterar();
                    break;
                case 4:
                    crud.Remover();
                    break;
                case 5:
                    Console.WriteLine("O Gerenciador de Pessoas foi finalizado!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        } while (acaoDesejada != 5);
    }
}