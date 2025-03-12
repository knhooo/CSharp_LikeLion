using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickOut
{
    class GameManager
    {
        Ball ball = null;
        Bar bar = null;
        Block block = null;
        public void Initialize()
        {
            if(ball == null)
            {
                ball = new Ball();
                ball.Initialize();
            }
            if(bar == null)
            {
                bar = new Bar();
                bar.Initialize();
            }
            if (block == null)
            {
                block = new Block();
                block.Initialize();
            }
            ball.SetBar(bar);
            ball.SetBlock(ref block);


        }

        public void Progress()
        {
            ball.Progress();
            bar.Progress(ref ball);
            block.Progress();
        }

        public void Render()
        {
            Console.Clear();
            ball.Render();
            bar.Render();
            block.Render();
        }
        public void Relase()
        {
            ball.Release();
            bar.Release();
            block.Release();
        }
    }
}
