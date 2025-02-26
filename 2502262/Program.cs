using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _2502262
{
    class Program
    {
        //1단계 함수
        //반환형 함수 이름(매개변수)
        static void Print()
        {
            Console.WriteLine("로딩 화면");
        }

        //2단계 함수 : 매개변수
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력 : " + _Attack);
        }

        //3단계 함수 : 반환
        static int BaseAttack()
        {
            //기본 공격력 10
            int attack = 10;

            return attack;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Print();

            int Attack = 0;
            int bAttack = 0;
            Console.Write("캐릭터의 공격력을 입력하세요 : ");
            Attack = int.Parse(Console.ReadLine());

            //기본 공격력
            bAttack = BaseAttack();

            AttackFunction(bAttack + Attack);


            int result = Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");

            string[] fruits = { "사과", "바나나", "체리" };

            //반복문
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
