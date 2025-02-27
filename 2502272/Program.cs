using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameSpace
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요. MyNameSpace의 MyClass입니다.");
        }
    }
}
namespace _2502272
{

    class Program
    {

        //params 키워드(가변 매개변수)
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }
        //재귀함수(자기 자신을 호출)
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;// 탈출
            return n * Factorial(n - 1);
        }

        static void SayHello()
        {
            Console.WriteLine("Program 클래스");
        }

        //일반적인 함수
        static int Add(int a, int b)
        {
            return a + b;
        }

        //화살표 함수
        static int AddArrow(int a, int b) => a + b;

        //일반적인 함수
        static void PrintMessage()
        {
            Console.WriteLine("안녕하세요");
        }

        //화살표 함수
        static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");

        //열거형이란?
        //Enumeration enum
        //숫자 값에 이름을 부여하는 자료형
        //가독성을 높이고, 의미 있는 값으로 표현 가능
        //기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가
        
        //기본적인 enum 사용법
        enum DayOfWeek
        {
            Sunday,//0
            Monday,//1
            Tuesday,//2
            Wednesday,//3
            Thursday,//4
            Friday,
            Saturday
        }

        //2. enum 값 변경(0부터 시작하지 않는 방법)
        enum StatusCode
        {
            Success = 200, BadRequest = 400, Unauthorized = 401, NotFound = 404
        }

        enum WeaponType
        {
            Sword, Bow, Staff
        }

        static void ChooseWeapon(WeaponType type){
            string str;
            switch (type)
            {
                case WeaponType.Sword:
                    str = "검";
                    break;
                case WeaponType.Bow:
                    str = "활";
                    break;
                case WeaponType.Staff:
                    str = "지팡이";
                    break;
                default:
                    str = "-";
                    break;
            }
            Console.WriteLine(str + "을 선택했습니다.");
            }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3));//출력 6
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9));

            Console.WriteLine(Factorial(5));

            SayHello();//이 클래스의 함수 호출
            MyNameSpace.MyClass.SayHello();// MyNameSpace.MyClass의 함수 호출

            //C# 화살표 함수
            //람다 표현식이라고도 하며 간결한 방식으로 함수를 정의할 수 있다.
            //중괄호 {}와 return 생략
            Console.WriteLine(Add(3, 5));//8
            Console.WriteLine(AddArrow(3, 5));//8

            PrintMessage();//안녕하세요
            PrintMessageArrow();//안녕하세요!


            //Math 클래스 사용
            Console.WriteLine($"Pi: {Math.PI}");//Pi: 3.14159265358979
            Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");//Square root of 25: 5
            Console.WriteLine($"Power(2^3): {Math.Pow(2,3)}");//Power(2^3): 8
            Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");//Round(3.75): 4

            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine(today);//Wednesday
            Console.WriteLine((int)today);//3

            StatusCode status = StatusCode.NotFound;
            Console.WriteLine(status);//NotFound
            Console.WriteLine((int)status);//404

            ChooseWeapon(WeaponType.Bow);
                }

        //문제
        


    }
}
