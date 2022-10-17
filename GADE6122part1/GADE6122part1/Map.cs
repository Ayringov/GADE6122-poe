using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class Map
    {
        //TEST
        Tile[,] map;
        Hero hero;
        Enemy[] enemies;
        int width;
        int height;
        Item[] items;

        Random random = new Random();

        public Hero Hero
        {
            get { return hero; }
        }

        public Enemy[] Enemies
        {
            get { return enemies; }
        }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies, int numItems)
        {


            width = random.Next(minWidth, maxWidth + 1);
            height = random.Next(minHeight, maxHeight + 1);
            map = new Tile[width, height];

            enemies = new Enemy[numEnemies];
            items = new Item[numItems];


            InitializeMap();

            // hero is created
            hero = (Hero)Create(Tile.TileType.Hero);
            //creates Swamp creatures and now mages
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (Enemy)Create(Tile.TileType.Enemy);
            }
            //creates gold
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = (Item)Create(Tile.TileType.Gold);
            }


            Update();
            UpdateVision();
        }


        private void InitializeMap()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                    {
                        map[x, y] = new Obstacle(x, y);
                    }
                    else
                    {
                        map[x, y] = new EmptyTile(x, y);
                    }

                }
            }
        }



        private Tile Create(Tile.TileType type)
        {
            int x = random.Next(0, width);
            int y = random.Next(0, height);

            while (map[x, y].Type != Tile.TileType.Empty)
            {
                x = random.Next(0, width);
                y = random.Next(0, height);
            }


            switch (type) 
        
            {
                case Tile.TileType.Hero: return map[x, y] = new  Hero(x, y, 10);


            }
            if (type == Tile.TileType.Enemy)
            {
                if (random.Next(0, 2) == 1)
                {
                    map[x, y] = new SwampCreature(x, y);
                }
                else
                {
                    map[x, y] = new Mage(x, y);
                }


            }
            if (type == Tile.TileType.Gold)
            {
                map[x, y] = new Gold(x, y);
            }

            return map[x, y];
        }

        public void Update()
        {
            InitializeMap();

            map[hero.X, hero.Y] = hero;

            for (int i = 0; i < enemies.Length; i++)
            {
                Enemy currentEnemy = enemies[i];
                map[currentEnemy.X, currentEnemy.Y] = enemies[i];
            }

            for (int i = 0; i < items.Length; i++)
            {
                Item item = items[i];
                if (item != null)
                {
                    map[item.X, item.Y] = item;
                }

            }

        }

        public void SetEmptyTile(int x, int y)
        {
            if (x < 0 || x > width || y < 0 || y > height)
            {
                return;
            }

            map[x, y] = new EmptyTile(x, y);
        }

        public Tile GetTileAt(int x, int y)
        {
            if (x < 0 || x > width || y < 0 || y > height)
            {
                return null;
            }

            return map[x, y];
        }

        public void UpdateVision()
        {
            UpdateCharacterVision(hero);

            for (int i = 0; i < enemies.Length; i++)
            {
                UpdateCharacterVision(enemies[i]);
            }
        }

        private void UpdateCharacterVision(Character character)
        {
            Tile tileUp = null;
            Tile tileDown = null;
            Tile tileLeft = null;
            Tile tileRight = null;

            if (character.Y - 1 < height)
            {
                tileUp = map[character.X, character.Y + 1];
            }
            if (character.Y + 1 >= 0)
            {
                tileDown = map[character.X, character.Y - 1];
            }
            if (character.X - 1 >= 0)
            {
                tileLeft = map[character.X - 1, character.Y];
            }
            if (character.X + 1 < width)
            {
                tileRight = map[character.X + 1, character.Y];
            }

            character.SetVision(tileUp, tileDown, tileLeft, tileRight);
        }

        public Item GetItemAtPosition(int x, int y)
        {
            
            for (int i = 0; i < items.Length; i++)
            {

                if (items[1] == null)
                {
                    continue;
                }

                if (items[i].X == x && items[i].Y == y)
                {
                    Item temItem = items[i];
                    items[i] = null;
                    return temItem;
                }
            }


            return null;
        }


        public override string ToString()
        {
            int value = 0;
            string mapString = " ";
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Tile.TileType currentType = map[x, y].Type;
                    if (Hero.X == x && Hero.Y == y)
                    {
                        mapString += 'H';
                        continue;
                    }
                    if (currentType == Tile.TileType.Enemy)
                    {
                        Enemy enemy = (Enemy)map[x, y];
                        if (enemy.IsDead())
                        {
                            mapString += " ";
                        }
                        else
                        {
                            if (enemy is SwampCreature)
                            {
                                mapString += ('S' + "" + 'C');
                            }
                            else if (enemy is Mage)
                            {
                                mapString += "M";
                            }
                        }
                    }

                    else if (currentType == Tile.TileType.Item)
                    {
                        if (map[x, y] is Gold)
                        {
                            
                            Gold gold = (Gold)map[x, y];
                            mapString += gold.GoldAmount;
                        }

                    }

                    else if (currentType == Tile.TileType.Empty)
                    {
                        mapString += '.';
                    }
                    else if (currentType == Tile.TileType.Obstacle)
                    {
                        mapString += 'X';
                    }

                }
                mapString += "\n";
            }
            return mapString;
        }


        

    }
}
