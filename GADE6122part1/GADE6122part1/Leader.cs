using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class Leader : Enemy
    {
        public Leader(int x, int y) : base(x, y, 20, 2)
        {
            //weapon = MeleeWeapon.Types.LONGSWORD;
        }

        private Tile leaderTarget;
        public Tile LeaderTarget
        {
            get { return leaderTarget; }


            set
            {
                leaderTarget = value;
            }
        }

        public override Movement ReturnMove(Movement move = Movement.No_Movement)
        {

            int dir = random.Next(1, 5);

            int maxTries = 10;
            int tries = 0;
            while (vision[dir - 1].Type != TileType.Empty && tries < maxTries)
            {
                dir = random.Next(1, 5);
                tries++;

                if (tries == maxTries)
                {
                    return Movement.No_Movement;
                }
            }
                //              (Q 3.3)     *Movement Logic *, Commented to Keep errors way
                       //int higherDir = 0;
                       //int temp = 0;
                       //if (this.y - DistanceTo(leaderTarget.y >= 0)) //Up
                       //{
                       //    higherDir = 1;
                       //}
                       //else if (this.y - DistanceTo(leaderTarget.y < 0)) //Down
                       //{
                       //    higherDir = 2;
                       //}
                       //else if (this.x - DistanceTo(leaderTarget.x <= 0)) //Left
                       //{
                       //    higherDir = 3;
                       //}
                       //else //Right
                       //{
                       //    higherDir = 4;
                       //}
                       //dir = higherDir;

            
            return (Movement)dir;

        }


        public override bool CheckRange(Character target)
        {
            return base.CheckRange(target);
        }

    }
}
