// See https://aka.ms/new-console-template for more information
using CardLinq;

public class Program
{
    private static readonly Random random = new Random();
    static void Main(string[] args)
    {
        Card card = new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
        Console.WriteLine(card.Name);
    }

}
 