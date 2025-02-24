using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2502241
{
    class Program
    {
        static void Main(string[] args)
        {
            /////이진수
            //이진수를 10진수로 변환
            Console.Write("2진수를 입력하세요: ");
            string binaryInput = Console.ReadLine();
            int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수->10진수

            //10진수를 이진수로 변환
            string binaryOutput = Convert.ToString(decimalValue, 2);//10진수->2진수

            Console.WriteLine($"입력한 이진수: {binaryInput}");
            Console.WriteLine($"10진수로 변환: {decimalValue}");
            Console.WriteLine($"다시 이진수로 변환: {binaryOutput}");

            ///var 키워드
            //var를 사용하여 변수 선언
            var name = "Alice"; //컴파일러가 문자열로 추론
            var age = 25; //정수로 추론
            var isStudent = true; //논리값으로 추론

            Console.WriteLine($"이름:{name},나이:{age},학생 여부:{isStudent}");

            ///default 키워드
            //default 키워드를 사용한 기본값 설정
            int defaultInt = default;//기본값: 0
            string defaultString = default;//기본값: null
            bool defaultBool = default; //기본값: false

            Console.WriteLine($"정수 기본값:{defaultInt}");
            Console.WriteLine($"문자열 기본값:{defaultString}");
            Console.WriteLine($"논리값 기본값:{defaultBool}");

            ///연산자
            //산술형 연산자
            int a = 5, b = 3;

            int result = 0;

            result = a + b;//더하기
            Console.WriteLine($"합:{result}");

            result = a - b;//빼기
            Console.WriteLine($"차:{result}");

            result = a * b;//곱하기
            Console.WriteLine($"곱:{result}");

            result = a / b;//나누기
            Console.WriteLine($"나눗셈:{result}");

            int c = 5, d = 2;
            result = c % d;//나머지
            Console.WriteLine($"나머지:{result}");

            //관계형 연산자
            bool isEqual = (a == b);
            Console.WriteLine($"a와 b가 같은가?:{isEqual}");

            //단항 연산자
            int number = 5;
            bool flag = true;

            Console.WriteLine(+number);//양수 출력
            Console.WriteLine(-number);//양수 출력

            Console.WriteLine(!flag);//논리 부정:False

            //비트
            int num = 10;
            int result = ~num;//비트 반전 : 1111 0101 -> 출력 : -11
            Console.WriteLine("처음 값: " + num);
            Console.WriteLine("~연산자 적용 값: " + result);

            ///변환 연산자(캐스팅)
            double pi = 3.14;
            int integerPi = (int)pi;//실수->정수로 변환

            Console.WriteLine(integerPi);//3

            ///평균 구하기 예제
            int iKor = 90;
            int iEng = 75;
            int iMath = 58;

            int sum = 0;
            float average = 0.0f;

            sum = iKor + iEng + iMath;
            //average = sum / 3;//평균 : 74
            average = (float)sum / 3; //평균 : 74.33334
            Console.WriteLine("총점 : " + sum);//223
            Console.WriteLine("평균 : " + average);//74

            산술연산자
            int a = 10, b = 3;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            //문자열 연결 연산자
            string firstName = "Alice";
            string lastName = "Smith";

            Console.WriteLine(firstName + " " + lastName);

            ///할당 연산자
            int a = 10;
            a += 5; //a = a + 5
            Console.WriteLine(a);//출력: 15

            a -= 5; //a = a - 5
            Console.WriteLine(a);//출력: 10

            a *= 5; //a = a * 5
            Console.WriteLine(a);//출력: 50

            a /= 5; //a = a / 5
            Console.WriteLine(a);//출력: 10

            a %= 5; //a = a % 5
            Console.WriteLine(a);//출력: 0


            ///문제 1
            int kor, eng, math;
            int sum;
            float avg;

            Console.Write("국어 점수를 입력하세요 : ");
            kor = int.Parse(Console.ReadLine());

            Console.Write("영어 점수를 입력하세요 : ");
            eng = int.Parse(Console.ReadLine());

            Console.Write("수학 점수를 입력하세요 : ");
            math = int.Parse(Console.ReadLine());

            sum = kor + eng + math;
            avg = (float)sum / 3;

            Console.WriteLine("총점: " + sum);
            Console.WriteLine("평균: " + avg.ToString("F2"));
            Console.WriteLine();

            ///문제 2
            int num;
            Console.Write("정수를 입력하세요 : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("입력한 값: " + num);
            Console.WriteLine("비트 반전 값: " + ~num);


            ///증감연산자
            int a = 3;

            //전위 증가 연산자
            Console.WriteLine("++a의 값: " + ++a);
            //후위 증가 연산자
            Console.WriteLine("a++의 값: " + a++);
            Console.WriteLine("a++의 값: " + a);

            ///비교 연산자
            int x = 5, y = 10;

            Console.WriteLine(x < y);//True
            Console.WriteLine(x > y);//False
            Console.WriteLine(x <= y);//True
            Console.WriteLine(x >= y);//False
            Console.WriteLine(x == y);//False
            Console.WriteLine(x != y);//True

            ///논리 연산자
            bool a = true;
            bool b = false;
            Console.Write(a && b);//AND -> False
            Console.Write(a || b);//OR ->True
            Console.Write(!a);//NOT -> False

            ///비트 연산자
            int x = 5;//0101
            int y = 3;//0011

            Console.WriteLine(x & y);//AND : 1 (0001)
            Console.WriteLine(x | y);//OR : 7 (0111)
            Console.WriteLine(x ^ y);//XOR : 6 (0110)
            Console.WriteLine(~x);//NOT : -6(1111 1010) 

            ///시프트 연산자
            int value = 4;//0100
            Console.WriteLine(value << 1);//왼쪽 이동: 8(1000)
            Console.WriteLine(value >> 1);//오른쪽 이동 : 2(0110)

            ///기타 연산자
            int a = 10, b = 20;
            //        ( 비교 ) ? 참 : 거짓;
            int max = (a > b) ? a : b; //삼항 연산자
            Console.WriteLine(max);//출력 : 20

            int key = 1;
            string str;
            str = (key == 1) ? "문이 열렸습니다." : "문이 열리지 않았습니다.";
            Console.WriteLine(str);

            ///연산자 우선순위
            int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선
            Console.WriteLine(result);//20

            int adjustedResult = (10 + 2) * 5;//괄호로 우선순위 변경
            Console.WriteLine(adjustedResult);//60

        }
    }
}
