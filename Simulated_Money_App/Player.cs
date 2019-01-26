using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulated_Money_App
{
    public class Player
    {
        private String Name;
        private int Money;

        public Player(String name, int money)
        {
            this.Name = name;
            this.Money = money;
        }

        public String getName() { return this.Name; }
        public int getMoney() { return this.Money; }
    }
}
