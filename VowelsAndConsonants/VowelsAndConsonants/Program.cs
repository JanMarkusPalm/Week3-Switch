using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutajal sisestada tähte
            //programm kontrollib, kas sisestatud täht on täishäälik või kaashäälik
            //kui sisestatud täht on täishäälik, programm kuvab "täishäälik"
            //kui sisestatud täht on kaashäälik, programm kuvab "kaashäälik"
            //kasutame switchi

            Console.WriteLine("Sisesta täht.");
            char userchar = Convert.ToChar(Console.ReadLine().ToLower());

            switch (userchar)
            {

                case 'a': Console.WriteLine("Täishäälik"); break;
                case 'e': Console.WriteLine("Täishäälik"); break;
                case 'i': Console.WriteLine("Täishäälik"); break;
                case 'o': Console.WriteLine("Täishäälik"); break;
                case 'u': Console.WriteLine("Täishäälik"); break;
                case 'ü': Console.WriteLine("Täishäälik"); break;
                case 'õ': Console.WriteLine("Täishäälik"); break;
                case 'ö': Console.WriteLine("Täishäälik"); break;
                case 'ä': Console.WriteLine("Täishäälik"); break;

                default: Console.WriteLine("Kaashäälik"); break;


            }



        }
    }
}
