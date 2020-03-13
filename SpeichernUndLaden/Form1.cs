using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeichernUndLaden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Click-Event-Methoden für die Buttons
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveText(TbxInput.Text);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            TbxInput.Text = LoadText();
        }

        //Methode zum Speichern einer Textdatei
        private void SaveText(string text)
        {
            //Instanzierung eines Save-Dialogfensters
            SaveFileDialog saveDialog = new SaveFileDialog();
            //vorgeschlagener Standartdateiname
            saveDialog.FileName = "gespeicherteStrings.txt";
            //Standart-Ordner (kann z.B. ein Pfad als String sein oder (wie hier) ein Windows-'SpecialFolder')
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //Bsp-Übergabe des Windows-Arbeitsplatzes als GUID
            saveDialog.InitialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            //Mögliche Dateiformate
            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            //Öffnen des Dialogfensters und Überprüfung der Benutzerwahl
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                //Deklarierung und Null-Initialisierung einer Streamreader-Variablen
                StreamWriter writer = null;

                try
                {
                    //Instanzierung des StreamWriters mit Übergabe des Dateipfads
                    writer = new StreamWriter(saveDialog.FileName);

                    //Schreiben des Strings in die Textdatei
                    writer.WriteLine(text);
                    //Schreiben einer weiteren Zeile in die Textdatei
                    writer.WriteLine("ENDE DES STRINGS");

                    //Erfolgsmeldung für User
                    MessageBox.Show("Speichern erfolgreich");
                }
                catch
                {
                    //Misserfolgseldung für User bei Aufkommen einer Exception
                    MessageBox.Show("Speichern fehlgeschlagen");
                }
                finally
                {
                    //Schließen der Datei innerhalb des Finally-Blocks, damit andere Programme auf die Datei zugreifen können (? = Nullprüfung des vorhergehenden Bezeichners)
                    //if (writer != null)
                    //    writer.Close();

                    //Alternative Null-Prüfung
                    writer?.Close();
                }

            }
        }

        //Methode zum Laden einer Textdatei (vgl. auch SaveText())
        private string LoadText()
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            openDialog.FileName = "gespeicherteStrings.txt";
            openDialog.InitialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            openDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {

                string text = "";
                StreamReader reader = null;

                try
                {
                    reader = new StreamReader(openDialog.FileName);

                    //Schleife, welche über die geöffnete Datei läuft
                    while (!reader.EndOfStream)
                    {
                        //Hinzufügen der aktuell betrachteten Zeile in der Datei zu dem Ausgabestring
                        text += reader.ReadLine() + Environment.NewLine; //"\r\n"
                    }

                    MessageBox.Show("Laden erfolgreich");
                }
                catch
                {
                    MessageBox.Show("Laden fehlgeschlagen");
                }
                finally
                {
                    reader?.Close();
                }

                //Rückgabe des Strings
                return text;
            }

            return "";
        }
    }
}
