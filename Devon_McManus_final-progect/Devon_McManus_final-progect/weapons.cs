using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devon_McManus_final_progect
{
    abstract class weapons
    {
        public abstract string name();
        public abstract int dam();
        //how many times it can hit
        public abstract int hitTime();
    }
    class sword : weapons
    {
        public override string name() => "Sword";
        public override int dam() => 14;
        public override int hitTime() => 1;
    }
    class axe : weapons
    {
        public override string name() => "Axe";
        public override int dam() => 15;
        public override int hitTime() => 1;
    }
    class knife : weapons
    {
        public override string name() => "Knife";
        public override int dam() => 10;
        public override int hitTime() => 3;
    }
    class mace : weapons
    {
        public override string name() => "Mace";
        public override int dam() => 16;
        public override int hitTime() => 1;
    }
}
