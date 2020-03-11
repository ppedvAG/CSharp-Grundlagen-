using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
	public class Fahrzeug
	{
		#region Felder und Eigenschaften
		//FELDER (Membervariablen) sind die Variablen einzelner Objekte, welche die Zustände dieser Objekte definieren
		private int maxGeschwindigkeit;
		//EIGENSCHAFTEN (Properties) definieren mittels Getter/Setter den Lese-/Schreibzugriff für jeweils ein Feld.
		///In den Eigenschaften können bestimmte Bedingungen für das Lesen und Schreiben der Felder gesetzt werden, sowie der Zugriff
		///für Lesen und Schreiben einzeln angepasst werden
		//Snippet: propfull
		public int MaxGeschwindigkeit
		{
			get { return maxGeschwindigkeit; }
			set
			{
				//Das Schlüsselwort VALUE beschreibt in einer Set-Methode den übergebenen Wert
				if (value >= 0)
					maxGeschwindigkeit = value;
			}
		}

		//Wird in einer Eigenschaft keine Spezifizierung angegeben, generiert das Programm das entsprechende Feld unsichtbar im Hintergrund
		//Snippet: prop
		public string Name { get; set; }
		public decimal Preis { get; set; }
		public int AktGeschwindigkeit { get; set; }
		public bool MotorLäuft { get; set; } // := Zustand

		#endregion

		#region Konstruktor und Destruktor
		//KONSTRUKTOREN sind spezielle Methoden, welche ein neues Objekt instanziiert und den Anfangszustand festlegt. Sie definieren sich
		///durch den Namen (derselbe, wie die Klasse) und den nicht vorhandenen Rückgabetyp (nicht mal void)
		public Fahrzeug(string name, int maxG, decimal preis)
		{
			this.Name = name;
			this.MaxGeschwindigkeit = maxG;
			this.Preis = preis;
			this.AktGeschwindigkeit = 0;
			this.MotorLäuft = false;
		}

		//Es können mehrere Konstruktoren definiert werden, welche unterschiedliche Übergabeparameter haben (Überladung). Ein Konstruktor, der keine
		//Übergabeparameter hat, wird als Basiskonstruktor bezeichnet
		//Snippet: ctor
		public Fahrzeug()
		{

		}

		//Der DESTRUKTOR wird von der GarbageCollection aufgerufen, wenn ein Objekt aus dem Speicher gelöscht wird. Der Destruktor wird 
		///automatisch (unsichtbar) erzeugt und muss nur selbst geschrieben werden, wenn neben der Objektzerstörung noch andere Anweisungen
		///ausgeführt werden sollen.
		~Fahrzeug()
		{
			Console.WriteLine($"{this.Name} wurde zerstört.");
		}

		#endregion

		#region Methoden
		//MEMBERMETHODEN sind Funktionen, welche jedes Objekt einer Klasse besitzt und speziell dieses Objekt manipuliert
		public void Beschleunige(int a)
		{
			if (this.MotorLäuft)
			{
				if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
					this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
				else if (this.AktGeschwindigkeit + a < 0)
					this.AktGeschwindigkeit = 0;
				else
					this.AktGeschwindigkeit += a;
			}
		}

		public void StarteMotor()
		{
			this.MotorLäuft = true;
		}

		public void StoppeMotor()
		{
			this.MotorLäuft = false;
			this.AktGeschwindigkeit = 0;
		}

		public string BeschreibeMich()
		{
			if (this.MotorLäuft)
				return $"{this.Name} kostet {this.Preis}€ und fährt momentan mit {this.AktGeschwindigkeit} von maximal {this.MaxGeschwindigkeit}km/h.";
			else
				return $"{this.Name} kostet {this.Preis}€ und könnte maximal {this.MaxGeschwindigkeit}km/h fahren.";
		}
		#endregion
	}
}
