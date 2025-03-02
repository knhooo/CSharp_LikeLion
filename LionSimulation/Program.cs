using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace LionSimulation
{
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
            money = 100;

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


        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져오기
        Lion lion = new Lion();
        Random rand = new Random();
        int pressKey = 0;

        public void GameStart()
        {
            TitleMenu();
            Console.Write("\nPress Enter");
            Console.ReadLine();
            DialogPrint();
            Console.Clear();

            StatUI();
            ActUI();
            ConsoleUI();
            PrintLion(1);

            while (true)
            {
                if (Console.KeyAvailable)//키가 눌렸을 때 true
                {
                    PrintLion(1);
                    pressKey = KeyInput();
                    Console.Clear();

                    switch (pressKey)
                    {
                        case 49://1. 교육
                            Study();
                            break;
                        case 50://2. 아르바이트
                            Work();
                            break;
                        case 51://3. 여가
                            Rest();
                            break;
                        case 52://4. 상점
                            Shop();
                            break;
                        case 53://5. 게임종료
                            break;
                        default:
                            break;

                    }
                    Console.Clear();
                    StatUI();
                    ActUI();
                    ConsoleUI();
                    PrintLion(1);
                }
            }
        }
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
            Console.Clear();
            for (int i = 0; i < Dialog.Length;)
            {
                
                Console.SetCursorPosition(0, 19);
                Console.Write("스킵 : K");

                PrintLion(0);

                Console.SetCursorPosition(0, 20);
                Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.SetCursorPosition(0, 21);
                Console.Write("┃                                                                            ┃");
                Console.SetCursorPosition(0, 22);
                Console.Write("┃                                                                            ┃");
                Console.SetCursorPosition(4, 22);
                Console.Write(Dialog[i]);
                Console.SetCursorPosition(0, 23);
                Console.Write("┃                                                                            ┃");

                Console.SetCursorPosition(0, 24);
                Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                if (Console.KeyAvailable)//키가 눌렸을 때 true
                {
                    Console.Clear();
                    pressKey = KeyInput(); //아스키값

                    switch (pressKey)
                    {
                        case 107:
                            i = Dialog.Length;
                            break;
                        default:
                            i++;
                            break;
                    }
                }
            }

        }
        public void StatUI()
        {

            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"{lion.name}");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine($"  {lion.year}년째");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine($"체력 {lion.health}");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine($"지능 {lion.intel}");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine($"매력 {lion.attract}");
            Console.SetCursorPosition(0, 13);
            Console.WriteLine($"예술 {lion.art}");
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"행복 {lion.happy}");
            Console.SetCursorPosition(0, 17);
            Console.WriteLine($"사회 {lion.social}");
        }

        public void ActUI()
        {
            ConsoleKeyInfo keyInfo;

            Console.SetCursorPosition(67, 3);
            Console.WriteLine($"소지금 {lion.money}");
            Console.SetCursorPosition(67, 5);
            if (lion.energy == 3) Console.WriteLine($"행동력 ♡♡♡");
            else if (lion.energy == 2) Console.WriteLine($"행동력 ♡♡");
            else if (lion.energy == 1) Console.WriteLine($"행동력 ♡");

            Console.SetCursorPosition(67, 7);
            Console.WriteLine($"1. 교육");
            Console.SetCursorPosition(67, 9);
            Console.WriteLine($"2. 알바");
            Console.SetCursorPosition(67, 11);
            Console.WriteLine($"3. 여가");
            Console.SetCursorPosition(67, 13);
            Console.WriteLine($"4. 상점");
            Console.SetCursorPosition(67, 15);
            Console.WriteLine($"5. 종료");
        }
        public void GameOver()
        {
            Console.Clear();
            PrintLine(lion.name + "(이)는 더이상 행복하지 않습니다..", "게임 오버");
            Thread.Sleep(2000);
            GameStart();
        }
        public void Ending()
        {
            Console.Clear();

            int score = lion.attract + lion.intel + lion.art + lion.health + lion.happy + lion.social;
            if (score > 500)
            {
                PrintLion(3);
                PrintLine("축하합니다!!", lion.name + "(이)는 멋쟁이 사자가 되었습니다!!");
            }
            else if (score > 400)
            {
                PrintLion(4);
                PrintLine("약속한 시간이 되었습니다", lion.name + "(이)는 좋은 사자가 되었습니다!!");
            }
            else if (score > 300)
            {
                PrintLion(4);
                PrintLine("약속한 시간이 지났습니다.", lion.name + "(이)는 평범한 사자가 되었습니다!!");
            }

            else
            {
                PrintLion(4);
                PrintLine("약속한 시간이 지났습니다.", lion.name + "(이)는 불량한 사자가 되었습니다...");
            }
            Console.WriteLine("Enter를 눌러 다시 시작하기");
            Console.ReadLine();
            GameStart();
        }
        public void ConsoleUI()
        {
            PrintLine("오늘은 뭘 할까?", "1.교육 2.아르바이트 3.여가 4.상점 ");
        }

        public int KeyInput()
        {  
            return _getch(); //아스키값 왼쪽 오른쪽
        }

        public void SetMoney(int _money)
        {
            if (lion.money + _money < 0)
            {
                PrintLine("소지금이 부족합니다.", "");
                lion.energy++;//에너지 반환
            }
            lion.money += _money;
        }

        public void SetStat(int _stat, int _num)
        {
            switch (_stat)
            {
                case 1:
                    if (lion.health + _num < 0) lion.health = 0;
                    else if (lion.health + _num > 100) lion.health = 100;
                    else lion.health += _num; break;

                case 2:
                    if (lion.intel + _num < 0) lion.intel = 0;
                    else if (lion.intel + _num > 100) lion.intel = 100;
                    else lion.intel += _num; break;
                case 3:
                    if (lion.attract + _num < 0) lion.attract = 0;
                    else if (lion.attract + _num > 100) lion.attract = 100;
                    else lion.attract += _num; break;
                case 4:
                    if (lion.art + _num < 0) lion.art = 0;
                    else if (lion.art + _num > 100) lion.art = 100;
                    else lion.art += _num; break;
                case 5:
                    if (lion.social + _num < 0) lion.social = 0;
                    else if (lion.social + _num > 100) lion.social = 100;
                    else lion.social += _num; break;
            }
        }
        public void SetHappy(int _num)
        {
            lion.happy += _num;
            if (lion.happy < 0)
            {
                GameOver();
            }
        }
        public void Study()
        {
            StatUI();
            ActUI();
            PrintLine(lion.name + "에게 어떤 교육을 할까요? (소지금 -10) (0:뒤로가기)", "1.태권도학원 2. 독서실 3.모델 학원 4.미술 학원 5.발표 학원");
            PrintLion(1);
            int pressKey;//정수형 초기 선언 
            while (true)
            {
                if (Console.KeyAvailable)//키가 눌렸을 때 true
                {
                    pressKey = KeyInput(); //아스키값

                    Console.Clear();
                    StatUI();
                    ActUI();
                    PrintLion(2);
                    switch (pressKey)
                    {
                        case 49://1. 태권도학원
                            SetMoney(-10); SetStat(1, 10);
                            PrintLine(lion.name + "(이)가 열심히 태권도를 합니다.", "체력 10 증가!");
                            break;
                        case 50://2. 독서실
                            SetMoney(-10); SetStat(2, 10);
                            PrintLine(lion.name + "(이)가 열심히 공부를 합니다.", "지능 10 증가!");
                            break;
                        case 51://3. 모델 학원
                            SetMoney(-10); SetStat(3, 10);
                            PrintLine(lion.name + "(이)가 열심히 모델 수업을 듣습니다.", "매력 10 증가!");
                            break;
                        case 52://4. 미술 학원
                            SetMoney(-10); SetStat(4, 10);
                            PrintLine(lion.name + "(이)가 열심히 그림을 합니다.", "예술 10 증가!");
                            break;
                        case 53://5. 발표 학원
                            SetMoney(-10); SetStat(5, 10);
                            PrintLine(lion.name + "(이)가 열심히 발표를 합니다.", "사회 10 증가!");
                            break;
                        case 48://0. 뒤로가기
                            break;
                        default:
                            continue;
                    }
                    lion.energy--;
                    if (lion.energy == 0)
                    {
                        lion.year++;
                        if (lion.year > 3)
                        {
                            Thread.Sleep(1000);
                            Ending();
                        }
                        lion.energy = 3;
                    }

                    Thread.Sleep(3000);
                    break;
                }
            }


        }

        public void Work()
        {
            StatUI();
            ActUI();
            PrintLine(lion.name + "(이)가 어디서 일을 할까요?(소지금 증가)(0:뒤로가기)", "1.편의점 2. 음식점 3.물류 센터 4.모델 5.과외 ");
            PrintLion(1);
            int rnd;
            int pressKey;//정수형 초기 선언 
            while (true)
            {
                if (Console.KeyAvailable)//키가 눌렸을 때 true
                {
                    pressKey = KeyInput(); //아스키값

                    Console.Clear();
                    StatUI();
                    ActUI();
                    PrintLion(2);
                    switch (pressKey)
                    {
                        case 49://1. 편의점
                            rnd = rand.Next(5, 16);
                            SetMoney(rnd); SetStat(5, 10); SetHappy(-10);
                            PrintLine(lion.name + "(이)가 열심히 일하고 돌아왔습니다.", "소지금" + rnd + " 증가!");
                            break;
                        case 50://2. 음식점
                            rnd = rand.Next(16, 26);
                            SetMoney(rnd); SetStat(4, 10); SetHappy(-20);
                            PrintLine(lion.name + "(이)가 열심히 일하고 돌아왔습니다.", "소지금" + rnd + " 증가!");
                            break;
                        case 51://3. 물류 센터
                            rnd = rand.Next(26, 36);
                            SetMoney(rnd); SetStat(1, 10); SetHappy(-10);
                            PrintLine(lion.name + "(이)가 열심히 일하고 돌아왔습니다.", "소지금" + rnd + " 증가!");
                            break;
                        case 52://4. 모델
                            rnd = rand.Next(5, 16);
                            SetMoney(rnd); SetStat(3, 10); SetHappy(-10);
                            PrintLine(lion.name + "(이)가 열심히 일하고 돌아왔습니다.", "소지금" + rnd + " 증가!");
                            break;
                        case 53://5. 과외
                            rnd = rand.Next(16, 26);
                            SetMoney(rnd); SetStat(2, 10); SetHappy(-10);
                            PrintLine(lion.name + "(이)가 열심히 일하고 돌아왔습니다.", "소지금" + rnd + " 증가!");
                            break;
                        case 48://0. 뒤로가기
                            break;
                        default:
                            continue;
                    }
                    lion.energy--;
                    if (lion.energy == 0)
                    {
                        lion.year++;
                        lion.energy = 3;
                    }

                    Thread.Sleep(3000);
                    break;
                }
            }
        }

        public void Rest()
        {
            StatUI();
            ActUI();
            PrintLion(1);
            PrintLine(lion.name + "(이)가 무엇을 할까요? (소지금 감소)(0:뒤로가기)", "1.게임 (-10) 2. 스포츠 (-0) 3.영화 (-10) 4.모임 (-20) 5.여행 (-30)");
            int rnd;
            int pressKey;//정수형 초기 선언 
            while (true)
            {
                if (Console.KeyAvailable)//키가 눌렸을 때 true
                {
                    pressKey = KeyInput(); //아스키값

                    Console.Clear();
                    StatUI();
                    ActUI();
                    PrintLion(2);
                    switch (pressKey)
                    {
                        case 49://1. 게임
                            rnd = rand.Next(5, 16);
                            SetMoney(-10); SetStat(5, 10); SetHappy(rnd);
                            PrintLine(lion.name + "(이)가 피시방에서 게임을 즐기고 왔습니다.", "행복" + rnd + " 증가!");
                            break;
                        case 50://2. 스포츠
                            rnd = rand.Next(5, 16);
                            SetMoney(0); SetStat(4, 10); SetHappy(rnd);
                            PrintLine(lion.name + "(이)가 운동을 하고왔습니다.", "행복" + rnd + " 증가!");
                            break;
                        case 51://3. 영화
                            rnd = rand.Next(15, 26);
                            SetMoney(-10); SetStat(1, 10); SetHappy(rnd);
                            PrintLine(lion.name + "(이)가 영화를 보고왔습니다.", "행복" + rnd + " 증가!");
                            break;
                        case 52://4. 모임
                            rnd = rand.Next(5, 16);
                            SetMoney(-20); SetStat(3, 10); SetHappy(rnd);
                            PrintLine(lion.name + "(이)가 친구들과의 맛집에 다녀왔습니다.", "행복" + rnd + " 증가!");
                            break;
                        case 53://5. 여행
                            rnd = rand.Next(25, 36);
                            SetMoney(-30); SetStat(2, 10); SetHappy(rnd);
                            PrintLine(lion.name + "(이)가 여행을 다녀왔습니다.", "행복" + rnd + " 증가!");
                            break;
                        case 48://0. 뒤로가기
                            break;
                        default:
                            continue;
                    }
                    lion.energy--;
                    if (lion.energy == 0)
                    {
                        lion.year++;
                        lion.energy = 3;
                    }

                    Thread.Sleep(2000);
                    break;
                }
            }
        }

        public void Shop()
        {
            StatUI();
            ActUI();
            PrintLion(1);
            PrintLine("상점에서 무엇을 살까? (가격: 50)(0:뒤로가기) 1.단백질 보충제(체력+)", " 2. 교과서(지능+)  3.옷(매력+) 4.로봇 팔(예술+) 5.디저트(행복+)");
            int rnd;
            int pressKey;//정수형 초기 선언 
            while (true)
            {
                if (Console.KeyAvailable)//키가 눌렸을 때 true
                {
                    pressKey = KeyInput(); //아스키값

                    Console.Clear();
                    StatUI();
                    ActUI();
                    PrintLion(2);
                    switch (pressKey)
                    {
                        case 49://1. 단백질
                            SetMoney(-50); SetStat(1, 50);
                            PrintLine(lion.name + "(이)가 단백질 보충을 합니다.", "체력 50 증가!");
                            break;
                        case 50://2. 교과서
                            SetMoney(-50); SetStat(2, 50);
                            PrintLine(lion.name + "(이)가 새 교과서로 공부합니다.", "지능 50 증가!");
                            break;
                        case 51://3. 옷
                            SetMoney(-50); SetStat(3, 50);
                            PrintLine(lion.name + "(이)가 새 옷으로 갈아입습니다.", "매력 50 증가!");
                            break;
                        case 52://4. 로봇 팔
                            SetMoney(-50); SetStat(4, 50);
                            PrintLine(lion.name + "(이)가 정교한 로봇 팔을 장착합니다.", "예술 50 증가!");
                            break;
                        case 53://5. 디저트
                            SetMoney(-50); SetHappy(50);
                            PrintLine(lion.name + "(이)가 맛있는 디저트를 먹습니다.", "행복 50 증가!");
                            break;
                        case 48://0. 뒤로가기
                            break;
                        default:
                            continue;
                    }
                    lion.energy--;
                    if (lion.energy == 0)
                    {
                        lion.year++;
                        lion.energy = 3;
                    }

                    Thread.Sleep(2000);
                    break;
                }
            }
        }

        public void PrintLion(int n)//사자 아스키아트
        {
            if (n == 1)
            {
                Console.SetCursorPosition(20, 7);
                Console.Write("(\"`-''-/\").___..--''\"`-._ ");
                Console.SetCursorPosition(20, 8);
                Console.Write(" `6_ 6  )   `-.  (     ).`-.__.`) ");
                Console.SetCursorPosition(20, 9);
                Console.Write(" (_Y_.)'  ._   )  `._ `. ``-..-'");
                Console.SetCursorPosition(20, 10);
                Console.Write("   _..`--'_..-_/  /--'_.'");
                Console.SetCursorPosition(20, 11);
                Console.Write("  ((((.-''  ((((.'  (((.");
            }
            else if (n == 2)
            {
                Console.SetCursorPosition(10, 7);
                Console.Write("                __..--''``---....___   _..._ __");
                Console.SetCursorPosition(10, 8);
                Console.Write(" /// //_.-'    .-/\";  `        ``<._  ``.''_ `. / // /");
                Console.SetCursorPosition(10, 9);
                Console.Write("///_.-' _..--.'_    \\                    `( ) ) // //");
                Console.SetCursorPosition(10, 10);
                Console.Write("/ (_..-' // (< _     ;_..__               ; `' / ///");
                Console.SetCursorPosition(10, 11);
                Console.Write(" / // // //  `-._,_)' // / ``--...____..-' /// / //");
            }
            else if (n == 3)
            {
                Console.SetCursorPosition(15, 7);
                Console.Write("      /\";;:;;\"\\");
                Console.SetCursorPosition(15, 8);
                Console.Write("    (:;/\\,-,/\\; ;)");
                Console.SetCursorPosition(15, 9);
                Console.Write("   (:;");
                Console.SetCursorPosition(15, 10);
                Console.Write("   (:;{  d b  }:;)");
                Console.SetCursorPosition(15, 11);
                Console.Write("    (:;\\__Y__ /; ;)-----------,,_");
                Console.SetCursorPosition(15, 12);
                Console.Write("     ,..\\  ,..\\      ___ / ___)__`\\");
                Console.SetCursorPosition(15, 13);
                Console.Write("      (,,,)~(,,,)`-._##____________)");
            }
            else if (n == 4) 
            {
                Console.SetCursorPosition(15, 7);
                Console.Write("       sSSSs");
                Console.SetCursorPosition(15, 8);
                Console.Write("      s(oo)s");
                Console.SetCursorPosition(15, 9);
                Console.Write("      s(Y)Ss'._");
                Console.SetCursorPosition(15, 10);
                Console.Write("        |\\,    \"._");
                Console.SetCursorPosition(15, 11);
                Console.Write("       / /| / ___  \\");
                Console.SetCursorPosition(15, 12);
                Console.Write("        cc-'cc'cc -,-__)");
            }
            else if(n == 0)
            {
                Console.SetCursorPosition(15, 7);
                Console.Write("    .       .");
                Console.SetCursorPosition(15, 8);
                Console.Write("    \\`-\"'\" - '/");
                Console.SetCursorPosition(15, 9);
                Console.Write("     } 6 6 {  ");
                Console.SetCursorPosition(15, 10);
                Console.Write("    =.  Y  ,=");
                Console.SetCursorPosition(15, 11);
                Console.Write("      /^^^\\  .");
                Console.SetCursorPosition(15, 12);
                Console.Write("     /     \\  )  )");
                Console.SetCursorPosition(15, 13);
                Console.Write("      ()-(  )/ ");
                Console.SetCursorPosition(15, 14);
                Console.Write("     \"\"   \"\"");
            }
        }
        public void PrintLine(string str1, string str2)
        {
            Console.SetCursorPosition(2, 20);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");

            Console.SetCursorPosition(2, 21);
            Console.Write("┃                                                                            ┃");

            Console.SetCursorPosition(6, 21);
            Console.WriteLine(str1);

            Console.SetCursorPosition(2, 22);
            Console.Write("┃                                                                            ┃");


            Console.SetCursorPosition(2, 23);
            Console.Write("┃                                                                            ┃");



            Console.SetCursorPosition(2, 24);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            Thread.Sleep(500);
            Console.SetCursorPosition(6, 22);
            Console.WriteLine(str2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Print printer = new Print();

            Lion lion = new Lion();

            Console.SetWindowSize(80, 25);//콘솔 창 크기 설정
            Console.SetBufferSize(80, 25);//버퍼 크기도 동일하게 설정(스크롤 방지)

            Console.CursorVisible = false;

            printer.GameStart();

            //keyInfo = Console.ReadKey(true);//키 입력 받기(화면 출력x)
            Console.Clear();
            printer.PrintLine("게임 오버", lion.name + "(이)가 집을 떠났습니다..");
        }

    }


}

