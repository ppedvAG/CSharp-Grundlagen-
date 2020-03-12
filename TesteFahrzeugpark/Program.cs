using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Durch 'using Fahrzeugpark' kann ein Schnellzugriff auf den Namespace 'Fahrzeugpark' erfolgen
//Damit 'Fahrzeugpark' verwendet werden kann muss diese Bibliothek in den Refernezen angemeldet werden.
using Fahrzeugpark;

namespace TesteFahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.UTF8;

            #region Modul04: OOP
            ////Instanzierung der Fahrzeuge

            ////volle Pfadangabe bei Objekt/Variablenaufruf
            //Fahrzeugpark.Fahrzeug fz1 = new Fahrzeugpark.Fahrzeug("BMW", 250);

            ////Benutzung der using-Anweisung
            //Fahrzeug fz2 = new Fahrzeug("VW", 190);

            //Aufruf des paraeterlosen Konstruktors
            //Fahrzeug fz3 = new Fahrzeug();

            ////Ausgabe von fz1
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");

            ////Veränderung des Namens von fz1
            //fz1.Name = "Opel";
            ////Ausgabe der Fahrzeugeigenschaften (fz1 wurde verändert, fz2 nicht)
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");
            //Console.WriteLine(fz2.Name + ": " + fz2.MaxGeschwindigkeit + "km/h");

            ////Ausgabe der BeschreibeMich-Methode von fz1
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Neuzuweisung der fz2-Variable auf Objekt in fz1 (beide Variablen zeigen auf dasselbe Objekt)
            //fz2 = fz1;

            ////manueller Aufruf der GarbageCollection
            //GC.Collect();
            #endregion

            #region Lab04: Fahrzeug_Klasse

            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Diverse Methodenausführungen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.BeschreibeMich());

            #endregion

            #region Modul05: Vererbung

            ////Bsp-Objekt-Instanzierung
            //PKW pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);
            //pkw1 = new PKW("BMW", 190, 23000, 4);

            ////Aufruf der ToString()-Methode
            //Console.WriteLine(pkw1);
            ////Aufruf der Hupe()-Methode
            //pkw1.Hupe();

            ////Ausgabe von statischer Eingenschaft/Methode
            //Console.WriteLine(Fahrzeug.AnzahlErstellterFahrzeuge);
            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            #region Lab05: PKW-, Schiff- und Flugzeug-Klasse

            ////Instanzierung eines Bsp-PKWs
            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Console.WriteLine(pkw1.BeschreibeMich());
            //pkw1.Hupe();

            ////Instanzierung eines Bsp-Schiffs
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);
            //Console.WriteLine(schiff1.BeschreibeMich());
            //schiff1.Hupe();

            ////Instanzierung eines Bsp-Flugzeugs
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Console.WriteLine(flugzeug1.BeschreibeMich());
            //flugzeug1.Hupe();

            ////Ausgabe der statischen Methode der Fahrzeugklasse
            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            PKW pkw1 = new PKW("BMW", 230, 25000, 5);
            pkw1.BaueUnfall();


            Fahrzeug fz1 = pkw1;

            IBewegbar bewegbaresObjekt = pkw1;

            MontiereNeuesRad(pkw1);
            MontiereNeuesRad(new Flugzeug("Boing", 800, 20000000000, 9999));


            Console.ReadKey();
        }

        public static void MontiereNeuesRad(IBewegbar bewegbaresObjekt)
        {
            bewegbaresObjekt.AnzahlRäder++;

            if(bewegbaresObjekt is PKW)
            {
                PKW pkw1 = (PKW)bewegbaresObjekt;
                Console.WriteLine(pkw1.BeschreibeMich() + $" Er hat jetzt {pkw1.AnzahlRäder} Räder.");
            }
        }

    }
}
