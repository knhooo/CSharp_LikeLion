using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2503041
{
    //[접근 지정자] [수정자] class 클래스 이름 : 부모클래스, 인터페이스
    //public        abstract                 : BaseClass, IComparable
    //private       sealed
    //protected     static
    //              partial

    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    //상속하는 클래스
    public class Warrior : Player
    {
        public int strength { get; set; }
    }
    //인터페이스를 구현하는 클래스
    public class Enemy: IAttackable, IMovable
    {
        public void Attack() { }
        public void Move() { }
    }

    //추상 클래스(abstract)
    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 종료");

            string path = Environment.GetEnvironmentVariable("PATH");

            Console.WriteLine($"PATH: {path}");
            Environment.Exit(0);

            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine("랜덤 숫자 : " + randomNumber);

            //프로그램 실행 시간 구하기
            Stopwatch stopwatch = Stopwatch.StartNew();

            //실행 코드
            for (int i = 0; i < 1000000; i++)
            {

            }
            stopwatch.Stop();
            Console.WriteLine("실행 시간: " + stopwatch.ElapsedMilliseconds + "ms");

            string input = "Hello, my phone number is 010-1234-5678";
            string pattern = @"\d{3}-\d{4}-\d{4}";
            bool isMatch = Regex.IsMatch(input, pattern);

            Console.WriteLine($"전화번호가 존재하는가? :{isMatch}");



        }
    }
}
