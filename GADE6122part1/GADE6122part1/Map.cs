using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class Map
    {
        Tile[,] map;
        Hero hero;
        Enemy[] enemies;
        int width;
        int height;

        Random random = new Random();

        public Hero Hero
        {
            get { return hero; }
        }

        public Enemy[] Enemies
        {
            get { return enemies; }
        }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies)
        {


            width = random.Next(minWidth, maxWidth + 1);
            height = random.Next(minHeight, maxHeight + 1);
            map = new Tile[width, height];

            enemies = new Enemy[numEnemies];


            InitializeMap();

            // hero
            hero = (Hero)Create(Tile.TileType.Hero);
            //creates Swamp creatures
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (Enemy)Create(Tile.TileType.Enemy);
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
                case Tile.TileType.Enemy: return map[x, y] = new SwampCreature(x, y);
                      

            }
            if (type == Tile.TileType.Hero)
            {
                return map[x, y] = new Hero(x, y, 10);


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
