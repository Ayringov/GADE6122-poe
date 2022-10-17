using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    abstract class Item : Tile
    {
        public Item(int x, int y) : base(x, y, TileType.Item)
        {
        }

        public abstract override string ToString();

    }
}
