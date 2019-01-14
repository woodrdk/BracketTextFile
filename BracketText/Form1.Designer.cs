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
            this.rtbNotes.Size = new System.Drawing.Size(319, 96);
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
            this.btnBracket.Location = new System.Drawing.Point(11, 240);
            this.btnBracket.Name = "btnBracket";
            this.btnBracket.Size = new System.Drawing.Size(75, 23);
            this.btnBracket.TabIndex = 18;
            this.btnBracket.Text = "Run Bracket";
            this.btnBracket.UseVisualStyleBackColor = true;
            this.btnBracket.Click += new System.EventHandler(this.btnBracket_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 303);
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
    }
}

