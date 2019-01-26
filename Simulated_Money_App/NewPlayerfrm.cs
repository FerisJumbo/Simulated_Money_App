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
    public partial class NewPlayerfrm : Form
    {
        private static List<RadioButton> radioButtons = new List<RadioButton>();

        public NewPlayerfrm()
        {
            InitializeComponent();
        }

        private void NewPlayerfrm_Load(object sender, EventArgs e)
        {
            radioButtons.Add(rad100);
            radioButtons.Add(rad500);
            radioButtons.Add(rad1000);
            radioButtons.Add(rad2000);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String Name = txtName.Text;
            int Money = 0;
            foreach (RadioButton Rad in radioButtons)
            {
                if (Rad.Checked)
                {
                    Money = Int32.Parse(Rad.Text);
                }
            }
            Player somePlayer = new Player(Name, Money);
            FrmMain.players.Add(somePlayer);


            this.Close();
        }
    }
}
