using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    public abstract class Weapon : Item
    {
        protected int damage;
        protected int range;
        protected int duribility;
        protected int cost;
        protected string weaponType;

        public int Damage
        {
            get { return damage; }
        }
        public virtual int Range
        {
            get { return range; }

        }
        public int Duribility
        {
            get { return duribility; }

        }
        public int Cost
        {
            get { return cost; }
        }
        public Weapon(int x, int y) : base(x, y, TileType.Weapon)
        {

        }

        public override string ToString()
        {
            return "weapon is " + weaponType + " its range is " + Range + " its durability is " + duribility + " and it costs " + cost;
        }

    }
}
