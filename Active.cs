using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overwatch_overervingsoef
{
    class Active : Abillity
    {
        Keys keybind;

        public Active(string name, string discription, TimeSpan cooldown, Keys keybind) : base(name,discription,cooldown)
        {
            this.keybind = keybind;
        }
    }
}
