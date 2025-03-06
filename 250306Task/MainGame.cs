using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250306Task
{
    class MainGame
    {
        public Player player = null;//플레이어 객체
        public Field field = null;//필드 객체
        
        //초기화
        public void Init()
        {
            //플레이어 생성
            player = new Player();
            //직업 선택
            player.SelectJob();
        }

        //게임 진행
        public void Progress()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();//콘솔 지우기
                player.Render();//플레이어 정보 출력
                Console.WriteLine("1.사냥터 2. 종료: ");
                input = int.Parse(Console.ReadLine());

                if (input == 2) break;//종료
                if(input == 1) //사냥터
                {
                   if(field == null)
                    {
                        field = new Field();//필드 생성
                        field.SetPlayer(ref player);

                    }
                    field.Progress();//사냥터 진행
                }
            }
        }

        public MainGame() { }//생성자
        ~MainGame() { }//소멸자
    }
}
