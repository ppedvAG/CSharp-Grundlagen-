using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen
{
    class Program
    {
        //Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        ///Der Kopf besteht aus den MODIFIERN (public static), dem RÜCKGABEWERT (int), dem NAMEN (Addiere) sowie den ÜBERGABEPARAMETERN
        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        public static int Addiere(int a, int b, int c = 0, int d = 0)
        {
            int summe = a + b + c + d;
            //Der RETURN-Befehl weist die Methode an einen Wert als Rückgabewert an den Aufrufe zurückzugeben
            return summe;
        }

        //Funktion, welche den gleichen Bezeichner haben, nennt man ÜBERLADENE Funktionen. Diese müssen sich in Anzahl und/oder Art der 
        ///Übergabeparameter unterscheiden, damit der Aufruf eindeutig ist.
        public static double Addiere(double a, double b)
        {
            double c = a + b;
            return c;
        }

        //Das PARAMS-Stichwort erlaubt die Übergabe einer beliebige Anzahl von gleichartigen Daten, welche innerhalb
        //der Methode als Array interpretiert werden
        public static int AddiereBeliebigeAnzahl(params int[] summanden)
        {
            //Deklaration einer Integer-Hilfsvariablen und initialisierung auf 0
            int summe = 0;
            //Schleife über das übergebene Array
            foreach (var item in summanden)
            {
                //Hinzufügen der im Array betrachteten Zahl zur Variable
                summe += item;
            }
            //Rückgabe der Variablen
            return summe;
        }

        //Das OUT-Stichwort ermöglich einer Methode mehr als einen Rückgabewert zu haben. Dabei kann die Variable direkt in der Funktions-
        ///übergabe deklariert werden
        public static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }

        static void Main(string[] args)
        {
            //Aufruf der Addiere(int,int)-Funktion (optinale Parameter werden auf ihren Default-Wert gesetzt)
            int summe = Addiere(2, 45, 78);
            //Aufruf der gleichen Funktion unter Verwendung der optionalen Parameter
            summe = Addiere(12, 45, 78, 89);
            //Ausgabe
            Console.WriteLine(summe);

            //Aufruf der Addiere(double,double)-Funktion
            double summe2 = Addiere(12, 45.5);

            //Aufruf der Params-Funktion mit Übergabe eines Arrays, einer bleiebigen Anzahl von Ints und nichts
            summe = AddiereBeliebigeAnzahl(new int[] { 2, 4, 5 });
            summe = AddiereBeliebigeAnzahl(7, 8, 9, 45, 12, 741);
            summe = AddiereBeliebigeAnzahl();

            //Aufruf der Out-Funktion
            summe = AddiereUndSubtrahiere(45, 12, out int diff);
            Console.WriteLine($"{summe} | {diff}");

            //TryParse() als Bsp für Out-Verwendung
            string eingabe = "789";
            if (int.TryParse(eingabe, out int umgewandelterString))
            {
                Console.WriteLine(umgewandelterString * 2);
            }

            //Gegenbeispiel: Parse mit Prüfung (ohne TryParse)
            if (eingabe.All(x => char.IsDigit(x)))
            {
                Console.WriteLine(int.Parse(eingabe) * 2);
            }

            //Vorzeitiges Beenden der Konsolenapplikation
            Environment.Exit(0);

            Console.ReadKey();
        }
    }
}
