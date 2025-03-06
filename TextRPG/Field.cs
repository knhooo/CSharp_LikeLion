using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class Field
    {
        Player m_Player = null;
        //몬스터
        Monster m_Monster = null;

        //Maingame에서 생성한 player 가져오기
        //플레이어가 필드에서 전투를 하면 데미지를 입고, hp가 감소한다.
        //ref 사용

        public void SetPlayer(ref Player pPlayer)
        {
            m_Player = pPlayer;
        }
        public void Progress()
        {
            //사냥터 입장
            int input = 0;
            while (true)
            {
                Console.Clear();
                m_Player.Render();
                DrawMap();

                input = int.Parse(Console.ReadLine());
                if (input == 4) break;
                if(input <= 3)
                {
                    //몬스터 생성
                    CreateMonster(input);
                    //전투
                    Fight();
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1.초보맵");
            Console.WriteLine("2.중수맵");
            Console.WriteLine("3.고수맵");
            Console.WriteLine("4.전단계");
            Console.WriteLine("============");
            Console.WriteLine("맵을 선택하세요: ");
        }

        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();//몬스터 생성
            INFO Monster = new INFO();//몬스터 데이터 메모리 주기 객체 생성

            Monster.strName = _strName;//이름
            Monster.iHp = _iHp;//체력
            Monster.iAttack = _iAttack;//공격력

            pMonster.SetMonster(Monster);
            

        }
        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, out m_Monster);
                    break;
                case 2:
                    Create("중수몹", 60, 6, out m_Monster);
                    break;
                case 3:
                    Create("고수몹", 90, 9, out m_Monster);
                    break;
            }
        }
        public void Fight()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();//콘솔 화면 지우기
                m_Player.Render();//플레이어 정보 출력
                m_Monster.Render();//몬스터 정보 출력

                Console.WriteLine("1.공격 2. 도망 : ");
                input = int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    //플레이어 데미지
                    m_Player.SetDamage(m_Monster.GetMonster().iAttack);
                    //몬스터 데미지
                    m_Monster.SetDamage(m_Player.GetInfo().iAttack);

                    if (m_Player.GetInfo().iHp <= 0)//플레이어 체력이 0 이하
                    {
                        m_Player.SetHP(100);
                        break;
                    }
                }
                if(input == 2 || m_Monster.GetMonster().iHp <= 0)
                {
                    m_Monster = null;
                    break;//탈출
                }
            }
        }
        public Field() { }
        ~Field() { }
    }
}
