using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class Player : Info
    {
        public Player() { }
        public Player(string _name, int _hp, int _att)
        {
            name = _name;
            hp = _hp;
            att = _att;
        }
        public void PrintInfo()
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine($"{name} \n체력: {hp} 공격력: {att}");
        }

        public void SelectJob(Player player)
        {
            Console.Write("직업을 선택하세요: 1.전사 2.마법사 3.도적: ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1://기사
                    player.name = "기사"; player.hp = 100; player.att = 10;
                    break;
                case 2://마법사
                    player.name = "마법사"; player.hp = 90; player.att = 15;
                    break;
                case 3://도둑
                    player.name = "도둑"; player.hp = 85; player.att = 9;
                    break;
            }
            PrintInfo();
        }

        public void ResetHp()
        {
            hp = 100;
        }


    }
}
