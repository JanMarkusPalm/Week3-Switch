using System;

namespace InstagramAgeProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis aastal sa sündisid?");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age > 13) 
            {
                Console.WriteLine("Te võite luua INSTAGRAM konto endale!");
            }
            else if (Age < 13)
            {
                Console.WriteLine("Te olete liiga noor et luua INSTAGRAM konto");
            }

            else
            {
                Console.WriteLine("Te olete täpselt 13!");
            }


       }
    }
}
