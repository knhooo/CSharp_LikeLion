using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LionSimulation
{
    public class GameManager
    {
        

        public GameManager()
        {
            
        }

    }
    public class Lion
    {
        public string name;//이름
        public int year;//햇수
        
        //스탯
        public int health;//체력
        public int intel;//지능
        public int attract;//매력
        public int art;//손재주
        public int happy;//행복
        public int social;//사회성

        public int money;//소지금
        public int energy;//행동력

        public Lion()
        {
            name = "아기사자";
            year = 1;
            energy = 3;

            health = 50;
            intel = 50;
            attract = 50;
            art = 50;
            happy = 50;
            social = 50;
        }
    }

    public class Print
    {
        public void TitleMenu()
        {
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("\n _                _   _              \r\n| |  () _   _    | \\_/ | _  ||  _  _ \r\n| |_ ||/o\\|/ \\   | \\_/ |/o\\ |/7/o\\/_|\r\n|___|L|\\_/L_n|   |_| |_|\\_,]L|\\\\( L| ");
        }
        public void DialogPrint()
        {
            string[] Dialog =
            {
                "어느날 아침, 문을 열어보니 문 앞에 낡은 상자가 놓여 있었다.",
                "가까이 다가가자, 상자 안에서 희미한 소리가 들려왔다.",
                "조심스럽게 뚜껑을 열자, 작은 아기 사자가 웅크리고 있었다.",
                "아기 사자가 천천히 고개를 들고 눈을 마주쳤다.",
                "그리고 믿을 수 없는 일이 벌어졌다.",
                "\"드디어 찾았다! 나를 멋진 사자로 키워줘!\"",
                "아기 사자의 둥근 눈동자가 반짝이며 간절한 빛을 머금었다.",
                "\"나는 강하고 용감한 사자가 되고 싶어!\"",
                "'저 눈빛을 거절하긴 힘들 것 같다..'.",
                "아기 사자를 멋진 사자로 키우기 위한 이야기가 시작되었다."
            };
            for (int i = 0; i < Dialog.Length;)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 20);
                Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.SetCursorPosition(0, 21);
                Console.Write("┃                                                                                                                        ┃");
                Console.SetCursorPosition(0, 22);
                Console.Write("┃                                                                                                                        ┃");
                Console.SetCursorPosition(2, 22);
                Console.Write(Dialog[i]);
                Console.SetCursorPosition(0, 23);
                Console.Write("┃                                                                                                                        ┃");

                Console.SetCursorPosition(0, 24);
                Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                Console.ReadLine();
                i++;
            }


        }
        public void StatUI()
        {
            Lion lion = new Lion();

            

            Console.SetCursorPosition(0, 1);
            Console.WriteLine($"{lion.name}");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"  {lion.year}년째");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"체력 {lion.health}");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine($"지능 {lion.intel}");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine($"매력 {lion.attract}");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine($"예술 {lion.art}");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine($"행복 {lion.happy}");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"사회 {lion.social}");
        }

        public void ActUI()
        {
            Lion lion = new Lion();

            Console.SetCursorPosition(72, 1);
            Console.WriteLine($"{lion.name}");
            Console.SetCursorPosition(72, 3);
            Console.WriteLine($"  {lion.year}년째");
            Console.SetCursorPosition(72, 5);
            Console.WriteLine($"체력 {lion.health}");
            Console.SetCursorPosition(72, 7);
            Console.WriteLine($"지능 {lion.intel}");
            Console.SetCursorPosition(72, 9);
            Console.WriteLine($"매력 {lion.attract}");
            Console.SetCursorPosition(72, 11);
            Console.WriteLine($"예술 {lion.art}");
            Console.SetCursorPosition(72, 13);
            Console.WriteLine($"행복 {lion.happy}");
            Console.SetCursorPosition(72, 15);
            Console.WriteLine($"사회 {lion.social}");
        }
    }

    class Program
    {



        //static void KeyInput(ConsoleKeyInfo input)
        //{
        //    if (input.Key != null)
        //    {

        //    }
        //}
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);//콘솔 창 크기 설정
            Console.SetBufferSize(80, 25);//버퍼 크기도 동일하게 설정(스크롤 방지)
            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = false;

            Print printer = new Print();

            //keyInfo = Console.ReadKey(true);//키 입력 받기(화면 출력x)


            printer.TitleMenu();
            Console.Write("\nPress Enter");
            Console.ReadLine();
            printer.DialogPrint();
            //while (true)
            //{
            //    if (Console.KeyAvailable)
            //    {

            //        break;
            //    }
            //}
            Console.Clear();
            printer.StatUI();
            printer.ActUI();


        }

    }

    
}

