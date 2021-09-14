using System;

namespace ControlFlow_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutajalt sisestada pin koodi
            //programm võrdleb siis sisestatud pin koodi arvuga 1234
            //kui sisestatud PIN kood on 1234, programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud Pin kood on vale, programm kuvab konsoolis "Vale PIN. Proovi uuesti"

            Console.WriteLine("Sisestage PIN kood palun");

            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number == 1234)               //if (Number != 1234) "!" on "ei võrdu"
            {
                Console.WriteLine("Tere tulemast!");
            }

            else
            {
                Console.WriteLine("Vale PIN. Proovi uuesti");
            }

            













        }
    }
}
