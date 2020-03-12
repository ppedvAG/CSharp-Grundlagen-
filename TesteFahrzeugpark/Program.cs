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

            #region Modul06: Interfaces und Polymorphismus
            ////Instanzierung von Bsp-Objekt
            //PKW pkw1 = new PKW("BMW", 190, 23000, 4);
            ////Aufruf der Interface-Methode
            //pkw1.Crash();

            ////Zuweisung neuer Variablen (anderer Variablentyp) mit dem PKW-Objekt
            ////-> Variablentyp definiert 'Sichtbarkeit' der Eigenschaften
            //Fahrzeug fz1 = pkw1;
            //IBewegbar bewegbaresObjekt = pkw1;

            ////BSP: Variablentyp = Fahrzeug | Laufzeittyp (= Typ des Objekts) = PKW
            //Fahrzeug fz2 = new PKW("VW", 190, 25000, 3);

            ////Prüdung, ob in Fahrzeug-Variable ein PKW-Objekt liegt...
            //if (fz2 is PKW)
            //{
            //    //... wenn ja, dann Cast in PKW und Zuweisung zu PKW-Variable
            //    PKW pkw2 = (PKW)fz2;
            //}

            ////Aufruf der BSP-Funktion (s.u.)
            //MontiereNeuesRad(pkw1);
            #endregion

            #region Lab06: IBeladbar

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);

            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(flugzeug1, schiff1);
            //BeladeFahrzeuge(schiff1, pkw1);

            //Console.WriteLine("\n" + schiff1.BeschreibeMich());

            #endregion

            List<string> StädteListe = new List<string>();

            StädteListe.Add("Berlin");
            StädteListe.Add("Hamburg");
            StädteListe.Add("München");
            StädteListe.Add("Köln");
            StädteListe.Add("Dresden");

            Console.WriteLine(StädteListe[2]);

            StädteListe[4] = "Leipzig";

            Console.WriteLine(StädteListe.Count);

            for (int i = 0; i < StädteListe.Count; i++)
            {
                Console.WriteLine(StädteListe[i]);
            }

            StädteListe.Remove("Köln");

            List<Fahrzeug> FahrzeugListe = new List<Fahrzeug>();

            FahrzeugListe.Add(new PKW("BMW", 250, 23000, 5));
            FahrzeugListe.Add(new Flugzeug("Boing", 750, 3000000, 9990));
            FahrzeugListe.Add(new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));

            foreach (var item in FahrzeugListe)
            {
                Console.WriteLine(item.BeschreibeMich());
            }

            Dictionary<string, Fahrzeug> Dict = new Dictionary<string, Fahrzeug>();

            Dict.Add("schwimmen", new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
            Dict.Add("fahren", new PKW("BMW", 250, 23000, 5));
            Dict.Add("fliegen", new Flugzeug("Boing", 750, 3000000, 9990));

            Console.WriteLine(Dict["fliegen"].Name);

            foreach (var item in Dict)
            {
                Console.WriteLine(item.Key + ": " + item.Value.Name);
            }

            Console.ReadKey();
        }

        //Methode Lab06
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            //Test, ob fz1 IBeladbar implementiert hat..
            if (fz1 is IBeladbar)
            {
                //...wenn ja, dann Cast in IBeladbar und Aufruf der Belade()-Funktion
                ((IBeladbar)fz1).Belade(fz2);
            }
            //...wenn nein, dann Test, ob fz2 IBeladbar implementiert hat...
            else if (fz2 is IBeladbar)
            {
                //...wenn ja, dann (alternativer) Cast in IBeladbar und Aufruf der Belade()-Funktion
                (fz2 as IBeladbar).Belade(fz1);
            }
            //...wenn nein, dann Fehlermeldung
            else
                Console.WriteLine("Keines der Fahrzeuge kann ein Fahrzeug transportieren.");
        }

        //BSP-Funktion: Polymorphismus (Modul 06)
        //Funktion empfängt ein beliebiges Objekt, dass das Interface IBewegbar implementiert hat
        public static void MontiereNeuesRad(IBewegbar bewegbar)
        {
            //Manipulation der durch Interface definierten Eigenschaft
            bewegbar.AnzahlRäder++;

            //Test, ob Objekt ein Flugzeug ist...
            if (bewegbar is Flugzeug)
                //...wenn ja, dann Cast in Flugzeug und Manipulation der Flugzeug-Spezifischen Eigenschaft MaxFlughöhe
                ((Flugzeug)bewegbar).MaxFlughöhe -= 100;
        }

    }
}
