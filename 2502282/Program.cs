using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2502282
{
    ///Getter, Setter함수
    class Person
    {
        private string name; //내부 변수

        //값 설정하기(Setter)
        public void SetName(string newName)
        {
            name = newName;
        }
        //값 가져오기(Getter)
        public string GetName()
        {
            return name;
        }
    }

    ///프로퍼티 property
    class Person
    {
        private string name;//내부 변수

        public string Name//프로퍼티
        {
            get { return name; }//Getter
            set { name = value; }//Setter
        }
    }

    ///프로퍼티 자동 구현
    class Person
    {
        private int count = 100;
        public string Name { get; set;}//자동 구현 프로퍼티

        public int Count
        {
            get { return count; }//읽기만 가능
        }

        public float Balance { get; private set; }//외부 변경 불가능
        public void AddBal()
        {
            Balance += 100;
        }
    }

    class Marine
    {
        public string Name { get; set; }
        public int Mineral { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ///Setter, Getter
            Person p = new Person();

            p.SetName("홍길동");

            Console.WriteLine("이름: " + p.GetName());

            ///프로퍼티
            Person p = new Person();

            p.Name = "홍길동";
            //p.Count = 50; => 오류 발생!
            //p.Balance = 5.5;=> 오류 발생!
            p.AddBal();
            Console.WriteLine("이름: " + p.Name+" Count: "+p.Count);

            Marine m = new Marine();
            Console.WriteLine("이름: " + m.Name + "미네랄: " + m.Mineral);
        }
    }
}
