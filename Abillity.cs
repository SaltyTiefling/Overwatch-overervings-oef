using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overwatch_overervingsoef
{
    class Abillity
    {
        public string name { get; set; }
        public string discription { get; set; }
        public TimeSpan cooldown { get; set; }

        public Abillity()
        {
        }

        public Abillity(string name, string discription, TimeSpan cooldown)
        {
            this.name = name;
            this.discription = discription;
            this.cooldown = cooldown;
        }
        public override string ToString()
        {
            return name.ToUpper();
        }
    }
}
