using System;

namespace populationControl2
{
    public class Person
    {
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {  
                int countWords = value.Split().Length;

                if (countWords <= 4)
                {
                    foreach (char c in value)
                    {
                        if (char.IsDigit(c))
                        {
                            Console.WriteLine("NO DIGITS BITCH");
                            break;
                        }
                    }
                    _name = value;
                    return;
                }
                Console.WriteLine("TOO LONG BITCH");
            }
        }
        
        private string _eyeColour;
        public string eyeColour
        {
            get
            {
                return _eyeColour;
            }
            set
            {
                foreach (string info in EyeColourList.EYELIST)
                {
                    if (value == info)
                    {
                        _eyeColour = value;
                        return;
                    }
                }
                Console.WriteLine("Unknown or incorrect EyeColour.");
            }
        }

        private int _length;
        public int length
        { 
            get
            {
                return _length;
            }
            set
            {   
                if (value > 54 || value < 231)
                {
                    _length = value;
                    return;
                }
                else
                {
                    length = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        private int _age;
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 || value < 100)
                {
                    _age = value;
                    return;
                }
                Console.WriteLine("Invalid age");
            }
        }

        private string _countryOfBirth;
        public string countryOfBirth
        {
            get
            {
                return _countryOfBirth;
            }
            set
            {
                foreach (string info in CountryList.COUNTRYLIST)
                {
                    if (value == info)
                    {
                        _countryOfBirth = value;
                        return;
                    }
                }
                Console.WriteLine("Unknown or incorrect country of Orgin.");
            }
            
        }

        private long _bsn;
        public long   bsn
        {
            get
            {
                return _bsn;
            }
            set
            {
                if (value.ToString().Length == 9)
                {
                     _bsn = value ;
                }
            }
        }



    }
}
