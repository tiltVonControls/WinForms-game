using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devon_McManus_final_progect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            statLoad();

        }

        public void statLoad()
        {
            player party1 = new player();
            party1.name = "Devon";
            party1.level = 1;
            party1.stat[0] = 8;
            party1.stat[1] = 10;
            party1.stat[2] = 10;
            party1.stat[3] = 13;
            party1.stat[4] = 18;
            party1.stat[6] = 20;
            party1.playerClass = "wizard";
            party1.weaponEq = "knife";
            party1.armourEq = "robes";
/*            party[1].name = "A.J";
            party[2].name = "Jesse";
            party[3].name = "Hayley";*/
            HP1.Text = party1.health.ToString();
            MANA1.Text = party1.mana.ToString();
        }




        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void attack1_Click(object sender, EventArgs e)
        {

        }

        private void spells_Click(object sender, EventArgs e)
        {
            Spells spell = new Spells();
            spell.Show();
            this.Hide();
        }
    }
}
