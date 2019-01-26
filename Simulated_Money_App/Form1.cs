using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulated_Money_App
{
    public partial class FrmMain : Form
    {
        public static List<Player> players = new List<Player>();

        public FrmMain() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }

        private void btnExecute_Click(object sender, EventArgs e)
        {

        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newplayer = new NewPlayerfrm();
            newplayer.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatelistboxPlayers();
        }

        private void UpdatelistboxPlayers()
        {
            listbPlayers.Items.Clear();
            foreach (Player player in players)
            {
                listbPlayers.Items.Add(player.getName() + " --- " + player.getMoney());
            }
        }
    }
}
