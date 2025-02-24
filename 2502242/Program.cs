using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2502242
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 85;
            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else
            {
                Console.WriteLine("B 학점");
            }

            string GameID = "멋사검존";
            if (GameID == "멋사검존")
            {
                Console.WriteLine("아이디가 일치합니다.");
            }
            else
            {
                Console.WriteLine("아이디가 일치하지 않습니다.");
            }

            int score = 75;

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }

            //오늘의 과제
            int money;
            int att = 100;
            string name;
            Console.Write("이름을 입력하세요: ");
            name = Console.ReadLine();

            Console.Write("소지금을 입력하세요: ");
            money = int.Parse(Console.ReadLine());

            if (money > 600)
            {
                Console.WriteLine("전설의 검 획득!");
                att += 7;
            }
            else if (money > 500)
            {
                Console.WriteLine("유령검 획득!");
                att += 6;
            }
            else if (money > 400)
            {
                Console.WriteLine("엑스칼리버 획득!");
                att += 5;
            }
            else if (money > 300)
            {
                Console.WriteLine("집판검 획득!");
                att += 4;
            }
            else if (money > 200)
            {
                Console.WriteLine("진은검 획득!");
                att += 3;
            }
            else if (money > 100)
            {
                Console.WriteLine("카타나 획득!");
                att += 2;
            }
            else
            {
                Console.WriteLine("무한의 대검 획득!");
                att += 1;
            }
            Console.WriteLine("================");
            Console.WriteLine("이름: " + name);
            Console.WriteLine("공격력: " + att);


            //문제1. 세 정수의 최댓값 구하기
            Console.WriteLine("문제1. 세 정수의 최댓값 구하기");
            int num1, num2, num3;
            int max_num;
            Console.Write("첫번째 정수를 입력하세요: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수를 입력하세요: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("세번째 정수를 입력하세요: ");
            num3 = int.Parse(Console.ReadLine());

            max_num = num1;
            if(num2 > num3)
            {
                if(max_num < num2)
                {
                    max_num = num2;
                }
            }
            else
            {
                if (max_num < num3)
                {
                    max_num = num3;
                }
            }

            Console.WriteLine("최댓값: " + max_num);

            //문제 2. 점수에 따른 학점 평가
            Console.WriteLine("\n문제 2. 점수에 따른 학점 평가");
            Console.Write("점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine()); 

            if (score >= 90)
            {
                Console.WriteLine("A 학점");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B 학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C 학점");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D 학점");
            }
            else
            {
                Console.WriteLine("F 학점");
            }

            //문제 3. 간단한 사칙연산 계산기
            Console.WriteLine("\n문제 3. 간단한 사칙연산 계산기");
            int a, b, result = 0;
            string opr;
            Console.Write("첫번째 정수를 입력하세요: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("연산자를 입력하세요: ");
            opr = Console.ReadLine();
            Console.Write("두번째 정수를 입력하세요: ");
            b = int.Parse(Console.ReadLine());

            if(opr == "+")
            {
                result = a + b;
            }
            else if(opr == "-")
            {
                result = a - b;
            }
            else if (opr == "*")
            {
                result = a * b;
            }
            else if (opr == "/")
            {
                if(b == 0)
                {
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                }
                result = a / b;
            }

            Console.WriteLine("결과: " + result);

        }
    }
}
