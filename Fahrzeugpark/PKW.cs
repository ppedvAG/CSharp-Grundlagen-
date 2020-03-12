using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //PKW erbt mittels des :-Zeichens von der Fahrzeug-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    ///Zusätzlich implementiert diese Klasse das Interface IBewegbar.
    public class PKW : Fahrzeug, IBewegbar
    {
        //Zusätzliche PKW-eigene Eigenschaft
        public int AnzahlTüren { get; set; }

        //Durch Interface verlangte Eigenschaft
        public int AnzahlRäder { get; set; }

        //PKW-Konstruktor, welcher per BASE-Stichwort den Konstruktor der Fahrzeugklasse aufruft. Dieser erstellt dann ein Fahrzeug, gibt dies
        ///an diesen Konstruktor zurück, welcher dann die zusätzlichen Eigenschaften einfügt
        public PKW(string name, int maxG, decimal preis, int anzTüren) : base(name, maxG, preis)
        {
            this.AnzahlTüren = anzTüren;
            this.AnzahlRäder = 4;
        }

        //Per OVERRIDE werden virtuelle und abstrakte Methoden der Mutterklasse überschrieben. Bei dem Methodenaufruf wir die Methode der
        ///Kindklasse aufgerufen
        public override string BeschreibeMich()
        {
            //Mittels des BASE-Stichworts wird auf die Methode der Mutterklasse zugegriffen
            return "Der PKW " + base.BeschreibeMich() + $" Er hat {this.AnzahlTüren} Türen.";
        }

        //Durch Mutterklasse geforderte (weil als ABSTRACT gesetzte) Funktion
        public override void Hupe()
        {
            Console.WriteLine("HupHup");
        }

        //Durch Interface verlangte Methode
        public void BaueUnfall()
        {
            Console.WriteLine("Du hast einen Baum übersehen.");
            AnzahlRäder--;
        }

        //Statische Methode (gilt für die gesamte Klasse) zur Erstellung eines zufälligen PKWs 
        private static Random generator = new Random();
        public static PKW ErzeugeZufälligenPKW(string plusName)
        {
            string name;
            switch (generator.Next(1, 5))
            {
                case 1:
                    name = "BMW" + plusName;
                    break;
                case 2:
                    name = "Mercedes" + plusName;
                    break;
                case 3:
                    name = "Audi" + plusName;
                    break;
                default:
                    name = "VW" + plusName;
                    break;
            }
            return new PKW(name, generator.Next(15, 31) * 10, generator.Next(15, 30) * 1000, generator.Next(1, 3) == 1 ? 3 : 5);
        }
    }
}
