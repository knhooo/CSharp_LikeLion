using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BrickOut
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch();//c언어 함수 가져오기
        public static void GoToXY(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            GameManager gm = new GameManager();
            gm.Initialize();
            int curr = Environment.TickCount;

            while (true)
            {
                if(curr +50 < Environment.TickCount)
                {
                    curr = Environment.TickCount;

                    gm.Progress();
                    gm.Render();
                }
            }
            gm.Relase();
        }
    }
}
