using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overwatch_overervingsoef
{
    public partial class Form1 : Form
    {
        List<Hero> heroes = new List<Hero>();
        List<Hero> chosenHeroes = new List<Hero>();
        int formsize;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formsize = this.Height;
            //D.Va
            Hero Dva = new Hero(
                "D.Va",
                400,
                "D.Va’s mech is nimble and powerful —its twin Fusion Cannons blast away with autofire at short range, and she can use its Boosters to barrel over enemies and obstacles, or deflect attacks with her projectile-dismantling Defense Matrix.",
                "Female",
                "Tank",
                2,
                new List<Abillity>{
                    new Active(
                        "Fusion Cannons",
                        "D.Va's mech is equipped with twin short-range rotating cannons. They lay down continuous, high-damage fire without needing to reload, but slow D.Va’s movement while they’re active.",
                        TimeSpan.Zero,
                        Keys.LButton),
                    new Active(
                        "Boosters",
                        "D.Va’s mech launches into the air, her momentum carrying her forward. She can turn and change directions or barrel through her enemies, knocking them back.",
                        new TimeSpan(0,0,4),
                        Keys.Shift),
                    new Active(
                        "Defence Matrix",
                        "D.Va can maintain this forward-facing targeting array for a short period of time; while active, it'll stop incoming projectiles.",
                        new TimeSpan(0,0,1),
                        Keys.RButton),
                    new Active(
                        "Micro Missiles",
                        "D.Va launches a volley of explosive rockets.",
                        new TimeSpan(0,0,8),
                        Keys.E)
                });

            //Sombra
            Hero Sombra = new Hero(
                "Sombra",
                200,
                "Stealth and debilitating attacks make Sombra a powerful infiltrator. Her hacking can disrupt her enemies, ensuring they're easier to take out, while her EMP provides the upper hand against multiple foes at once. Sombra’s ability to Translocate and camouflage herself makes her a hard target to pin down.",
                "Female",
                "Damage",
                3,
                new List<Abillity>{
                    new Passive(
                        "Opportunist",
                        "Sombra detects critically injured enemies through walls.",
                        TimeSpan.Zero
                        ),
                    new Active(
                        "Machine Pistol",
                        "Sombra’s fully-automatic machine pistol fires in a short-range spread.",
                        new TimeSpan(0,0,4),
                        Keys.LButton),
                    new Active(
                        "Hack",
                        "Sombra hacks enemies to temporarily stop them from using their abilities, or hacks first aid kits to make them useless to her opponents.",
                        new TimeSpan(0,0,8),
                        Keys.RButton),
                    new Active(
                        "Stealth",
                        "Sombra becomes invisible, during which her speed is boosted considerably. Attacking, using offensive abilities, or taking damage disables her camouflage. Sombra cannot capture objectives while invisible.",
                        new TimeSpan(0,0,6),
                        Keys.Shift),
                    new Active(
                        "Translocator",
                        "Sombra tosses out a translocator beacon. She can instantly return to the beacon’s location while it is active (including when it’s in mid-flight).",
                        new TimeSpan(0,0,6),
                        Keys.E)
                });

            //Mercy
            Hero Mercy = new Hero(
                "Mercy",
                200,
                "Mercy’s Valkyrie Suit helps keep her close to teammates like a guardian angel; healing, resurrecting or strengthening them with the beams emanating from her Caduceus Staff.",
                "Female",
                "Support",
                1,
                new List<Abillity>{
                    new Passive(
                        "Regeneration",
                        "Mercy automatically heals over time.",
                        TimeSpan.Zero
                        ),
                    new Active(
                        "Caduceus Staff (heal)",
                        "Mercy engages one of two beams that connect to an ally. By maintaining the beams, she can either restore that ally’s health or increase the amount of damage they deal.",
                        TimeSpan.Zero,
                        Keys.LButton),
                    new Active(
                        "Caduceus Staff (Dmg boost)",
                        "Mercy engages one of two beams that connect to an ally. By maintaining the beams, she can either restore that ally’s health or increase the amount of damage they deal.",
                        TimeSpan.Zero,
                        Keys.RButton),
                    new Active(
                        "Caduceus Blaster",
                        "Mercy shoots a round from her sidearm.",
                        new TimeSpan(0,0,6),
                        Keys.LButton),
                    new Active(
                        "Guardian Angel",
                        "Mercy flies towards a targeted ally, allowing her to reach them quickly and provide assistance in crucial moments.",
                        new TimeSpan(0,0,0,1,500),
                        Keys.Shift),
                    new Active(
                        "Resurrect",
                        "Mercy shoots a round from her sidearm.",
                        new TimeSpan(0,0,30),
                        Keys.E),
                    new Active(
                        "Angelic Descent",
                        "Propelled by her Valkyrie suit, Mercy slows the speed of her descent from great heights.",
                        TimeSpan.Zero,
                        Keys.Space),
                });

            heroes.Add(Dva);
            heroes.Add(Sombra);
            heroes.Add(Mercy);

            rebindListboxes();
        }

        public void rebindListboxes()
        {
            lbxHeroes.DataSource = null;
            lbxHeroes.DataSource = heroes;
        }

        private void lbxHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            rebindListboxes();

            if (lbxHeroes.DataSource == heroes)
            {
                Hero selectedhero = heroes[lbxHeroes.SelectedIndex];


                txtHero.Text =
                    $"Name: {selectedhero.name} \t {new String('★', selectedhero.difficulty) }{ new String('☆', 3 - selectedhero.difficulty) } {Environment.NewLine}" +
                    $"Base HP: {selectedhero.hp} {Environment.NewLine}" +
                    $"Gender:{selectedhero.gender}{Environment.NewLine}" +
                    $"Class: {selectedhero.classification} {Environment.NewLine}" +
                    $"Bio: {Environment.NewLine}" +
                    $"{selectedhero.bio} {Environment.NewLine}";

                this.Height = 224;
                gbAblities.Controls.Clear();
                int i = 0;
                foreach (var ability in selectedhero.abilities)
                {
                    TextBox newAbilityBox = new TextBox();
                    newAbilityBox.Text =
                        $"{ability.name.ToUpper()}" +
                        $"{Environment.NewLine}" +
                        $"{ability.discription} {Environment.NewLine}" +
                        $"cooldown: {ability.cooldown.TotalSeconds} seconds{Environment.NewLine}";
                    
                    newAbilityBox.Height = 100;
                    newAbilityBox.Width = gbAblities.Width - 10;
                    newAbilityBox.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
                    newAbilityBox.Multiline = true;
                    newAbilityBox.Location = new Point(0, 10 + newAbilityBox.Height * i);
                    newAbilityBox.Enabled = false;
                    newAbilityBox.Name = ability.name;

                    gbAblities.Controls.Add(newAbilityBox);
                    this.Height += newAbilityBox.Height;
                    i++;

                }

            }


        }
    }
}
