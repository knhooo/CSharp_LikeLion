using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250306Task
{
    class Player : Info
    {
        //직업 선택
        public void SelectJob()
        {

            Console.WriteLine("직업을 선택하세요(1.기사 2.마법사 3.도둑) : ");
            int input = 0;

            input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Name = "기사";
                    Hp= 100;
                    Attack = 10;
                    break;
                case 2:
                    Name = "마법사";
                    Hp = 90;
                    Attack = 15;
                    break;
                case 3:
                    Name = "도둑";
                    Hp = 85;
                    Attack = 13;
                    break;
            }
        }
        //정보 출력
        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("직업 이름 : " + Name);
            Console.WriteLine("체력 : " + Hp + "\t공격력 :  " + Attack);
        }

        public Player() { }

        ~Player() { } //소멸자
    }
}
