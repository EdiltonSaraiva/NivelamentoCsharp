using System.Transactions;

namespace  MediaNotas;
class Media 
{ 
    public Media(double primeiraNota, double segundaNota)
    {
        Console.WriteLine($"A média é {(primeiraNota + segundaNota) / 2}");
    }

    public Media(double primeiraNota, double segundaNota, double terceiraNota)
    {
        Console.WriteLine($"A média é {(primeiraNota + segundaNota + terceiraNota) / 3}");
    }
}