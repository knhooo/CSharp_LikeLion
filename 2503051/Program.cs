using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503051
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Charile", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n);

            //int Identity(int n)
            //{
            //    return n;
            //}

            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            var firstName = names.First(n => n.StartsWith("A"));
            Console.WriteLine($"First name starting with A:{firstName}");

            //메서드 구문, 쿼리 구문
            int[] nums = { 5, 3, 8, 1 };

            //메서드 구문
            var sortedMethod = nums.OrderBy(n => n);

            //쿼리 구문
            var sortedQuery = from n in nums
                              orderby n
                              select n;

            Console.WriteLine("Method syntax: ");
            foreach (var n in sortedMethod) Console.WriteLine(n);

            Console.WriteLine("Query syntax: ");
            foreach (var n in sortedQuery) Console.WriteLine(n);

            string[] words = { "apple", "banana", "cherry" };
            //Select()로 길이 추출
            var lengths = words.Select(w => w.Length);

            foreach (var length in lengths)
            {
                Console.WriteLine(length);
            }

            //sum 알고리즘
            int[] data = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (var d in data)
            {
                sum += d;
            }
            Console.WriteLine($"Sum: {sum}");//15

            //count
            int[] data = { 1, 2, 3, 4, 5 };

            int count = data.Length;

            Console.WriteLine($"Count: {count}");//5

            ////average 
            int[] data = { 1, 2, 3, 4, 5 };
            double avg = data.Average();
            Console.WriteLine($"Average: {avg}"); //3

            //MAX
            int[] data = { 10, 3, 5, 2, 8 };
            int max = data.Max();
            Console.WriteLine($"Max : {max}");//10

            //Min
            int[] data = { 55, 66, 48 };
            int min = data.Min();
            Console.WriteLine($"Min : {min}");//48

            ////Near 알고리즘
            int[] data = { 10, 20, 30, 43, 55 };
            int target = 22;
            int nearest = data[0];

            foreach (var d in data)
            {
                if (Math.Abs(d - target) < Math.Abs(nearest - target))
                    nearest = d;
            }

            Console.WriteLine($"Nearest to {target}: {nearest}");//20

            //Rank 알고리즘
            int[] scores = { 90, 70, 50, 70, 60 };
            for (int i = 0; i < scores.Length; i++)
            {
                int rank = 1;
                for (int j = 0; j < scores.Length; j++)
                {
                    if (scores[j] > scores[i]) rank++;
                }
                Console.WriteLine($"Score: {scores[i]}, Rank:{rank}");
            }

            //순서대로 나열하기 : sort
            int[] data = { 5, 2, 8, 1, 9 };
            Array.Sort(data);

            foreach (var d in data) Console.WriteLine(d);

            search
            int[] data = { 5, 2, 8, 1, 9 };
            int target = 8;
            int index = -1;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");
            //Found at index 2


            //그룹 
            string[] fruits = { "apple", "banana", "blueberry", "cherry", "apricot" };

            var groups = fruits.GroupBy(f => f[0]);//첫 글자로 그룹화

            foreach(var group in groups)
            {
                Console.WriteLine($"Key:{group.Key}");
                foreach(var item in group){
                    Console.WriteLine($" {item}");
                }
            }

        }
    }
}
