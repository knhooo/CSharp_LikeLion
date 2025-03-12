using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    class Field
    {
        Player player = new Player();
        Monster monster = new Monster();

        public void Setting(ref Player _player)
        {
            player = _player;
        }
        public void Battle(Player player)
        {
            while (true)
            {
                player.PrintInfo();
                monster.PrintInfo();

                Console.Write("1. 공격 2. 도망: ");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)//공격
                {

                    player.GetDamage(monster.att);
                    monster.GetDamage(player.att);

                    
                }
                else//도망
                    break;
                if (player.hp <= 0)//플레이어 사망
                {
                    player.ResetHp();
                    break;
                }
                if (monster.hp <= 0)//몬스터 사망
                {
                    break;
                }
            }
            Menu(player);
        }

        public void SelectMap(Player player, Monster monster)
        {
            Console.Clear();
            player.PrintInfo();
            //사냥터
            Console.WriteLine("1. 초수맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 뒤로가기");
            Console.WriteLine("====================");
            Console.Write("맵을 선택하세요: ");
            int select = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (select)
            {
                case 1:
                    monster.CreateMonster(monster, 1); Battle(player);
                    break;
                case 2:
                    monster.CreateMonster(monster, 2); Battle(player);
                    break;
                case 3:
                    monster.CreateMonster(monster, 3); Battle(player);
                    break;
                case 4:
                    //뒤로가기
                    break;
            }

        }

        public void Menu(Player player)
        {
            Console.Clear();
            player.PrintInfo();
            Console.Write("1. 사냥터 2. 종료: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                SelectMap(player, monster);
            }
            else//종료
            {
            }
        }
       

    }

}