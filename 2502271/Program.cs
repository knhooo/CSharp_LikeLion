using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2502271
{
    class Program
    {
        //전역변수
        static int num2 = 20;
        //1.기본 함수
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");
        }
        //2. 매개변수가 있는 함수
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        //3. 반환값만 있는 함수
        static int GetNumber()
        {
            num2 = 30;
            return 42;
        }
        //4. 매개변수와 반환값이 있는 함수
        static int Add(int a, int b)
        {
            return a + b;
        }
        //5. 디폴트 매개변수
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}님");
        }

        //6. 함수 오버로딩
        /// <summary>
        /// 두 수를 곱하는 함수
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        //7. out 키워드(여러 값을 반환할 때)
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        //8. ref 키워드(값을 참조하여 수정)
        static void Increase(ref int num)
        {
            num += 10;
        }

        static void Main(string[] args)
        {
            PrintHello();//안녕하세요
            PrintMessage("반갑습니다.");//반갑습니다.
            int num = GetNumber();
            Console.WriteLine(num);//42
            Console.WriteLine(num2);//30

            Console.WriteLine(Add(3, 5));//8

            Greet();//손님
            Greet("이름");//이름

            Console.WriteLine(Multiply(3, 4));//12
            Console.WriteLine(Multiply(2.5, 3.5));//8.75

            int q, r;
            Divide(10, 3, out q, out r);

            Console.WriteLine($"몫: {q}, 나머지: {r}");//몫: 3, 나머지: 1

            int value = 5;
            Increase(ref value);//15

            Console.WriteLine(value);
        }
    }
}
