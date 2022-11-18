using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class MeleeWeapon : Weapon
    {
        public enum Types
        {
            DAGGER,
            LONGSWORD,
        }

        public override int Range
        {
            get { return 1; }
        }
        public MeleeWeapon(Enum Type, int x = 0, int y = 0) : base(x, y)
        {
            if (Type is Types.DAGGER)
            {
                damage = 3;

                durability = 10;

                cost = 3;

                weaponType = "Dagger";
                 
            }
            else if (Type is Types.LONGSWORD)
            {

                damage = 4;

                durability = 6;

                cost = 5;

                weaponType = "Longsword";

            }
        }
    }
}
