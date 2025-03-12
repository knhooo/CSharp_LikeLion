using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class Monster :Info
    {
        public void PrintInfo()
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"{name} \n체력: {hp} 공격력: {att}");
        }

        public Monster() { }
        public Monster(string _name, int _hp, int _att)
        {
            name = _name;
            hp = _hp;
            att = _att;
        }

        public void CreateMonster(Monster mob,int n)
        {
            switch (n)
            {
                case 1:
                    mob.name = "초수몹"; mob.hp = 30; mob.att = 3;
                    break;
                case 2:
                    mob.name = "중수몹"; mob.hp = 60; mob.att = 6;
                    break;
                case 3:
                    mob.name = "고수몹"; mob.hp = 90; mob.att = 9;
                    break;
            }
            PrintInfo();
        }
    }
}
