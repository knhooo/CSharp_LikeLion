using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2502252
{
    class Program
    {
        static void Main(string[] args)
        {
            //랜덤
            Random rand = new Random();

            int pmoney = 100;
            int rnd;
            int input;

            Console.Write("\n [대장장이 키우기] \n");
            Console.Write("\n시작하려면 엔터를 누르세요...");
            Console.ReadLine();
            Thread.Sleep(1000);//1000 == 1초(1000밀리초)
            while (true)
            {
                //==============메뉴   화면========================
                Console.Clear();//콘솔 화면 지우기
                Console.Write(
                   "1. 나무 캐기\n" +
                   "2. 장비 뽑기\n" +
                   "3. 나가기\n"
                   );
                Console.Write("입력: ");
                input = int.Parse(Console.ReadLine());


                if (input == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기(x)");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금: " + pmoney);
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }
                }
                //==============장비 뽑기 화면======================
                else if (input == 2)
                {
                    if (pmoney >= 1000)//돈이 있는지 확인 후 뽑기
                    {
                        pmoney -= 1000;

                        //20번 뽑기
                        for (int i = 1; i <= 20; i++)
                        {
                            rnd = rand.Next(1, 101);

                            if (rnd == 1)//1퍼
                            {
                                Console.WriteLine("***도끼 등급 SSS 획득!!***");
                            }
                            else if (rnd >= 2 && rnd <= 6)
                            {
                                Console.WriteLine("**도끼 등급 SS 획득!!**");
                            }
                            else if (rnd >= 7 && rnd <= 17)
                            {
                                Console.WriteLine("*도끼 등급 S 획득!!*");
                            }
                            else if (rnd >= 18 && rnd <= 38)
                            {
                                Console.WriteLine("도끼 등급 A 획득!");
                            }
                            else if (rnd >= 39 && rnd <= 60)
                            {
                                Console.WriteLine("도끼 등급 B 획득!");
                            }
                            else
                            {
                                Console.WriteLine("도끼 등급 C 획득!");
                            }
                            Thread.Sleep(1000);//1초 대기
                        }
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다.\n");
                        Thread.Sleep(1000);
                    }
                }
                //==================나 가 기======================
                else if(input == 3)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(0);//종료
                }
            }
        }
    }
}
