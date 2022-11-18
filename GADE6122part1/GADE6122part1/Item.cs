using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    public abstract class Item : Tile
    {
        public Item(int x, int y, TileType type) : base(x, y, TileType.Item)
        {

        }



        protected Item(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public abstract override string ToString();

    }
}
