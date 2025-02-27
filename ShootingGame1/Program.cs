using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace ShootingGame1
{
    class Program
    {
        struct Player
        {
            public int X;
            public int Y;
        }
        static void KeyInput(ConsoleKeyInfo input, ref Player pos)
        {
            switch (input.Key)
            {
                case ConsoleKey.UpArrow: if (pos.X > 0) pos.Y--; break;//위 이동
                case ConsoleKey.DownArrow: if (pos.Y < Console.WindowHeight - 1) pos.Y++; break;//아래 이동
                case ConsoleKey.LeftArrow: if (pos.X > 0) pos.X--; break;//왼쪽 이동
                case ConsoleKey.RightArrow: if (pos.X < Console.WindowWidth - 1) pos.X++; break;//오른쪽 이동
                case ConsoleKey.Spacebar: Console.Write("미사일"); break;//오른쪽 이동
                case ConsoleKey.Escape: return;//ESC키로 종료
            }
        }
        static void PrintPlayer(string[] player, Player pos)
        {
            for (int i = 0; i < player.Length; i++)
            {
                //콘솔 좌표 설정
                Console.SetCursorPosition(pos.X, pos.Y + i);
                //문자열 배열 출력
                Console.WriteLine(player[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);//콘솔 창 크기 설정
            Console.SetBufferSize(80, 25);//버퍼 크기도 동일하게 설정(스크롤 방지)
            
            string[] playerArr = new string[]
            {
                "*。*.。*∧,,,∧",
                "-(⌒(_ = 6 ω6 )_",
                "->"
            };//배열 문자열로 그리기

            Player pos;
            pos.X = 0;
            pos.Y = 12;

            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = false;

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds;// 1 / 1000 1000== 1초


            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds;//현재 시간 가져오기

                if(currentSecond - prevSecond >= 100)
                {

                    keyInfo = Console.ReadKey(true);//키 입력 받기(화면 출력x)
                    Console.Clear();

                    KeyInput(keyInfo, ref pos);
                    //switch (keyInfo.Key)
                    //{
                    //    case ConsoleKey.UpArrow: if (pos.X > 0) pos.Y--; break;//위 이동
                    //    case ConsoleKey.DownArrow: if (pos.Y < Console.WindowHeight - 1) pos.Y++; break;//아래 이동
                    //    case ConsoleKey.LeftArrow: if (pos.X > 0) pos.X--; break;//왼쪽 이동
                    //    case ConsoleKey.RightArrow: if (pos.X < Console.WindowWidth - 1) pos.X++; break;//오른쪽 이동
                    //    case ConsoleKey.Spacebar: Console.Write("미사일"); break;//오른쪽 이동
                    //    case ConsoleKey.Escape: return;//ESC키로 종료
                    //}

                    PrintPlayer(playerArr,pos);

                    prevSecond = currentSecond;//이전 시간 업데이트

                }
            }
            
        }
    }
}
