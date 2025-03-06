using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250306Task
{
    class Program
    {
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame();
            mainGame.Init();//초기화
            mainGame.Progress();//게임 실행
        }
    }
}
