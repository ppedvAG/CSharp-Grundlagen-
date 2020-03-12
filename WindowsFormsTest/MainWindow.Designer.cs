namespace WindowsFormsTest
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnKlickMich = new System.Windows.Forms.Button();
            this.CbxFarbwechsel = new System.Windows.Forms.CheckBox();
            this.CbbAuswahl = new System.Windows.Forms.ComboBox();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesFensterÖffenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnRunAway = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnKlickMich
            // 
            this.BtnKlickMich.BackColor = System.Drawing.Color.Aqua;
            this.BtnKlickMich.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKlickMich.Location = new System.Drawing.Point(356, 54);
            this.BtnKlickMich.Name = "BtnKlickMich";
            this.BtnKlickMich.Size = new System.Drawing.Size(200, 93);
            this.BtnKlickMich.TabIndex = 0;
            this.BtnKlickMich.Text = "Klick Mich";
            this.BtnKlickMich.UseVisualStyleBackColor = false;
            this.BtnKlickMich.Click += new System.EventHandler(this.BtnKlickMich_Click);
            // 
            // CbxFarbwechsel
            // 
            this.CbxFarbwechsel.AutoSize = true;
            this.CbxFarbwechsel.Location = new System.Drawing.Point(12, 111);
            this.CbxFarbwechsel.Name = "CbxFarbwechsel";
            this.CbxFarbwechsel.Size = new System.Drawing.Size(95, 17);
            this.CbxFarbwechsel.TabIndex = 1;
            this.CbxFarbwechsel.Text = "Farbe ändern?";
            this.CbxFarbwechsel.UseVisualStyleBackColor = true;
            // 
            // CbbAuswahl
            // 
            this.CbbAuswahl.FormattingEnabled = true;
            this.CbbAuswahl.Items.AddRange(new object[] {
            "Eintrag 1",
            "Auswahl 2",
            "Item 3"});
            this.CbbAuswahl.Location = new System.Drawing.Point(12, 134);
            this.CbbAuswahl.Name = "CbbAuswahl";
            this.CbbAuswahl.Size = new System.Drawing.Size(121, 21);
            this.CbbAuswahl.TabIndex = 2;
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(240, 134);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(88, 13);
            this.LblAusgabe.TabIndex = 3;
            this.LblAusgabe.Text = "Dies ist ein String";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Item 1",
            "Auswahl 2",
            "Eintrag 3"});
            this.listBox1.Location = new System.Drawing.Point(33, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(257, 134);
            this.listBox1.TabIndex = 4;
            // 
            // TbxInput
            // 
            this.TbxInput.AcceptsReturn = true;
            this.TbxInput.AcceptsTab = true;
            this.TbxInput.Location = new System.Drawing.Point(388, 246);
            this.TbxInput.Multiline = true;
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(245, 99);
            this.TbxInput.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesFensterÖffenToolStripMenuItem,
            this.programmBeendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // neuesFensterÖffenToolStripMenuItem
            // 
            this.neuesFensterÖffenToolStripMenuItem.Name = "neuesFensterÖffenToolStripMenuItem";
            this.neuesFensterÖffenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuesFensterÖffenToolStripMenuItem.Text = "Neues Fenster öffen";
            this.neuesFensterÖffenToolStripMenuItem.Click += new System.EventHandler(this.neuesFensterÖffenToolStripMenuItem_Click);
            // 
            // programmBeendenToolStripMenuItem
            // 
            this.programmBeendenToolStripMenuItem.Name = "programmBeendenToolStripMenuItem";
            this.programmBeendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmBeendenToolStripMenuItem.Text = "Programm beenden";
            this.programmBeendenToolStripMenuItem.Click += new System.EventHandler(this.programmBeendenToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(591, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(591, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(591, 178);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(438, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 68);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(70, 34);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(194, 40);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnRunAway
            // 
            this.BtnRunAway.Location = new System.Drawing.Point(47, 194);
            this.BtnRunAway.Name = "BtnRunAway";
            this.BtnRunAway.Size = new System.Drawing.Size(68, 34);
            this.BtnRunAway.TabIndex = 11;
            this.BtnRunAway.Text = "Lauf Weg";
            this.BtnRunAway.UseVisualStyleBackColor = true;
            this.BtnRunAway.Click += new System.EventHandler(this.BtnRunAway_Click);
            // 
            // BtnTimer
            // 
            this.BtnTimer.Location = new System.Drawing.Point(33, 389);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(132, 51);
            this.BtnTimer.TabIndex = 12;
            this.BtnTimer.Text = "Starte / Stoppe Timer";
            this.BtnTimer.UseVisualStyleBackColor = true;
            this.BtnTimer.Click += new System.EventHandler(this.BtnTimer_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 452);
            this.Controls.Add(this.BtnTimer);
            this.Controls.Add(this.BtnRunAway);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.TbxInput);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CbbAuswahl);
            this.Controls.Add(this.CbxFarbwechsel);
            this.Controls.Add(this.BtnKlickMich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Mein Fenster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKlickMich;
        private System.Windows.Forms.CheckBox CbxFarbwechsel;
        private System.Windows.Forms.ComboBox CbbAuswahl;
        private System.Windows.Forms.Label LblAusgabe;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TbxInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesFensterÖffenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmBeendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnRunAway;
        private System.Windows.Forms.Button BtnTimer;
    }
}

