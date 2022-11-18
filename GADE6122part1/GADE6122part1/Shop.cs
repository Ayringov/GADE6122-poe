using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class Shop
    {
        private Weapon[] weapon;
        private Random random = new Random();
        private Character character;

        //public Shop(Character input)
        //{
        //    weapon = new Weapon[2];


        //    for (int i = 0; i <= 2; i++)
        //    {
        //        weapon[i] = RandomeWeapon();
        //    }
        //}

        //private Weapon RandomeWeapon()
        //{
        //    Weapon output;
        //    MeleeWeapon longSword = new MeleeWeapon(MeleeWeapon.Types.LONGSWORD);
        //    MeleeWeapon dagger = new MeleeWeapon(MeleeWeapon.Types.DAGGER);
        //    RangedWeapon rifle = new RangedWeapon(RangedWeapon.Types.RIFLE);
        //    RangedWeapon longbow = new RangedWeapon(RangedWeapon.Types.LONGBOW);

        //    switch (random) //Donno how else to do this
        //    {
        //        case 0:
        //            output = dagger;
        //            break;

        //        case 1:
        //            output = longSword;
        //            break;

        //        case 2:
        //            output = rifle;
        //            break;

        //        case 3:
        //            output = longbow;
        //            break;
        //    }

        //    return output;

        //}

        //public bool CanBuy(int num)
        //{
        //    Gold gold = new Gold();

        //    if (gold.GoldAmount >= num)
        //    {
        //        return true;
        //    }
        //    return false;

        //}

        //public void Buy(int num)
        //{
        //    Gold gold = new Gold(int x = 0, int y = 0);
        //    MeleeWeapon meleeWeapon = new MeleeWeapon(MeleeWeapon.TileType.Weapon);
        //    Character.Pickup((Item)num);
        //    weapon[num] = RandomeWeapon();
        //}
        public string DisplayWeapon(int num)
        {
            string stringed = "";
            return stringed;
        }



    }
}
