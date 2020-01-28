using System;

namespace Jaso
{
class ClassA
{
    public int Vijf = 5;
    public void Rekensom()
    {
        int Vier = 4;
        Console.WriteLine("Dit is een tijdelijke variabel in een andere namespace " + Vier);
        Console.WriteLine("Het is een variabel in een andere namespace " + Vijf);
        {
            int Zes = 6;
            Console.WriteLine("Dit is mijn tijdelijke variabel in een body " + Zes);
        }
    }
}
}
