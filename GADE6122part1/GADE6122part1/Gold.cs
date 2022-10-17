using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class Gold : Item
    {
        private int goldAmount;
        static Random random = new Random();

        public Gold(int x, int y) : base(x, y)
        {
            goldAmount = random.Next(1, 6);
        }
        public int GoldAmount
        {
            get { return goldAmount; }

        }
        public override string ToString()
        {
            return "";
        }
    }
}
