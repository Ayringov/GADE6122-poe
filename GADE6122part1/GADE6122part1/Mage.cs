using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class Mage : Enemy
    {
        public Mage(int x, int y) : base(x, y, 5, 5)
        {

        }

        public override Movement ReturnMove(Movement move = Movement.No_Movement)
        {
            return Movement.No_Movement;
        }

        public override bool CheckRange(Character target)
        {
            for (int tx = x - 1; x <= x + 1; x++)
            {
                for (int ty = y - 1; y <= y + 1; y++)
                {
                    if (tx == x && ty == y)
                    {
                        continue;
                    }
                    if (target.X == tx && target.Y == ty)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
