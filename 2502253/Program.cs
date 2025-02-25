using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _2502253
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rand = new Random();

            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;

            Console.WriteLine(" ⚔️모험가 키우기⚔️ ");
            Thread.Sleep(1000);

            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine($" 현재 상태: 체력 {health} | 골드 {gold} | 공격력 {power}");
                Console.WriteLine("\n1. 탐험하기🏕️");
                Console.WriteLine("2. 장비 뽑기🎲(1000골드)");
                Console.WriteLine("3. 휴식하기💤(체력 +20)");
                Console.WriteLine("4. 게임 종료");
                Console.Write("입력: ");

                input = int.Parse(Console.ReadLine());
                if (input == 1)//탐험하기
                {
                    Console.Clear();
                    string str = "탐험을 떠납니다";
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine(str);
                        Thread.Sleep(500);
                        Console.Clear();
                        str += ".";
                    }

                    int eventChance = rand.Next(1, 101); //1~100 랜덤 이벤트 발생

                    if (eventChance <= 30)//30%확률로 전투 발생
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($"!!몬스터가 나타났다 ⚔️");
                        Console.WriteLine($"체력 -{damage}");
                        health -= damage;//체력 감소
                    }
                    else if (eventChance <= 70)//40% : 보상 획득
                    {
                        int reward = rand.Next(100, 301);//100~300골드
                        Console.WriteLine($"!!보물을 발견했다! 💰");
                        Console.WriteLine($"+{reward} 골드");
                        gold += reward;
                    }
                    else //30% : 체력 회복
                    {
                        int heal = rand.Next(10, 31);//10~30 체력 회복
                        Console.WriteLine($"🍑 회복 열매를 발견했다!");
                        Console.WriteLine($"+{heal} 체력");
                        health += heal;
                    }

                    if (health <= 0)
                    {
                        Console.WriteLine("\n💀 You Died...");
                        isAlive = false;
                    }
                    Thread.Sleep(3000);
                }
                else if (input == 2)//장비 뽑기
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine("🎲 장비를 뽑습니다...");
                        Thread.Sleep(1000);

                        int rnd = rand.Next(1, 101);//1~100랜덤

                        if (rnd == 1)
                        {
                            Console.WriteLine("SSS급 전설의 검(공격력 +50) 획득!");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("SS급 희귀한 검(공격력 +30) 획득!");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S급 강철 검(공격력 +20) 획득!");
                            power += 20;
                        }
                        else
                        {
                            Console.WriteLine("녹슨 칼 (공격력+5) 획득!");
                            power += 5;
                        }
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다. (1000 골드 필요)");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)//휴식하기
                {
                    Console.WriteLine("휴식을 취합니다... (+20 체력)");
                    health += 20;
                    Thread.Sleep(1000);
                }
                else if(input == 4)//종료하기
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("다시 선택하세요.");
                    Thread.Sleep(1000);
                }
            }

                
        }
    }

}
