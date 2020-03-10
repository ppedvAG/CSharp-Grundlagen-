using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallszahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schleife zum Wdh des Programms
            do
            {
                //Deklarationen
                Random generator;
                int zufallszahl, benutzerzahl;

                //Initialisierung eines Random-Objekts mittels Konstruktor-Aufruf (vgl. Modul 04)
                generator = new Random();
                //Aufruf der Würfel-Funktion des Random-Objekts (beachte: 1. Grenze inklusiv / 2. Grenze exklusiv)
                zufallszahl = generator.Next(1, 6);

                //Schleife für erneuten Versuch
                do
                {
                    //Abfrage des Tipps des Benutzers
                    Console.Write("Bitte gib eine Zahl zwischen 1 und 5 ein: ");
                    benutzerzahl = int.Parse(Console.ReadLine());

                    //Vergleich Tipp <> Zufallszahl mittels If
                    if (benutzerzahl < zufallszahl)
                        Console.WriteLine("Deine Zahl ist zu klein");
                    else if (benutzerzahl > zufallszahl)
                        Console.WriteLine("Deine Zahl ist zu groß");
                    else
                        Console.WriteLine("Herzlichen Glückwunsch, du hast die Zahl getroffen");

                    //Bedingung für neuen Versuch (= falsche Zahl getippt)
                } while (zufallszahl != benutzerzahl);

                //Bedingung für Wiederholung (Benutzer muss Taste 'Y' drücken)
                Console.WriteLine("Soll das Programm wiederholt werden? (Y/N)");
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);

        }
    }
}
