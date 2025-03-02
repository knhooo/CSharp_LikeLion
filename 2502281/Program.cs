using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2502281
{
     class Person
    {
        private string Name;
        private int Age;

        //기본 생성자(디폴트 생성자)
        //클래스가 객체로 생성될 때 자동으로 실행되는 특별한 메서드
        //클래스와 같은 이름을 가지며, 반환형이 없다.(void도 없음)
        //객체를 만들 때 필요한 초기값을 설정할 때 사용한다.

        public Person()
        {
            Name = "이름 없음";
            Age = 0;
            Console.WriteLine("기본 생성자 실행");
        }
        public Person(string pName, int pAge)
        {
            Name = pName;
            Age = pAge;
            Console.WriteLine("매개변수가 있는 생성자 실행");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 나이 : {Age}");
        }
    }

    class Marine
    {
        private string Name;
        private int Mineral;

        public Marine()
        {
            Name = "Marine";
            Mineral = 50;
        }
        public Marine(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄: {Mineral}");
        }
    }

    //this 키워드 : 자기 자신을 가르킨다.
    class Barrack
    {
        private string Name;
        private int Mineral;

        public Barrack()
        {
            Name = "Barrack";
            Mineral = 150;
        }
        public Barrack(string Name, int Mineral)
        {
            this.Name = Name;
            this.Mineral = Mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄: {Mineral}");
        }
    }

    class Mineral
    {
        public int Minerals;
        public int NumOfMineral;   
        
        public Mineral()
        {
            NumOfMineral = 7;
        }
        public Mineral(int numOfMineral)
        {
            NumOfMineral = numOfMineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"현재 미네랄 수: {NumOfMineral}");
        }
    }
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;

        public static void ShowInfo()
        {
            Console.WriteLine($"미네랄: {mineral}, 가스: {gas}, 인구수: {charCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();


            Person p1 = new Person();//객체 생성 instance //디폴트 생성자
            p1.ShowInfo();

            Person p2 = new Person("철수", 25);//매개변수가 있는 생성자
            p2.ShowInfo();

            Marine m1 = new Marine();
            Marine m2 = new Marine("불꽃테란",100);

            m1.ShowInfo();
            m2.ShowInfo();

            Barrack barrack = new Barrack();
            barrack.ShowInfo();
            //객체 배열 생성
            Mineral[] mineral = new Mineral[7]; 
            //객체 생성
            for(int i=0; i < mineral.Length; i++)
            {
                mineral[i] = new Mineral();
                mineral[i].ShowInfo();
            }
        }
    }
}
