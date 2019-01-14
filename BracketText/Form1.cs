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

namespace BracketText
{
    

    public partial class frmMain : Form
    {
        List<string> playerList = new List<string>();
        List<Player> BracketPlayers = new List<Player>();
        public frmMain()
        {
            InitializeComponent();
        }

        private string GetMyDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnEntries_Click(object sender, EventArgs e)
        {       
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = GetMyDocumentsPath();
            fileDialog.Filter = "Text File |*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // read the file and adds each line to the player list array
                playerList = File.ReadLines(fileDialog.FileName).ToList();
                rtbNotes.Text = ""; // for visual testing sake
                

                foreach (string note in playerList) // for each line do the following
                {
                    rtbNotes.Text += (note + Environment.NewLine); // for visual
                    string[] data = note.Split(' ');
                    BracketPlayers.Add(new Player
                    {
                        Name = data[0],
                        Game1 = Convert.ToInt32(data[1]),
                        Game2 = Convert.ToInt32(data[2]),
                        Game3 = Convert.ToInt32(data[3])
                    });
                }
                // following code is for testing sake of my code
                Player player2 = BracketPlayers[2];
                MessageBox.Show(player2.Name);
            }
            
        }

        private void btnBracket_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int howMany = playerList.Count();
            List<string> bracketList = new List<string>();
            int number;
            for (int rand = 0; rand < howMany; rand++)
            {
                number = rnd.Next(0, howMany);
            }

            // need to do random stil

            List<Game1> winnersRound1 = new List<Game1>();
            List<Game2> winnersRound2 = new List<Game2>();
            // round 1 check who wins round one of the 4 rounds for round 1 of each bracket
            for (int g1 = 0; g1 < 8; g1 += 2)
            {
                if (BracketPlayers[g1].Game1 > BracketPlayers[g1+1].Game1)
                {
                    winnersRound1.Add(new Game1
                    {
                        Name = BracketPlayers[g1].Name,
                        Game2 = Convert.ToInt32(BracketPlayers[g1].Game2),
                        Game3 = Convert.ToInt32(BracketPlayers[g1].Game3)
                    });
                }
                else
                {
                    winnersRound1.Add(new Game1
                    {
                        Name = BracketPlayers[g1 + 1].Name,
                        Game2 = Convert.ToInt32(BracketPlayers[g1 + 1].Game2),
                        Game3 = Convert.ToInt32(BracketPlayers[g1 + 1].Game3)
                    });
                }
            }

            // round 2 check to see who wins round 2 of the 2 rounds
            for (int g2 = 0; g2 < 4; g2 += 2)
            {
                if (winnersRound1[g2].Game2 > BracketPlayers[g2 + 1].Game2)
                {
                    winnersRound2.Add(new Game2
                    {
                        Name = BracketPlayers[g2].Name,
                        Game3 = Convert.ToInt32(BracketPlayers[g2].Game3)
                    });
                }
                else
                {
                    winnersRound2.Add(new Game2
                    {
                        Name = BracketPlayers[g2 + 1].Name,
                        Game3 = Convert.ToInt32(BracketPlayers[g2 + 1].Game3)
                    });
                }
            }

            // round 3 check to see who wins top or second of final round
            string winner;
            string runnerUp;
            if (winnersRound2[0].Game3 > winnersRound2[1].Game3)
            {
                winner = winnersRound2[0].Name;
                runnerUp = winnersRound2[1].Name;
            }
            else
            {
                winner = winnersRound2[1].Name;
                runnerUp = winnersRound2[0].Name;
            }

            MessageBox.Show("Winner is " + winner + "\n" + "Runner up is " + runnerUp);
        }
    }
}
