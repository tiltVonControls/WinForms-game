using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devon_McManus_final_progect
{
    class enemy
    {
        //0: str 1: dex 2: end 3: agl 4: wis 5: int 6: cha
        public int[] stat;
        public string name;
        public int level;
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

    }
}
