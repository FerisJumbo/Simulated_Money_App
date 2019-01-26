using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulated_Money_App
{
    public class Pot
    {
        private int Money;

        public Pot()
        {
            this.Money = 0;
        }

        public void sendMoney(Player p)
        {
            p.addMoney(this.Money);
            this.Money = 0;
        }
        public void addMoney(int v) { this.Money = this.Money + v; }

        public int getMoney() { return this.Money; }
    }
}
