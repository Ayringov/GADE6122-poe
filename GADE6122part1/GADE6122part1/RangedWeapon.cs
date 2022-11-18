using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class RangedWeapon : Weapon
    {


        public enum Types
        {
            RIFLE,
            LONGBOW,
        }

        public override int Range
        {
            get { return 1; }
        }

        public RangedWeapon(Enum Type, int x = 0, int y = 0) : base(x, y)
        {
            if (Type is Types.RIFLE)
            {
                damage = 5;

                durability = 3;

                range = 3;

                cost = 7;

                weaponType = "Rifle";

            }
            else if (Type is Types.LONGBOW)
            {

                damage = 4;

                durability = 4;

                range = 3;

                cost = 7;

                weaponType = "Longbow";

            }
        }
    }
}
