using Fahrzeugpark;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Serialisierung
{
    public partial class Form1 : Form
    {
        //Benötigte Properties (Liste zum Speichern der Fahrzeuge und Zufallsgenerator)
        public List<Fahrzeug> Fahrzeugliste { get; set; }
        public Random Generator { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Initialisierung der Properties
            Fahrzeugliste = new List<Fahrzeug>();
            Generator = new Random();
        }

        //Methode zur zufälligen Erstellung von Fahrzeugen
        private Fahrzeug CreateNewFz()
        {
            switch (Generator.Next(1, 4))
            {
                case 1:
                    return new PKW("BMW", 190, 23000, 5);
                case 2:
                    return new Schiff("Titanic", 60, 30000000, Schiff.SchiffsTreibstoff.Dampf);
                case 3:
                    return new Flugzeug("Boing", 800, 30000000, 9999);
                default:
                    return null;
            }
        }

        //Methode zur Darstellung der Fahrzeuge aus der Liste in der ListBox der GUI
        private void ShowFzs()
        {
            //Löschen der Listboxinhalte
            LbxFahrzeuge.Items.Clear();

            //Einfügen der Fahrzeuge aus der Liste in die Listbox
            foreach (var item in Fahrzeugliste)
            {
                LbxFahrzeuge.Items.Add(item.Name);
            }
        }

        //Methode zum Löschen markierter Fahrzeugen
        private void DeleteFz()
        {
            //For-Schleife über die ListBox
            for (int i = LbxFahrzeuge.Items.Count - 1; i >= 0; i--)
            {
                //Prüfung, ob der aktuell betrachtete Eintrag vom Benutzer markiert ist
                if (LbxFahrzeuge.GetSelected(i))
                    //Löschen des Items aus der Fahrzeugliste an der aktuellen Indexposition
                    Fahrzeugliste.RemoveAt(i);
            }
        }


        //Methode zum Abspeichern von Fahrzeugen (vgl. auch LoadFZ)
        private void SaveFz()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            try
            {
                using (StreamWriter writer = new StreamWriter("fahrzeug.txt"))
                {
                    for (int i = 0; i < Fahrzeugliste.Count; i++)
                    {
                        string fzAlsString = JsonConvert.SerializeObject(Fahrzeugliste[i], settings);

                        writer.WriteLine(fzAlsString);
                    }
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch
            {
                MessageBox.Show("Speichern fehlgeschlagen");
            }
        }

        //Methode zum Laden einer 'Fahrzeug'-Datei (vgl. auch SpeichernUndLaden.Form1.LoadText())
        private void LoadFz()
        {
            try
            {
                //Mittels der TypeNameHandling-Property des JsonSerializerSettings-Objekts kann dem Serialisierer aufgegeben werden, dass er den expliziten Objekt-Type der 
                //zu ladenden/speichernden Objekte mit abspeichert
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Objects;

                List<Fahrzeug> tempFzListe = new List<Fahrzeug>();

                //Verwendung des USING-Blocks (erlaubt durch die Verwendung des IDisposible-Interfaces in der StreamReader-Klasse.
                //Hierdurch wird durch verlassen des Using-Blocks automatisch der Dateizugriff beenden (statt reader.Close())
                using (StreamReader reader = new StreamReader("fahrzeug.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        //Lesen einer Textzeile aus der Datei
                        string fzAlsAtring = reader.ReadLine();
                        //Umwandlung der Textzeile in ein Fahrzeug (Beachte die Übergabe des Settings-Objekts)
                        Fahrzeug fz = JsonConvert.DeserializeObject<Fahrzeug>(fzAlsAtring, settings);
                        //Hinzufügen des Fahrzeugs zur Liste
                        tempFzListe.Add(fz);
                    }
                }

                Fahrzeugliste = tempFzListe;

                MessageBox.Show("Laden erfolgreich");
            }
            catch
            {
                MessageBox.Show("Laden fehlgeschlagen");
            }
        }

        //Click-Event-Methoden der Buttons
        private void BtnNew_Click(object sender, EventArgs e)
        {
            Fahrzeugliste.Add(CreateNewFz());
            ShowFzs();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteFz();
            ShowFzs();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFz();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LoadFz();
            ShowFzs();
        }
    }
}
