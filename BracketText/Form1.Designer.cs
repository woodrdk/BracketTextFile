namespace BracketText
{
    partial class frmMain
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lblTrounamentDate = new System.Windows.Forms.Label();
            this.lblTournament = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbTournamentName = new System.Windows.Forms.TextBox();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnEntries = new System.Windows.Forms.Button();
            this.cbDoubles = new System.Windows.Forms.CheckBox();
            this.btnBracket = new System.Windows.Forms.Button();
            this.btnClearEntries = new System.Windows.Forms.Button();
            this.tbRunnerUp = new System.Windows.Forms.TextBox();
            this.tbWinner = new System.Windows.Forms.TextBox();
            this.tbR3P2 = new System.Windows.Forms.TextBox();
            this.tbR2P4 = new System.Windows.Forms.TextBox();
            this.tbR2P3 = new System.Windows.Forms.TextBox();
            this.tbR2P2 = new System.Windows.Forms.TextBox();
            this.tbP8 = new System.Windows.Forms.TextBox();
            this.tbP7 = new System.Windows.Forms.TextBox();
            this.tbP6 = new System.Windows.Forms.TextBox();
            this.tbP5 = new System.Windows.Forms.TextBox();
            this.tbP4 = new System.Windows.Forms.TextBox();
            this.tbP3 = new System.Windows.Forms.TextBox();
            this.tbP2 = new System.Windows.Forms.TextBox();
            this.tbR3P1 = new System.Windows.Forms.TextBox();
            this.tbR2P1 = new System.Windows.Forms.TextBox();
            this.tbP1 = new System.Windows.Forms.TextBox();
            this.lblRunnerUp = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblRound3 = new System.Windows.Forms.Label();
            this.lblRound2 = new System.Windows.Forms.Label();
            this.lblRound1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(14, 49);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 17;
            this.lblLocation.Text = "Location:";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(130, 49);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(200, 20);
            this.tbLocation.TabIndex = 16;
            // 
            // lblTrounamentDate
            // 
            this.lblTrounamentDate.AutoSize = true;
            this.lblTrounamentDate.Location = new System.Drawing.Point(14, 81);
            this.lblTrounamentDate.Name = "lblTrounamentDate";
            this.lblTrounamentDate.Size = new System.Drawing.Size(90, 13);
            this.lblTrounamentDate.TabIndex = 15;
            this.lblTrounamentDate.Text = "Tournament Date";
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.Location = new System.Drawing.Point(14, 23);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(98, 13);
            this.lblTournament.TabIndex = 14;
            this.lblTournament.Text = "Tournament Name:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(130, 75);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 13;
            // 
            // tbTournamentName
            // 
            this.tbTournamentName.Location = new System.Drawing.Point(130, 23);
            this.tbTournamentName.Name = "tbTournamentName";
            this.tbTournamentName.Size = new System.Drawing.Size(200, 20);
            this.tbTournamentName.TabIndex = 12;
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(11, 137);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.ReadOnly = true;
            this.rtbNotes.Size = new System.Drawing.Size(319, 115);
            this.rtbNotes.TabIndex = 11;
            this.rtbNotes.Text = "";
            // 
            // btnEntries
            // 
            this.btnEntries.Location = new System.Drawing.Point(255, 108);
            this.btnEntries.Name = "btnEntries";
            this.btnEntries.Size = new System.Drawing.Size(75, 23);
            this.btnEntries.TabIndex = 10;
            this.btnEntries.Text = "Load Entries";
            this.btnEntries.UseVisualStyleBackColor = true;
            this.btnEntries.Click += new System.EventHandler(this.btnEntries_Click);
            // 
            // cbDoubles
            // 
            this.cbDoubles.AutoSize = true;
            this.cbDoubles.Location = new System.Drawing.Point(19, 112);
            this.cbDoubles.Name = "cbDoubles";
            this.cbDoubles.Size = new System.Drawing.Size(164, 17);
            this.cbDoubles.TabIndex = 9;
            this.cbDoubles.Text = "Is this a doubles tournament?";
            this.cbDoubles.UseVisualStyleBackColor = true;
            // 
            // btnBracket
            // 
            this.btnBracket.Location = new System.Drawing.Point(12, 258);
            this.btnBracket.Name = "btnBracket";
            this.btnBracket.Size = new System.Drawing.Size(75, 23);
            this.btnBracket.TabIndex = 18;
            this.btnBracket.Text = "Run Bracket";
            this.btnBracket.UseVisualStyleBackColor = true;
            this.btnBracket.Click += new System.EventHandler(this.btnBracket_Click);
            // 
            // btnClearEntries
            // 
            this.btnClearEntries.Location = new System.Drawing.Point(255, 258);
            this.btnClearEntries.Name = "btnClearEntries";
            this.btnClearEntries.Size = new System.Drawing.Size(75, 23);
            this.btnClearEntries.TabIndex = 19;
            this.btnClearEntries.Text = "Clear entries";
            this.btnClearEntries.UseVisualStyleBackColor = true;
            this.btnClearEntries.Click += new System.EventHandler(this.btnClearEntries_Click);
            // 
            // tbRunnerUp
            // 
            this.tbRunnerUp.Location = new System.Drawing.Point(715, 200);
            this.tbRunnerUp.Name = "tbRunnerUp";
            this.tbRunnerUp.Size = new System.Drawing.Size(100, 20);
            this.tbRunnerUp.TabIndex = 62;
            // 
            // tbWinner
            // 
            this.tbWinner.Location = new System.Drawing.Point(715, 140);
            this.tbWinner.Name = "tbWinner";
            this.tbWinner.Size = new System.Drawing.Size(100, 20);
            this.tbWinner.TabIndex = 61;
            // 
            // tbR3P2
            // 
            this.tbR3P2.Location = new System.Drawing.Point(594, 243);
            this.tbR3P2.Name = "tbR3P2";
            this.tbR3P2.Size = new System.Drawing.Size(100, 20);
            this.tbR3P2.TabIndex = 60;
            // 
            // tbR2P4
            // 
            this.tbR2P4.Location = new System.Drawing.Point(473, 270);
            this.tbR2P4.Name = "tbR2P4";
            this.tbR2P4.Size = new System.Drawing.Size(100, 20);
            this.tbR2P4.TabIndex = 59;
            // 
            // tbR2P3
            // 
            this.tbR2P3.Location = new System.Drawing.Point(473, 193);
            this.tbR2P3.Name = "tbR2P3";
            this.tbR2P3.Size = new System.Drawing.Size(100, 20);
            this.tbR2P3.TabIndex = 58;
            // 
            // tbR2P2
            // 
            this.tbR2P2.Location = new System.Drawing.Point(473, 118);
            this.tbR2P2.Name = "tbR2P2";
            this.tbR2P2.Size = new System.Drawing.Size(100, 20);
            this.tbR2P2.TabIndex = 57;
            // 
            // tbP8
            // 
            this.tbP8.Location = new System.Drawing.Point(352, 287);
            this.tbP8.Name = "tbP8";
            this.tbP8.Size = new System.Drawing.Size(100, 20);
            this.tbP8.TabIndex = 56;
            // 
            // tbP7
            // 
            this.tbP7.Location = new System.Drawing.Point(352, 261);
            this.tbP7.Name = "tbP7";
            this.tbP7.Size = new System.Drawing.Size(100, 20);
            this.tbP7.TabIndex = 55;
            // 
            // tbP6
            // 
            this.tbP6.Location = new System.Drawing.Point(352, 209);
            this.tbP6.Name = "tbP6";
            this.tbP6.Size = new System.Drawing.Size(100, 20);
            this.tbP6.TabIndex = 54;
            // 
            // tbP5
            // 
            this.tbP5.Location = new System.Drawing.Point(352, 183);
            this.tbP5.Name = "tbP5";
            this.tbP5.Size = new System.Drawing.Size(100, 20);
            this.tbP5.TabIndex = 53;
            // 
            // tbP4
            // 
            this.tbP4.Location = new System.Drawing.Point(352, 134);
            this.tbP4.Name = "tbP4";
            this.tbP4.Size = new System.Drawing.Size(100, 20);
            this.tbP4.TabIndex = 52;
            // 
            // tbP3
            // 
            this.tbP3.Location = new System.Drawing.Point(352, 108);
            this.tbP3.Name = "tbP3";
            this.tbP3.Size = new System.Drawing.Size(100, 20);
            this.tbP3.TabIndex = 51;
            // 
            // tbP2
            // 
            this.tbP2.Location = new System.Drawing.Point(352, 56);
            this.tbP2.Name = "tbP2";
            this.tbP2.Size = new System.Drawing.Size(100, 20);
            this.tbP2.TabIndex = 50;
            // 
            // tbR3P1
            // 
            this.tbR3P1.Location = new System.Drawing.Point(594, 87);
            this.tbR3P1.Name = "tbR3P1";
            this.tbR3P1.Size = new System.Drawing.Size(100, 20);
            this.tbR3P1.TabIndex = 49;
            // 
            // tbR2P1
            // 
            this.tbR2P1.Location = new System.Drawing.Point(473, 42);
            this.tbR2P1.Name = "tbR2P1";
            this.tbR2P1.Size = new System.Drawing.Size(100, 20);
            this.tbR2P1.TabIndex = 48;
            // 
            // tbP1
            // 
            this.tbP1.Location = new System.Drawing.Point(352, 30);
            this.tbP1.Name = "tbP1";
            this.tbP1.Size = new System.Drawing.Size(100, 20);
            this.tbP1.TabIndex = 47;
            // 
            // lblRunnerUp
            // 
            this.lblRunnerUp.AutoSize = true;
            this.lblRunnerUp.Location = new System.Drawing.Point(712, 175);
            this.lblRunnerUp.Name = "lblRunnerUp";
            this.lblRunnerUp.Size = new System.Drawing.Size(56, 13);
            this.lblRunnerUp.TabIndex = 46;
            this.lblRunnerUp.Text = "RunnerUp";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(712, 123);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(41, 13);
            this.lblWinner.TabIndex = 45;
            this.lblWinner.Text = "Winner";
            // 
            // lblRound3
            // 
            this.lblRound3.AutoSize = true;
            this.lblRound3.Location = new System.Drawing.Point(591, 18);
            this.lblRound3.Name = "lblRound3";
            this.lblRound3.Size = new System.Drawing.Size(48, 13);
            this.lblRound3.TabIndex = 44;
            this.lblRound3.Text = "Round 3";
            // 
            // lblRound2
            // 
            this.lblRound2.AutoSize = true;
            this.lblRound2.Location = new System.Drawing.Point(470, 11);
            this.lblRound2.Name = "lblRound2";
            this.lblRound2.Size = new System.Drawing.Size(48, 13);
            this.lblRound2.TabIndex = 43;
            this.lblRound2.Text = "Round 2";
            // 
            // lblRound1
            // 
            this.lblRound1.AutoSize = true;
            this.lblRound1.Location = new System.Drawing.Point(349, 12);
            this.lblRound1.Name = "lblRound1";
            this.lblRound1.Size = new System.Drawing.Size(48, 13);
            this.lblRound1.TabIndex = 42;
            this.lblRound1.Text = "Round 1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 321);
            this.Controls.Add(this.tbRunnerUp);
            this.Controls.Add(this.tbWinner);
            this.Controls.Add(this.tbR3P2);
            this.Controls.Add(this.tbR2P4);
            this.Controls.Add(this.tbR2P3);
            this.Controls.Add(this.tbR2P2);
            this.Controls.Add(this.tbP8);
            this.Controls.Add(this.tbP7);
            this.Controls.Add(this.tbP6);
            this.Controls.Add(this.tbP5);
            this.Controls.Add(this.tbP4);
            this.Controls.Add(this.tbP3);
            this.Controls.Add(this.tbP2);
            this.Controls.Add(this.tbR3P1);
            this.Controls.Add(this.tbR2P1);
            this.Controls.Add(this.tbP1);
            this.Controls.Add(this.lblRunnerUp);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblRound3);
            this.Controls.Add(this.lblRound2);
            this.Controls.Add(this.lblRound1);
            this.Controls.Add(this.btnClearEntries);
            this.Controls.Add(this.btnBracket);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lblTrounamentDate);
            this.Controls.Add(this.lblTournament);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbTournamentName);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.btnEntries);
            this.Controls.Add(this.cbDoubles);
            this.Name = "frmMain";
            this.Text = "Brackets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lblTrounamentDate;
        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbTournamentName;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnEntries;
        private System.Windows.Forms.CheckBox cbDoubles;
        private System.Windows.Forms.Button btnBracket;
        private System.Windows.Forms.Button btnClearEntries;
        private System.Windows.Forms.TextBox tbRunnerUp;
        private System.Windows.Forms.TextBox tbWinner;
        private System.Windows.Forms.TextBox tbR3P2;
        private System.Windows.Forms.TextBox tbR2P4;
        private System.Windows.Forms.TextBox tbR2P3;
        private System.Windows.Forms.TextBox tbR2P2;
        private System.Windows.Forms.TextBox tbP8;
        private System.Windows.Forms.TextBox tbP7;
        private System.Windows.Forms.TextBox tbP6;
        private System.Windows.Forms.TextBox tbP5;
        private System.Windows.Forms.TextBox tbP4;
        private System.Windows.Forms.TextBox tbP3;
        private System.Windows.Forms.TextBox tbP2;
        private System.Windows.Forms.TextBox tbR3P1;
        private System.Windows.Forms.TextBox tbR2P1;
        private System.Windows.Forms.TextBox tbP1;
        private System.Windows.Forms.Label lblRunnerUp;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblRound3;
        private System.Windows.Forms.Label lblRound2;
        private System.Windows.Forms.Label lblRound1;
    }
}

