namespace ButtonMovement
{
    partial class Form1
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
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLeft
            // 
            this.BtnLeft.Location = new System.Drawing.Point(12, 12);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(103, 66);
            this.BtnLeft.TabIndex = 0;
            this.BtnLeft.Text = "Links";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Location = new System.Drawing.Point(685, 12);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(103, 66);
            this.BtnRight.TabIndex = 1;
            this.BtnRight.Text = "Rechts";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnMain
            // 
            this.BtnMain.Location = new System.Drawing.Point(12, 84);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(776, 28);
            this.BtnMain.TabIndex = 2;
            this.BtnMain.Text = "Start";
            this.BtnMain.UseVisualStyleBackColor = true;
            this.BtnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 124);
            this.Controls.Add(this.BtnMain);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Name = "Form1";
            this.Text = "Bewegte Buttons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnMain;
    }
}

