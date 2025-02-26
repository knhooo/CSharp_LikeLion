using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2502263
{
    class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int GetLength(string sss)
        {
            return sss.Length;
        }

        static int GetMaxnum(int a1, int a2, int a3)
        {
            int max = a1;
            if (a2 > a3)
            {
                if (max < a2) max = a2;
            }
            else
            {
                if (max < a3) max = a3;
            }
            return max;
        }

        static void Main(string[] args)
        {
            //Q1. 배열 요소 출력
            Console.WriteLine("Q1. 배열 요소 출력");
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine(" ");
            //Q2. 배열 요소 합 구하기
            Console.WriteLine("Q2. 배열 요소 합 구하기");
            int[] arr2 = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("정수를 입력하세요: ");
                arr2[i] = int.Parse(Console.ReadLine());
                sum += arr2[i];
            }
            Console.WriteLine("모든 수의 합: "+sum);
            Console.WriteLine(" ");

            //Q3. 최댓값 찾기
            Console.WriteLine("Q3. 최댓값 찾기");
            int[] arr3 = new int[5] { 3, 8, 15, 6, 2 };
            int max = arr3[0];
            for(int i=1; i<5; i++)
            {
                if (arr3[i] > max)
                {
                    max = arr3[i];
                }
            }
            Console.WriteLine("가장 큰 값: " + max);
            Console.WriteLine("=============================");
            Console.WriteLine(" ");

            //Q4.1부터 10까지 출력
            Console.WriteLine("Q4.1부터 10까지 출력");
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(i + 1);
            }
            Console.WriteLine(" ");


            //Q5.짝수만 출력(while문)
            Console.WriteLine("Q5.짝수만 출력(while문)");
            int count = 1;
            while (count <= 10)
            {
                if (count % 2 == 0)
                    Console.WriteLine(count);
                count++;
            }
            Console.WriteLine(" ");

            //Q6.배열 요소 출력(foreach문)
            Console.WriteLine("Q6.배열 요소 출력(foreach문)");
            int[] arr4 = { 1, 2, 3, 4, 5 };

            foreach(int i in arr4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n=============================");
            Console.WriteLine(" ");


            //Q7.두 수의 합을 구하는 함수
            Console.WriteLine("Q7.두 수의 합을 구하는 함수");
            Console.Write("첫번째 정수를 입력하세요: ");
            int a = int.Parse(Console.ReadLine()); 
            Console.Write("두번째 정수를 입력하세요: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a}와 {b}의 합 = {Add(a, b)}");
            Console.WriteLine(" ");

            //Q8. 문자열 길이 반환 함수
            Console.WriteLine("Q8. 문자열 길이 반환 함수");
            Console.Write("문자열을 입력하세요: ");
            string str = Console.ReadLine();
            Console.WriteLine("문자열: " + str);
            Console.WriteLine("문자열 길이: " + GetLength(str));
            Console.WriteLine(" ");

            //Q9. 가장 큰 수 반환 함수
            Console.WriteLine("Q9. 가장 큰 수 반환 함수");
            Console.Write("첫번째 정수를 입력하세요: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("두번째 정수를 입력하세요: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("세번째 정수를 입력하세요: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("가장 큰 수: " + GetMaxnum(num1, num2, num3));
            Console.WriteLine(" ");

        }
    }
}
