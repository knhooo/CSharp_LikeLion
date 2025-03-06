using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250306Task
{
    class Field
    {
        Player player = null;
        Monster monster = null;

        public void SetPlayer(ref Player _player)
        {
            player = _player;
        }

        public void Progress()
        {
            //사냥터
            int input = 0;
            while (true)
            {
                Console.Clear();

                player.Render();//플레이어 정보 출력
                DrawMap();

                input = int.Parse(Console.ReadLine());

                if (input == 4) break;//뒤로가기
                if(input <= 3)
                {
                    CreateMonster(input);//몬스터 생성
                    Fight();//전투
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1.초보맵");
            Console.WriteLine("2.중수맵");
            Console.WriteLine("3.고수맵");
            Console.WriteLine("4.뒤로가기");
            Console.WriteLine("============");
            Console.WriteLine("맵을 선택하세요 : ");
        }

        public void Create(string _name, int _hp, int _attack, out Monster mob)
        {
            mob = new Monster();//몬스터 생성
            Info mobInfo = new Info();//몬스터 정보

            mobInfo.Name = _name;//몬스터 이름
            mobInfo.Hp = _hp;//몬스터 체력
            mobInfo.Attack = _attack;//몬스터 공격력

            mob.SetMonster(_name,_hp,_attack);
        }

        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초급 몬스터", 30, 3, out monster);
                    break;
                case 2:
                    Create("중수 몬스터", 60, 6, out monster);
                    break;
                case 3:
                    Create("고수 몬스터", 90, 9, out monster);
                    break;
            }
        }

        public void Fight()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();//콘솔 화면 지우기
                player.Render();//플레이어 정보 출력
                monster.Render();//몬스터 정보 출력

                Console.WriteLine("1.공격한다 2.도망간다 : ");
                input = int.Parse(Console.ReadLine());

                if(input == 1)//공격한다
                {
                    player.SetDamage(monster.Attack);//플레이어 체력 감소
                    monster.SetDamage(player.Attack);//몬스터 체력 감소

                    if(player.Hp <= 0)//플레이어 체력이 0 이하일 경우
                    {
                        player.SetHp(100);
                        break;
                    }
                }
                if(input == 2 || monster.Hp <=0)//도망가거나 몬스터 처치 시
                {
                    monster = null;
                    break;//탈출
                }
            }
        }
        public Field() { }
        ~Field() { }
    }
}
