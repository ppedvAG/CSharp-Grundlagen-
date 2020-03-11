﻿using System;
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

            //Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            //Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            Console.WriteLine(fz1.BeschreibeMich());

            //Diverse Methodenausführungen
            fz1.StarteMotor();
            fz1.Beschleunige(120);
            Console.WriteLine(fz1.BeschreibeMich());

            fz1.Beschleunige(300);
            Console.WriteLine(fz1.BeschreibeMich());

            fz1.StoppeMotor();
            Console.WriteLine(fz1.BeschreibeMich());

            #endregion
            Console.ReadKey();
        }
    }
}