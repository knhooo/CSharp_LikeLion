using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _2502251
{
    class Program
    {
        static void Main(string[] args)
        {
            ///swith문
            int day = 1;

            switch (day)
            {
                case 1:
                    Console.WriteLine("월요일");
                    break;
                case 2:
                    Console.WriteLine("화요일");
                    break;
                case 3:
                    Console.WriteLine("수요일");
                    break;
                case 4:
                    Console.WriteLine("목요일");
                    break;
                case 5:
                    Console.WriteLine("금요일");
                    break;
                default:
                    Console.WriteLine("주말");
                    break;
            }

            Console.Write("캐릭터를 선택하세요(1.검사 2. 마법사 3.도적) :");
            int select = int.Parse(Console.ReadLine());
            Console.WriteLine("==========================");
            switch (select)
            {
                case 1:
                    Console.WriteLine("검사");
                    Console.WriteLine("공격력 : 100");
                    Console.WriteLine("방어력 : 90");
                    break;
                case 2:
                    Console.WriteLine("마법사");
                    Console.WriteLine("공격력 : 110");
                    Console.WriteLine("방어력 : 70");
                    break;
                case 3:
                    Console.WriteLine("도적");
                    Console.WriteLine("공격력 : 115");
                    Console.WriteLine("방어력 : 80");
                    break;

            }

            / for문
            for (초기값; 조건식; 증감식)
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"숫자: {i}");
                }

            for (; ; )
            {
                Console.WriteLine("무한반복");
            }

            //0부터 9까지 출력하기
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //1부터 10까지의 합 구하기
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("1부터 10까지의 합: " + sum);

            ///while문
            int count = 0;
            while (true)
            {
                Console.WriteLine("Count : " + count);
                count++;
                if (count == 3)//무한 루프 탈출 조건
                {
                    Console.WriteLine("while문 종료 ");
                    break;//무한 루프 탈출 조건
                }
            }
            Console.WriteLine("Count : " + count);

            ///랜덤값
            Random rand = new Random();//랜덤 객체를 생성한다.

            //0이상 10 미만의 랜덤 정수 생성
            for (int i = 0; i < 10; i++)
            {
                int randNum = rand.Next(0, 10);//0~9
                Console.WriteLine("0이상 10 미만의 랜덤 정수: " + randNum);
            }

            Console.WriteLine("대장장이 키우기\n");

            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                int randNum = rand.Next(0, 101);
                if (randNum >= 1 && randNum <= 10)
                {
                    Console.WriteLine("도끼 등급 SSS 획득!!!");
                }
                else if (randNum >= 11 && randNum <= 40)
                {
                    Console.WriteLine("도끼 등급 SS 획득!!");
                }
                else
                {
                    Console.WriteLine("도끼 등급 S 획득!");
                }
                Thread.Sleep(500);//0.5초 대기
            }

            int x = 5;
            do
            {
                Console.WriteLine("최소 한번은 실행됩니다.");
                x--;
            } while (x > 0);

            ///break문
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            ///continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다.
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);//홀수만 출력
            }

            ///goto문
            int n = 1;
            start:
            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;
                goto start; //레이블로 이동
            }
        }
    }

    
}
