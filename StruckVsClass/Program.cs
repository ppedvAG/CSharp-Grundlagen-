using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVSClass
{
    //vgl. Modul 4 -> Fahrzeug
    class PersonC
    {
        public string name;
        public int alter;

        public PersonC(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
    }

    //STRUCTS sind Klassenähnliche Konstrukte, welche nicht, wie Klassen, als Referenztypen behandelt werden, sondern ein Wertetyp sind. D.h
    //bei Übergabe eines Structs an eine Methode oder Variable wird eine Kopie dieses Objekts erstellt
    struct PersonS
    {
        public string name;
        public int alter;

        public PersonS(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
    }


    class Program
    {
        public static void Altern(PersonC person)
        {
            person.alter++;
        }

        public static void Altern(PersonS person)
        {
            person.alter++;
        }

        //Mittels des REF-Stichworts können Wertetypen als Referenz an Methoden übergeben werden. D.h. die übergebene Speicherstelle selbst 
        ///wird manipuliert und nicht, wie normalerweise bei Wertetypen, eine Kopie des Werts.
        public static void Altern(ref PersonS person)
        {
            person.alter++;
        }

        static void Main(string[] args)
        {
            //Erstellung von Objekten
            PersonC KlassenPerson = new PersonC("Anna", 29);
            PersonS StructPerson = new PersonS("Otto", 29);

            //Ausgabe
            Console.WriteLine($"{KlassenPerson.name}: {KlassenPerson.alter}");
            Console.WriteLine($"{StructPerson.name}: {StructPerson.alter}");

            //Funktionsaufruf
            Altern(KlassenPerson);
            Altern(StructPerson);

            //Erneute Ausgabe: Nur das Klassenobjekt (Referenztyp) hat sich verändert
            Console.WriteLine($"{KlassenPerson.name}: {KlassenPerson.alter}");
            Console.WriteLine($"{StructPerson.name}: {StructPerson.alter}");

            //Übergabe des Wertetyps als Refernz mittels Ref-Stichwort
            Altern(ref StructPerson);
            Console.WriteLine($"{StructPerson.name}: {StructPerson.alter}");

            Console.ReadKey();
        }
    }
}
