using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250304Task
{
    //문제 1
    public class Warrior
    {
        public string Name;
        public int Score;

        public int Strength;

        public Warrior(string _name, int _score, int _strength)
        {
            Name = _name;
            Score = _score;
            Strength = _strength;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Warrior war = new Warrior("워리어", 100, 100);
            Console.WriteLine($"이름: {war.Name} 점수: {war.Score} 힘: {war.Strength}");

            //문제2 
            int i = 0;
            Console.Write("정수를 입력하세요: ");
            try
            {
                i = int.Parse(Console.ReadLine());
                if (i is int)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("올바른 숫자를 입력하세요!");
            }

            ////문제3
            List<string> list = new List<string>();
            list.Add("사과");
            list.Add("바나나");
            list.Add("포도");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("첫 번째 작업");
            queue.Enqueue("두 번째 작업");
            queue.Enqueue("세 번째 작업");

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("List " + list[i]);
                Console.WriteLine("Queue " + queue.Dequeue());
                Console.WriteLine("Stack " + stack.Pop());
            }

            ////문제4
            Console.Write("문자열을 입력하세요: ");
            string str = Console.ReadLine();

            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Replace("#", "sharp"));
            Console.WriteLine(str.Length);

            //문제5
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var even = numbers.Where(n => n % 2 == 0);
            foreach(int i in even)
            {
                Console.WriteLine(i);
            }
            var sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
