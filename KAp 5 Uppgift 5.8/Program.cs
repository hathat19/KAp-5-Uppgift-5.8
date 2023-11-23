using System;
namespace Uppgift5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //-------------------------------------------

            int[] nrs = { 3408, 189, 11118, 6969696, 422215 };
            string currentNr;

            //Loop per arrayindex
            for (int i = 0; i < nrs.Length; i++)
            {
                //Det aktuella numret omgjort till en string
                currentNr = nrs[i].ToString();

                //Loop för varje index i ett tal
                for (int j = 0; j < currentNr.Length; j++)
                {
                    Console.Write(currentNr[j]);
                    Thread.Sleep(100);
                }
                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }
    }
}
/*Skapa ett program som innehåller en int-array med 5 flersiffriga heltal. Programmet
ska skriva ut varje tal på en egen rad. Programmet ska ta en kort paus mellan
utskriften av varje siffra och en lite längre paus mellan varje tal.
Utnyttja att man kan omvandla ett tal till en sträng med hjälp av ToString().*/