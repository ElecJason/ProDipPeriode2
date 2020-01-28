using System;
using Jaso;


namespace ProGotYouInMySight
{
    class Program
    {
        public void Rekensom1()
        {
            int GetalB = 20;
            Console.WriteLine("Dit is mijn variabel in een class" + GetalB);
            
        }
        
        static void Main(string[] args)
        {
            ClassA bla = new ClassA();
            
            bla.Rekensom();
            int Zeven = 7;
            Console.WriteLine("Dit is mijn tijdelijke variabel binnen een functie " + Zeven);
            
        }
    }
}
