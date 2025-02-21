using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열
            string greeting;//문자열 변수를 선언
            greeting = "Hello, World!";//변수에 값을 저장

            //변수의 값을 출력
            Console.WriteLine(greeting);//출력 : Hello, World!

            //변수 선언과 초기화를 한번에 수행
            int score = 100;//정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.6;//실수형 변수
            string city = "Seoul";//문자열 변수 선언과 초기화

            //변수 출력
            Console.WriteLine(score);//출력 100
            Console.WriteLine(temperature);//출력 36.5
            Console.WriteLine(city);//출력 Seoul

            //같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            int x = 10, y = 20, z = 30; //정수형 변수 x,y,z를 선언하고 초기화
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //상수 사용하기
            const double Pi = 3.14159;//상수 pi 선언 및 초기화
            const int MaxScore = 100;//정수형 상수 선언

            //Pi = 1.11;
            //출력
            Console.WriteLine("Pi : " + Pi);//출력 : Pi: 3.14159
            Console.WriteLine("MaxScore : " + MaxScore);//출력 : MaxScore: 100

            int att = 16755;
            int maxhp = 78103;
            int stat1 = 36;
            int stat2 = 1017;
            int stat3 = 41;
            int stat4 = 611;
            int stat5 = 22;
            int stat6 = 39;

            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("최대 생명력 : " + maxhp);
            Console.WriteLine("치명 : " + stat1);
            Console.WriteLine("특화 : " + stat2);
            Console.WriteLine("제압 : " + stat3);
            Console.WriteLine("신속 : " + stat4);
            Console.WriteLine("인내 : " + stat5);
            Console.WriteLine("숙련 : " + stat6);



        }
    }
}
