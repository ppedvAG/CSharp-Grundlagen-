using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung von Beispiel-Variablen
            int a = 25;
            int b = 30;

            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            if (a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            //Es kann beliebig viele ELSE-IF-Blöcke geben
            else if (a > b)
            {
                Console.WriteLine("B ist kleiner als A");
            }
            //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
            else
                Console.WriteLine("A ist gleich B");

            //Kurznotation:
            //(Bedingung) ? TrueAusgabe : FalseAusgabe
            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife
            ///übersprungen
            while (a < b)
            {
                Console.WriteLine($"{a} ist kleiner als {b}");
                a++;

                //Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
                if (a == 28) break;
            }

            a = 200;

            //DO-WHILE-Schleife
            ///Auch die DO-WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst am Schleifen_
            ///ende geprüft, weshalb die Schleife mindestens einmal durchläuft.
            do
            {
                Console.WriteLine($"{a} ist kleiner als 100");
                a *= 2;

                //Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen. Ist die Bedingung wahr
                ///beginnt ein neuer Durchlauf
                continue;

            } while (a < 100);

            //FOR-Schleife
            ///Der FOR-Schleife wird ein Laufindex (i) sowie eine Bedingung und eine Anweisung übergeben. Am Ende jedes Durchlaufes wird die
            ///Anweisung ausgeführt. Wenn die Bedingung nicht (mehr) wahr ist, wird kein (weiterer) Schleifendurchlauf begonnen.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Dies ist Durchlauf Nr. {i}");
            }
            //Bsp einer For-Schleife von 1-1000 mit einer Verdoppelung des Index nach jedem Durchlauf
            for (int i = 1; i < 1000; i *= 2)
            {
                Console.WriteLine(i);
            }
            //Bsp für eine rückwärtslaufende Schleife von 10-1
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. Die Größe des Arrays muss bei der
            ///Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.
            int[] zahlen = new int[10];
            zahlen[0] = 5;

            int[] zahlenArray = { 2, 4, 5, 6, 78, 123456 };

            //Der Zugiff auf einzelne Array-Positionen erfolgt durch einen Nullbasierten Index
            Console.WriteLine(zahlenArray[2]);
            zahlenArray[2] = 855;
            Console.WriteLine(zahlenArray[2]);

            //Iteration über ein Array mittels For-Schleife
            for (int i = 0; i < zahlenArray.Length; i++)
            {
                Console.WriteLine(zahlenArray[i]);
            }

            //FOREACH-Schleifen können über Collections laufen und sprechen dabei jedes Element genau einmal an
            foreach (int item in zahlenArray)
            {
                Console.WriteLine(item);
            }

            //Mehrdimensionales Array
            int[,] mehrDimArray = new int[10, 10];
            mehrDimArray[0, 5] = 45;
            mehrDimArray[1, 5] = 102;

            for (int i = 0; i <= mehrDimArray.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= mehrDimArray.GetUpperBound(1); j++)
                {
                    mehrDimArray[i, j] = i * j;
                }
            }
            Console.WriteLine(mehrDimArray[8, 9]);

            //String als Char-Array
            string beispiel = "Hallo";
            Console.WriteLine(beispiel[3]);

            //Verwendung der Contains-Funktion eines Arrays (überprüft auf das Vorhandensein eines Elements)
            if (beispiel.Contains('o'))
                Console.WriteLine("Wort enthält o");

            //Bsp für Benutzereingabe in Array
            int[] benutzerarray = new int[3];
            for (int i = 0; i < benutzerarray.Length; i++)
            {
                Console.WriteLine("Gib eine Zahl zwischen 1 und 10 ein:");
                benutzerarray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Deine Eingaben: {benutzerarray[0]},{benutzerarray[1]},{benutzerarray[2]}");

            Console.ReadKey();

        }
    }
}
