using System;

namespace Pro2calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nummer1;
            int Nummer2;                   //Variables for equation
            string operation;
            int answer;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("Noem het eerste getal van je berekening:");
            Nummer1 = Convert.ToInt32(Console.ReadLine());                             

            
            Console.WriteLine("Noem het tweede getal van je berekening: ");
            Nummer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voeg nu de berekening toe:  x , / , + , - , % ");
            operation = Console.ReadLine();

            if (operation == "x")
            {
            answer = multiply(Nummer1, Nummer2);
               Console.ReadLine();
            } 
            else if (operation == "+")
            {
            answer = plus(Nummer1, Nummer2);
               Console.ReadLine();
            }
            else if (operation == "/")
            {
            answer = devide(Nummer1, Nummer2);
               Console.ReadLine();
            }
            else if (operation == "-")
            {
            answer = minus(Nummer1, Nummer2);
               Console.ReadLine();
            }
            else if (operation == "%")
            {
            answer = modulo(Nummer1, Nummer2);
               Console.ReadLine();
            }                                                              
         }

         private static int multiply(int a, int b){
            int answer = a * b;
            Console.WriteLine(a+ "x" + b + "=" + answer);
            return answer;
         }
        private static int plus(int a, int b){
            int answer = a + b;
            Console.WriteLine(a+ "+" + b + "=" + answer);
            return answer;
         }
        private static int devide(int a, int b){
            int answer = a / b;
            Console.WriteLine(a+ "/" + b + "=" + answer);
            return answer;
         }
        private static int modulo(int a, int b){
            int answer = a % b;
            Console.WriteLine(a+ "%" + b + "=" + answer);
            return answer;
         }
        private static int minus(int a, int b){
            int answer = a - b;
            Console.WriteLine(a+ "-" + b + "=" + answer);
            return answer;
         }
    }
}
