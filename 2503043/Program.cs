using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503043
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열과 컬렉션
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 컬렉션
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            names.Add("Dave");
            names.Remove("Bob");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            //Console.WriteLine(list[1]);
            //list.Insert(1, 100);
            //Console.WriteLine(list[1]);

            list.Insert(1, 100);
            Console.WriteLine(list.Count);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            //Stack
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            //Queue
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Queue queue = new Queue();

            queue.Enqueue("q");
            queue.Enqueue("w");
            queue.Enqueue("e");
            queue.Enqueue("r");
            queue.Enqueue("점멸");
            queue.Enqueue("평타");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            //ArrayList : 크기가 동적으로 조절되는 배열
            //ArrayList 생성
            ArrayList arrayList = new ArrayList();

            //요소 추가
            arrayList.Add(1);//정수
            arrayList.Add("Hello");//문자열
            arrayList.Add(3.14);//실수

            //요소 접근
            Console.WriteLine("ArrayList 요소: ");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //요소 제거
            arrayList.Remove(1);
            Console.WriteLine("\n ArrayList요소 제거 후: ");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Hashtable 클래스
            //키-값 쌍을 저장하는 컬렉션
            //키를 이용해 값을 빠르게 검색

            Hashtable hashtable = new Hashtable();

            //키-값 쌍 추가
            hashtable["Alice"] = 25;
            hashtable["Bob"] = 30;
            hashtable["포션"] = 20;

            Console.WriteLine("Hashtable 요소: ");

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}
