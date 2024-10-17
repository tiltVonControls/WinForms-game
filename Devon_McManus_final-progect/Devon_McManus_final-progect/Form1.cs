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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class player
        {
            //0: str 1: dex 2: end 3: agl 4: wis 5: int 6: cha
            public int[] stat;
            public string name;
            public int level;
            public string playerClass;
            public int health
            {
                get { return health; }
                set { health = (level + stat[2]) * 8; }
            }
            public int mana
            {
                get { return mana; }
                set { mana = (level + stat[5]) * 6; }
            }
            // hitting the enemy 
            public int pysHit
            {
                get { return pysHit; }
                set { pysHit = (level + stat[3]); }
            }
            public int magHit
            {
                get { return magHit; }
                set { magHit = (level + stat[4]); }
            }
            public string weaponEq;
            public string armourEq;
            public string[] weaponsInv;
            public string[] armourInv;
            public string[] healthInv;
            public string[] spells;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Debug_Click(object sender, EventArgs e)
        {

            Console.WriteLine("starting game");
            Form2 debugStart = new Form2();
            debugStart.Show();
            this.Hide();
        }
    }
}
