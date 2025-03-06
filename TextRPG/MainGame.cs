using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    class MainGame
    {
        public Player m_Player = null;
        public Field m_Field = null;

        //초기화 함수
        public void Initialize()
        {
            //플레이어 생성 및 직업 선택
            m_Player = new Player();
            m_Player.SelectJob();
        }

        //게임의 전체적인 프로세스
        public void Progress()
        {
            int iInput = 0;

            while (true) {
                Console.Clear();
                m_Player.Render();//플레이어 출력
                Console.WriteLine("1.사냥터 2.종료: ");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 2)
                {
                    break;
                }
                if(iInput == 1)
                {
                    //사냥터 구현
                    if(m_Field == null)
                    {
                        m_Field = new Field();
                        //필드로 갈 때 플레이어 넣기
                        m_Field.SetPlayer(ref m_Player);
                    }
                    m_Field.Progress();
                }
            }
        }
        public MainGame() { }
        ~MainGame() { }
    }
}
