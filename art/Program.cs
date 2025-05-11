using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

namespace Art
{
    class Programm
    {
        static void Main(string[] args)
        {

            // Funktio joka piirtää suorakulmion annettuun kohtaan
            // annetulla värillä
            // Parametrit: sarake, rivi, leveys, korkeus, väri
            void Suorakulmio(int sarake, int rivi, int leveys, int korkeus, ConsoleColor väri)
            {
                Console.BackgroundColor = väri;
                Console.SetCursorPosition(sarake, rivi);
                for (int piirtoRivi = 0; piirtoRivi < korkeus; piirtoRivi += 1)
                {
                    for (int piirtoSarake = 0; piirtoSarake < leveys; piirtoSarake += 1)
                    {
                        Console.Write(" ");
                    }
                    Console.SetCursorPosition(sarake, rivi + 1 + piirtoRivi);
                }
            }

            void Pallo(int sarake, int rivi, ConsoleColor väri)
            {
                Suorakulmio(sarake, rivi, 8, 4, väri);
                Suorakulmio(sarake - 2, rivi + 1, 12, 2, väri);
            }


            Pallo(12, 8, ConsoleColor.Green);

            for (int pallorivi = 0; pallorivi < 4; pallorivi += 1)
            {
                for (int pallosarake = 0; pallosarake < 4; pallosarake += 1)
                {
                    int rivi = pallorivi * 6;
                    int sarake = 2 + pallosarake * 14;
                    Pallo(2 + pallosarake * 14, pallorivi * 6, ConsoleColor.Green);
                    Console.SetCursorPosition(sarake, rivi + 2);
                    Console.Write("P: " + pallosarake + "," + pallorivi);
                }
            }
            /*
            Suorakulmio(8, 4, 8, 4, ConsoleColor.DarkMagenta);
            Suorakulmio(7, 5, 12, 2, ConsoleColor.DarkMagenta);
            */

            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            / Console.Clear();/
            // Kutsu funktiota Suorakulmio
            for (int aurinko = 0; aurinko < 6; aurinko += 1)
            {
                // muuttuja aurinko saa arvot 0,1,2,3,4,5
                Suorakulmio(aurinko * 10, 3 + aurinko, 8, 4, ConsoleColor.Yellow);
            }
            Suorakulmio(3, 3, 8, 4, ConsoleColor.Yellow);
            Suorakulmio(12, 6, 12, 6, ConsoleColor.Red);



            /*
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(3, 3);
            // piirtää monta rivejä
            for (int rivi = 0; rivi < 4; rivi += 1)
            {
                // Piirtää yhden rivin
                for (int sarake = 0; sarake < 8; sarake += 1)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(3, 4 + rivi);
            }
            */




            //Animaatiotesti
            Console.Clear();
            int animaatioSarake = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(33);
                Console.Clear();

                // Posta edellinnen x
                animaatioSarake += 1;
                Console.SetCursorPosition(animaatioSarake, 1);
                Console.Write("");

                //Siirry etenpäin ja piirrä X
                animaatioSarake += 1;
                Console.SetCursorPosition(animaatioSarake, 1);
                Console.Write("X");
                if (animaatioSarake >= Console.WindowWidth)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.Write("Loppu");

            // Ohjelma loppuu
            Console.ReadKey();

        }
    }
}
