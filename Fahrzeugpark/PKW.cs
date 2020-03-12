using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //PKW erbt mittels des :-Zeichens von der Fahrzeug-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    public class PKW : Fahrzeug, IBewegbar
    {
        //Zusätzliche PKW-eigene Eigenschaft
        public int AnzahlTüren { get; set; }

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

        public void BaueUnfall()
        {
            Console.WriteLine("Du hast einen Baum übersehen.");
            AnzahlRäder--;
        }
    }
}
