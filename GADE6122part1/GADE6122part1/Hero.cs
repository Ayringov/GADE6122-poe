using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class Hero : Character
    {
        
        public Hero(int x, int y, int hp) : base(x, y, TileType.Hero)
        {
            this.hp = 10;
            this.damage = 2;
            this.maxHp = 10;
        }


        public override Movement ReturnMove(Movement move = 0)
        {
            int dir = (int)move - 1;
            Tile tile = vision[dir];

            if (tile != null)
            {
                if (tile.Type == TileType.Empty)
                {
                    return move;
                }
            }

            return Movement.No_Movement;


        }

        public override string ToString()
        {
            return "player stats: \n" +
                "hp: " + hp + "/" + maxHp + "\n" +
                "Damage: " + damage + "\n" +
                "Gold: " + goldbag + "\n" +
                "[" + x + "," + y + "]";
        }

    }
}
