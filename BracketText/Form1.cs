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
            }
        }

        private void btnBracket_Click(object sender, EventArgs e)
        {
            ClearResults();
            int number = 0;
            int howMany = playerList.Count();
            List<Player> bracketList = new List<Player>();
            Random rnd = new Random();
            List<int> indexNum = new List<int>();
            if (howMany >= 8)
            {
                for (int i = 0; i < howMany; i++)
                {
                    number = rnd.Next(0, playerList.Count());
                    if (indexNum.Contains(number))
                    {
                        i--;
                    }
                    else
                    {
                        indexNum.Add(number);
                    }
                }

                for (int rand = 0; rand < howMany; rand++)
                {
                    bracketList.Add(BracketPlayers[indexNum[rand]]);
                }

                List<Game1> winnersRound1 = new List<Game1>();
                List<Game2> winnersRound2 = new List<Game2>();

                // round 1 check who wins round one of the 4 rounds for round 1 of each bracket
                for (int g1 = 0; g1 < 8; g1 += 2)
                {
                    if (bracketList[g1].Game1 > bracketList[g1 + 1].Game1)
                    {
                        winnersRound1.Add(new Game1
                        {
                            Name = bracketList[g1].Name,
                            Game2 = Convert.ToInt32(bracketList[g1].Game2),
                            Game3 = Convert.ToInt32(bracketList[g1].Game3)
                        });
                    }
                    else
                    {
                        winnersRound1.Add(new Game1
                        {
                            Name = bracketList[g1 + 1].Name,
                            Game2 = Convert.ToInt32(bracketList[g1 + 1].Game2),
                            Game3 = Convert.ToInt32(bracketList[g1 + 1].Game3)
                        });
                    }
                }

                if (cbDoubles.Checked)
                {
                    MessageBox.Show("Doubles tournament is not set up yet");

                }
                else
                {

                    // round 2 check to see who wins round 2
                    for (int g2 = 0; g2 < 4; g2 += 2)
                    {
                        if (winnersRound1[g2].Game2 > winnersRound1[g2 + 1].Game2)
                        {
                            winnersRound2.Add(new Game2
                            {
                                Name = winnersRound1[g2].Name,
                                Game3 = Convert.ToInt32(winnersRound1[g2].Game3)
                            });
                        }
                        else
                        {
                            winnersRound2.Add(new Game2
                            {
                                Name = winnersRound1[g2 + 1].Name,
                                Game3 = Convert.ToInt32(winnersRound1[g2 + 1].Game3)
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
                    //MessageBox.Show("Winner is " + winner + " winning $25" + "\n"
                    //    + "Runner up is " + runnerUp + " winning $10");
                 
                    tbP1.Text = bracketList[0].Name + " " + bracketList[0].Game1;
                    tbP2.Text = bracketList[1].Name + " " + bracketList[1].Game1;
                    tbP3.Text = bracketList[2].Name + " " + bracketList[2].Game1;
                    tbP4.Text = bracketList[3].Name + " " + bracketList[3].Game1;
                    tbP5.Text = bracketList[4].Name + " " + bracketList[4].Game1;
                    tbP6.Text = bracketList[5].Name + " " + bracketList[5].Game1;
                    tbP7.Text = bracketList[6].Name + " " + bracketList[6].Game1;
                    tbP8.Text = bracketList[7].Name + " " + bracketList[7].Game1;

                    tbR2P1.Text = winnersRound1[0].Name + " " + winnersRound1[0].Game2;
                    tbR2P2.Text = winnersRound1[1].Name + " " + winnersRound1[1].Game2;
                    tbR2P3.Text = winnersRound1[2].Name + " " + winnersRound1[2].Game2;
                    tbR2P4.Text = winnersRound1[3].Name + " " + winnersRound1[3].Game2;

                    tbR3P1.Text = winnersRound2[0].Name + " " + winnersRound2[0].Game3;
                    tbR3P2.Text = winnersRound2[1].Name + " " + winnersRound2[1].Game3;

                    tbWinner.Text = winner + " $25";
                    tbRunnerUp.Text = runnerUp + " $10"; 
                }
                
            }
            else
            {
                MessageBox.Show("Please import player's and scores.");
            }
        }

        private void btnClearEntries_Click(object sender, EventArgs e)
        {
            playerList.Clear();
            rtbNotes.Clear();
            ClearResults();
        }
        private void ClearResults()
        {
            tbP1.Clear();
            tbP2.Clear();
            tbP3.Clear();
            tbP4.Clear();
            tbP5.Clear();
            tbP6.Clear();
            tbP7.Clear();
            tbP8.Clear();
            tbR2P1.Clear();
            tbR2P2.Clear();
            tbR2P3.Clear();
            tbR2P4.Clear();

            tbR3P1.Clear();
            tbR3P2.Clear();

            tbWinner.Clear();
            tbRunnerUp.Clear();
        }
    }
    
}
