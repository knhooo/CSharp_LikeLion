using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace _2502254
{
    class Program
    {
        static void Main(string[] args)
        {
            //콘솔 좌표
            //콘솔 창 크기 80*25
            Console.SetWindowSize(80, 25);//x: 80, y: 25

            //콘솔 버퍼 크기도 설정(스크롤 없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false;//커서 숨기기

            Console.Clear();//화면 지우기

            //Console.Title = "멋사콘솔게임 만들기";
            //Console.BackgroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            for (int i = 1; i < 21; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("┃                                                                              ┃");
            }

            Console.SetCursorPosition(0, 21);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.SetCursorPosition(30, 10);
            Console.Write("콘솔 윷놀이 게임..^^");
            Thread.Sleep(3000);

            Console.Clear();
            //===============================================================================================


            int score = 0;

            Random rand = new Random();
            int player_X = 30;
            int player_Y = 13;
            int move = 0;


            while (true)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.SetCursorPosition(20 + x, 3);
                    Console.Write("◎");
                    Console.SetCursorPosition(20 + x, 13);
                    Console.Write("◎");
                }
                for (int y = 0; y < 10; y+=2)
                {
                    Console.SetCursorPosition(20, 3 + y);
                    Console.Write("◎");
                    Console.SetCursorPosition(30, 3 + y);
                    Console.Write("◎");
                }
                for (int y = 1; y < 10; y += 2)
                {
                    Console.SetCursorPosition(20, 3 + y);
                    Console.Write(" ");
                    Console.SetCursorPosition(30, 3 + y);
                    Console.Write(" ");
                }

                Console.SetCursorPosition(player_X, player_Y);
                Console.Write("♡");

                Console.SetCursorPosition(20, 1);

                Console.Write("엔터를 눌러 윷 던지기");
                Console.ReadLine();
                int rnd = rand.Next(0, 5);
                switch (rnd)
                {
                    case 0:
                        Console.SetCursorPosition(20, 2);
                        Console.Write("도!!");
                        move = 2;
                        break;
                    case 1:
                        Console.SetCursorPosition(20, 2);
                        Console.Write("개!!");
                        move = 4;
                        break;
                    case 2:
                        Console.SetCursorPosition(20, 2);
                        Console.Write("걸!!");
                        move = 6;
                        break;
                    case 3:
                        Console.SetCursorPosition(20, 2);
                        Console.Write("윷!!");
                        move = 8;
                        break;
                    case 4:
                        Console.SetCursorPosition(20, 2);
                        Console.Write("모!!");
                        move = 10;
                        break;

                }
                if (player_X == 30 && player_Y>=3 && player_Y <= 13)//첫번째라인
                {
                    if(player_Y - move < 3)
                    {
                        int tmp = player_Y;
                        player_Y = 3;
                        player_X -= move - (tmp - 3);
                    }
                    else
                    {
                        player_Y -= move;
                    }
                    move = 0;
                }
                
                else if(player_Y == 3 )//두번째라인
                {
                    if(player_X - move < 20)
                    {
                        int tmp = player_X;
                        player_X =20;
                        player_Y += move - (tmp-20);
                    }
                    else
                    {
                        player_X -= move;
                    }
                    move = 0;
                }
                else if (player_X == 20 && player_Y >= 3 && player_Y <=13)//세번째라인
                {
                    if (player_Y + move > 13)
                    {
                        int tmp = player_Y;
                        player_Y =13;
                        player_X += tmp + move - 13;
                    }
                    else
                    {
                        player_Y += move;
                    }
                    move = 0;
                }
                else//네번째라인
                {
                    if (player_X + move > 30 )
                    {
                        int tmp = player_X;
                        player_X =30;
                        player_Y += tmp + move - 30;
                    }
                    else
                    {
                        player_X += move;
                    }
                    move = 0;
                }

                Thread.Sleep(2000);
                Console.Clear();
                
            }

        }
    }
}
