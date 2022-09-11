using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
     abstract class Enemy : Character
    {
        static protected Random random;
        public Enemy(int x, int y, int damage, int hp) : base(x, y, TileType.Enemy)
        {
            this.damage = damage;
            this.hp = hp;
            this.maxHp = hp;
            random = new Random();
        }

        public override string ToString()
        {
            return GetType() + " at [" + x + ", " + y + " ] (" + damage + ")";
        }

    }
}
