using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Field field = new Field();

            Console.SetWindowSize(50, 40);
            Console.SetBufferSize(50, 40);

            player.SelectJob(player);

            field.Setting(ref player);
            field.Menu(player);

        }
    }
}
