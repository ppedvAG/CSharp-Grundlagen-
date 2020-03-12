using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    //PARTIAL besagt, dass die Klasse hier nicht vollständig dargestellt wird. Der Rest befindet sich in einem
    ///anderen Dokument. Jedes Form erbt von der Klasse FORM, welche sämtliche Funktionen eines Fensters zur Verfügung stellt
    public partial class MainWindow : Form
    {
        //Konstruktor des Forms (wird bei Aufruf des Fensters aufgerufen)
        public MainWindow()
        {
            //Mit dieser Methode werden die Designerseitig gebauten Elemente gezeichnet (-> sollte immer die erste Funktion sein, welche
            ///der Konstruktor aufruft
            InitializeComponent();

            //Hinzufügen eines Eintrags zur Combobox
            CbbAuswahl.Items.Add("noch ein Eintrag");

            //EVENTs sind spezielle Delegates, welche nicht per Zuweisung überschrieben werden können. Methode müssen das Event per += abbonieren und
            ///per -= deabbonieren. Tritt ein Event auf (z.B. wenn ein Button geklickt wird) werden alle Methoden ausgeführt, welche dieses Event
            ///abboniert haben
            BtnKlickMich.Click += timer1_Tick;
        }

        //Click-Methoden, der einzelnen Buttons
        private void BtnKlickMich_Click(object sender, EventArgs e)
        {
            //Prüfung, ob die Checkbox abgehakt ist
            if (CbxFarbwechsel.Checked)
                //Ändern der Hintergrundfarbe des Fensters
                this.BackColor = Color.HotPink;

            //Verschieben des Buttons um 10 Pixel nach rechts
            BtnKlickMich.Left += 10;

            //Ausgabe des markierten Elements in der Combobox als String in einer MessageBox
            //(? ist Null-Prüfung: ToString wird nur ausgeführt, wenn SelectedItem belegt ist)
            MessageBox.Show("In de Combobox wurde folgender Eintrag ausgewählt:\n" + CbbAuswahl.SelectedItem?.ToString());

            //Veränderung des Label-Inhalts
            LblAusgabe.Text = "Auch dies ist ein String. Aber ein anderer.";

            //Ausgabe des Textbox-Inhalts
            MessageBox.Show(TbxInput.Text);
        }

        private void neuesFensterÖffenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziierung des neuen Fensters
            MainWindow neuesFenster = new MainWindow();

            //Manipuation des Fenstertitels
            neuesFenster.Text = "2. Fenster";

            //Öffnen des Fensters als gleichberechtigtes Fenster
            //neuesFenster.Show();

            //Öffnen des neuen Fensters als Dialogfenster (verbietet Zugriff auf alle anderen Fenster)
            neuesFenster.ShowDialog();
        }

        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Schließen des aktuellen Fensters
            this.Close();

            //Beenden der kompletten Applikation
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BtnRunAway.Left++;
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            //Prüfung, ob der Timer läuft
            if (timer1.Enabled)
                //Stoppen des Timers
                timer1.Stop();
            else
                //Starten des Timers
                timer1.Start();
        }

        private void BtnRunAway_Click(object sender, EventArgs e)
        {
            //Anzeigen einer MessageBox mit Prüfung, welcher Button geklickt wurde
            if (MessageBox.Show("Geht es dir gut?", "Befindlichkeitsabfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MessageBox.Show("Aber nicht mehr lange...");
            else
                MessageBox.Show("Geht jedem mal so...");
        }
    }
}
