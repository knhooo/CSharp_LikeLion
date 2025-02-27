using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2502274
{
    class Program
    {
        //C#구조체
        //클래스와 비슷하지만, 값 타입(value Type)이며 가볍고 빠름
        //주로 간단한 데이터 묶음을 만들 때 사용

        struct point
        {
            public int x;
            public int y;

            public point(int x, int y)
            {
                x = x;
                y = y;
            }
            public void print()
            {
                console.writeline($"좌표 : {x}, {y}");
            }
        }

        struct rectangle
        {
            public int width;
            public int height;

            public int getarea() => width * height;
        }

        struct Student
        {
            public string name;
            public int Kor;
            public int Eng;
            public int Math;

            public Student(string pname, int pKor, int pEng, int pMath)
            {
                name = pname;

                Kor = pKor;
                Eng = pEng;
                Math = pMath;
            }

            public void Print()
            {
                Console.WriteLine($"{name,-10} {Kor,5} {Eng,6} {Math,5}");
            }
        }

        static void Main(string[] args)
        {
            Point p;//구조체 선언(초기화 필요)
            p.X = 10;
            p.Y = 20;

            p.Print();

            Rectangle rect;
            rect.Width = 10;
            rect.Height = 20;
            Console.WriteLine($"Area : {rect.GetArea()}");

            Point[] points = new Point[2];
            points[0].X = 10;
            points[0].Y = 10;

            points[1].X = 20;
            points[1].Y = 20;
            foreach (var point in points)
            {
                Console.WriteLine($"Point: ({point.X},{point.Y}");
            }

            Student[] students = new Student[3];

            for(int i = 0; i < students.Length;i++){
                Console.Write("학생의 이름을 입력하세요: ");
                students[i].name = (Console.ReadLine());
                Console.Write("국어 성적을 입력하세요: ");
                students[i].Kor = int.Parse(Console.ReadLine());
                Console.Write("영어 성적을 입력하세요: ");
                students[i].Eng = int.Parse(Console.ReadLine());
                Console.Write("수학 성적을 입력하세요: ");
                students[i].Math = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("이름     국어     영어     수학");
            for(int i=0; i< students.Length; i++)
            {
                students[i].Print();
            }
            

        }
    }
}
