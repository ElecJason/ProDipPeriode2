using System;

namespace populationControl2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Person person1 = new Person();
                person1.name = "Pieter Worst";
                person1.eyeColour = "Red";
                person1.length = 192;
                person1.age = 81;
                person1.countryOfBirth = "Nederland";
                person1.bsn = 77741277;

            Person person2 = new Person();
                person2.name = "Frederik Engerd";
                person2.eyeColour = "Blue";
                person2.length = 155;
                person2.age = 20;
                person2.countryOfBirth = "Netherlands";
                person2.bsn = 888888888;

            Person person3 = new Person();
                person3.name = "Marcobus Oliver";
                person3.eyeColour = "Yellow";
                person3.length = 167;
                person3.age = 54;
                person3.countryOfBirth = "Netherlands";
                person3.bsn = 129993299;

            Person person4 = new Person();
                person4.name = "Felix Kjellberg";
                person4.eyeColour = "Blue";
                person4.length = 160;
                person4.age = 40;
                person4.countryOfBirth = "Netherlands";
                person4.bsn = 2232226222;

            Person person5 = new Person();
                person5.name = "Michiel de Ruyter";
                person5.eyeColour = "Blue";
                person5.length = 151;
                person5.age = 45;
                person5.countryOfBirth = "Netherlands";
                person5.bsn = 123456789;

            Console.WriteLine(person1.name);
            Console.WriteLine(person2.name);
            Console.WriteLine(person3.name);
            Console.WriteLine(person4.name);
            Console.WriteLine(person5.name);

        }
    }
}
