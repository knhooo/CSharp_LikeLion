using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
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
                Console.SetCursorPosition(0, 19);
                Console.Write("스킵 : K");

                Console.SetCursorPosition(0, 20);
                Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.SetCursorPosition(0, 21);
                Console.Write("┃                                                                                                                        ┃");
                Console.SetCursorPosition(0, 22);
                Console.Write("┃                                                                                                                        ┃");
                Console.SetCursorPosition(4, 22);
                Console.Write(Dialog[i]);
                Console.SetCursorPosition(0, 23);
                Console.Write("┃                                                                                                                        ┃");

                Console.SetCursorPosition(0, 24);
                Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

                if (Console.ReadLine() == "k" || Console.ReadLine() == "K")//k누르면 대사 스킵
                {
                    break;
                }
                else//엔터 누르면 다음 대사로
                {
                    i++;
                }

            }


        }
        public void StatUI()
        {

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
            ConsoleKeyInfo keyInfo;

            Console.SetCursorPosition(70, 1);
            Console.WriteLine($"소지금 {lion.money}");
            Console.SetCursorPosition(70, 3);
            Console.WriteLine($"행동력 {lion.energy}");
            Console.SetCursorPosition(70, 5);
            Console.WriteLine($"1. 교육");
            Console.SetCursorPosition(70, 7);
            Console.WriteLine($"2. 알바");
            Console.SetCursorPosition(70, 9);
            Console.WriteLine($"3. 여가");
            Console.SetCursorPosition(70, 11);
            Console.WriteLine($"4. 상점");
            Console.SetCursorPosition(70, 13);
            Console.WriteLine($"5. 종료");

            //KeyInput();
        }

        public void ConsoleUI()
        {
            PrintLine( "오늘은 뭘 할까?", "1~5중에 골라주세요");
        }

        public int KeyInput()
        {
            //int pressKey;//정수형 초기 선언 
            //return int.Parse(Console.ReadLine());    
            return _getch(); //아스키값 왼쪽 오른쪽

                //if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                //{
                //    pressKey = _getch(); // 실제 키 값 읽기
                //}
                //Console.Clear();

        }

        public void SetMoney(int _money)
        {
            lion.money += _money;
        }

        public void SetStat(int _stat, int _num)
        {
            switch (_stat)
            {
                case 1: lion.health += _num; break;
                case 2: lion.intel += _num; break;
                case 3: lion.attract += _num; break;
                case 4: lion.art += _num; break;
                case 5: lion.social += _num; break;
            }
        }
        public void SetHappy(int _num)
        {
            lion.happy += _num;
        }
        public void Study()
        {
            //Console.Clear();
            StatUI();
            ActUI();
            PrintLine(lion.name + "에게 어떤 교육을 할까요? (소지금 -10)", "1.태권도학원 2. 독서실 3.모델 학원 4.미술 학원 5.발표 학원");

            int pressKey;//정수형 초기 선언 
            while (true)
            {
                if (Console.KeyAvailable)//키가 눌렸을 때 true
                {
                    pressKey = KeyInput(); //아스키값

                    Console.Clear();
                    StatUI();
                    ActUI();
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
                        default:
                            continue;
                    }
                    lion.energy--;
                    if(lion.energy == 0)
                    {
                        lion.year++;
                        lion.energy = 3;
                    }

                    if (Console.ReadLine() == "") break;
                }
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

            Console.SetCursorPosition(6, 23);
            Console.WriteLine(str2);

            Console.SetCursorPosition(2, 24);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
            
        }
    }

    class Program
    {




        static void Main(string[] args)
        {
            int pressKey =0;
            Lion lion = new Lion();

            Console.SetWindowSize(80, 25);//콘솔 창 크기 설정
            Console.SetBufferSize(80, 25);//버퍼 크기도 동일하게 설정(스크롤 방지)

            Console.CursorVisible = false;

            Print printer = new Print();

            //keyInfo = Console.ReadKey(true);//키 입력 받기(화면 출력x)


            printer.TitleMenu();
            Console.Write("\nPress Enter");
            Console.ReadLine();
            printer.DialogPrint();
            Console.Clear();

            printer.StatUI();
            printer.ActUI();
            printer.ConsoleUI();

            while (true)
            {

                if (Console.KeyAvailable)//키가 눌렸을 때 true
                {
                    
                    pressKey = printer.KeyInput();
                    Console.Clear();

                    switch (pressKey)
                    {
                        case 49://1. 교육
                            printer.Study();
                            break;
                        case 50://2. 아르바이트
                            break;
                        case 51://3. 여가
                            break;
                        case 52://4. 상점
                            break;
                        case 53://5. 게임종료
                            break;
                        default:
                            break;

                    }
                    Console.Clear();
                    printer.StatUI();
                    printer.ActUI();
                    printer.ConsoleUI();
                }

                
                
                if (lion.year > 10)
                {
                    break;
                }
            }
        }

    }


}

