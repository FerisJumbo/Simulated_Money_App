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
    public partial class SendingMoney : Form
    {
        public SendingMoney()
        {
            InitializeComponent();
        }

        private void listbPlayers_SelectedValueChanged(object sender, EventArgs e)
        {
            Player selectedPlayer = null;

            foreach (Player player in FrmMain.players)
            {
                if (listbPlayers.SelectedItem.ToString() == player.getName())
                {
                    selectedPlayer = player;
                    break;
                }
            }

            FrmMain.pot.sendMoney(selectedPlayer);
            this.Close();
        }

        private void SendingMoney_Load(object sender, EventArgs e)
        {
            foreach (Player player in FrmMain.players)
            {
                listbPlayers.Items.Add(player.getName());
            }
        }
    }
}
