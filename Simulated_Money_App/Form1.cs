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
        public static Pot pot = new Pot();

        public static Player selectedPlayer;

        public FrmMain() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) { }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newplayer = new NewPlayerfrm();
            newplayer.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatelistboxPlayers();

            lblPot.Text = "Pot: $" + pot.getMoney();
        }

        private void UpdatelistboxPlayers()
        {
            listbPlayers.Items.Clear();
            foreach (Player player in players)
            {
                listbPlayers.Items.Add(player.getName());
            }
        }

        private void listbPlayers_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Player player in players)
            {
                if (listbPlayers.SelectedItem.ToString() == player.getName())
                {
                    selectedPlayer = player;
                    break;
                }
            }

            lblName.Text = selectedPlayer.getName();
            lblMoney.Text = "$" + selectedPlayer.getMoney().ToString();

            lblPot.Text = "Pot: $" + pot.getMoney();
        }

        private void btnEmptyPot_Click(object sender, EventArgs e)
        {
            SendingMoney sendM = new SendingMoney();
            sendM.Show();
            lblName.Text = selectedPlayer.getName();
            lblMoney.Text = "$" + selectedPlayer.getMoney().ToString();

            lblPot.Text = "Pot: $" + pot.getMoney();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(numBet.Value);
            selectedPlayer.subMoney(value);
            pot.addMoney(value);
            lblName.Text = selectedPlayer.getName();
            lblMoney.Text = "$" + selectedPlayer.getMoney().ToString();

            lblPot.Text = "Pot: $" + pot.getMoney();
        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete\n" + selectedPlayer.getName(),
                "Delete a Player", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                players.Remove(selectedPlayer);
            }
            else { }
        }
    }
}
