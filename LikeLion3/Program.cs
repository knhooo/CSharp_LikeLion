﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //리터럴은 변하지 않는 값으로 변수에 할당하거나 직접 사용할 수 있다.
            int hp = 100;//정수형 리터럴
            double att = 56.7;//실수형 리터럴
            char grade = 'A';//문자 리터럴
            string name = "Alice";//문자열 리터럴

            Console.WriteLine("캐릭터");
            Console.WriteLine("공격력 : " +hp); //출력 : 56.7
            Console.WriteLine("체력 : "+att); //출력 : 56.7
            Console.WriteLine("등급 : "+grade); //출력 : A
            Console.WriteLine("이름 : "+name); //출력 : Alice
        }
    }
}
