using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello;

namespace Hello
{
    public class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요!");
        }
    }
}
namespace _2503061
{
    class Person
    {
        public string name;//필드 클래스의 데이터를 저장하는 멤버
        public int age;
        public void SetName(string n)
        {
            name = n;
        }
        public string GetName()
        {
            return name;
        }
        public Person()
        {
            name = "Unknown";
            age = 0;
        }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class MyResorce//소멸자
    {
        ~MyResorce()
        {
            Console.WriteLine("삭제될 때 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Say sa = new Say();
            sa.SayHello();

            Person p1 = new Person();
            Person p2 = new Person("Alice");
            Person p3 = new Person("Bob", 20);
            Console.WriteLine(p1.name + ", " + p1.age);
            Console.WriteLine(p2.name + ", " + p2.age);
            Console.WriteLine(p3.name + ", " + p3.age);

            MyResorce r = new MyResorce();

        }
    }
}
