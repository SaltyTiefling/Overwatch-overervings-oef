using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch_overervingsoef
{
    class Hero
    {
        public string name { get; set; }
        public int hp { get; set; }
        public string bio { get; set; }
        public string gender { get; set; }
        public string classification { get; set; }
        public int difficulty { get; set; }
        public List<Abillity> abilities = new List<Abillity>();

        public Hero(string name, int hp, string bio, string gender, string classification, int difficulty, List<Abillity> abilities)
        {
            this.name = name;
            this.hp = hp;
            this.bio = bio;
            this.gender = gender;
            this.classification = classification;
            this.difficulty = difficulty;
            this.abilities = abilities;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
