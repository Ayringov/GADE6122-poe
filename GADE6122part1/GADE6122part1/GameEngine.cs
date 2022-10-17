using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class GameEngine
    {

        Map map;
        public Hero hero;

        public GameEngine()
        {
            map = new Map(10, 25, 10, 25, 5, 5);
            hero = map.Hero;
        }
        public string View
        {
            get { return map.ToString(); }
        }


        public bool MovePlayer(Movement desiredMove)
        {
            Movement allowedMove = map.Hero.ReturnMove(desiredMove);
            map.Hero.Move(allowedMove);
            
            EnemiesMove();
            map.Update();
            EnemiesAttack();


            Item item = map.GetItemAtPosition(map.Hero.X, map.Hero.Y);
            if (item != null)
            {
                map.Hero.Pickup(item);
            }

            if (allowedMove == Movement.No_Movement)
            {
                return false;
            }

            return true;
        }

        public string PlayerAttack(Tile.AttackDirection direction)
        {
            int visionIndex = (int)direction;
            string attackFailed = "Hero's attack has failed";


            if (map.Hero.Vision[visionIndex].Type == Tile.TileType.Enemy)
            {
                Enemy enemy = (Enemy)map.Hero.Vision[visionIndex];
                if (enemy.IsDead())
                {
                    return attackFailed;
                }

                map.Hero.Attack(enemy);
                EnemiesAttack();
                map.Update();

                if (enemy.IsDead())
                {
                    return "Hero killed enemy";
                }

                return "Hero attacked enemy\n" +
                    "Enemy HP: " + enemy.HP + "/" + enemy.MaxHP;   

            }
            return attackFailed;

        }

        void EnemiesMove()
        {
            foreach (Enemy enemy in map.Enemies)
            {
                if (enemy.IsDead())
                {
                    continue;
                }
                Movement allowedMove = enemy.ReturnMove();
                enemy.Move(allowedMove);
            }
        }

        void EnemiesAttack()
        {
            foreach (Enemy enemy in map.Enemies)
            {
                for (int i = 0; i < enemy.Vision.Length; i++)
                {                  
                    if (enemy.Vision[i] == null)
                    {
                        continue;
                    }     
                    if (enemy is SwampCreature && enemy.Vision[i] is Hero)
                    {
                        enemy.Attack(map.Hero);
                    }
                    if (enemy is Mage && enemy.Vision[i] is Character)
                    {
                        Character target = (Character)enemy.Vision[i];
                        enemy.Attack(target);
                    }
                }
            }
        }
    }
}
