using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503055
{
    //업캐스팅(Upcasting)
    //자식클래스 -> 부모클래스로 변환하는 것
    //암시적 변환이 가능(컴파일러가 자동 변환)
    //안전: 데이터 손실 없이 변환가능

    //다운 캐스팅
    //명시적 변환이 필요
    //불완전함 -> 실행중 InvalidCastException 발생 가능
    //as is 키워드로 안전하게 변환 가능
    class Animal//부모 클래스
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 내고있습니다.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Dog myDog = new Dog();//자식 클래스 객체 생성
            //Animal myAnimal = myDog;//업캐스팅(Dog->animal)

            //myAnimal.Speak();//사용가능

            ////myAnimal.Bark();//오류 발생
            ///
            Animal myAnimal = new Dog();//업캐스팅
            //Dog myDog = (Dog)myAnimal;//다운캐스팅(명시적 변환)

            //myDog.Bark();//실행

            //Animal myAnimal2 = new Animal();
            //Dog myDog = (Dog)myAnimal2;
            Dog myDog = myAnimal as Dog;

            if(myDog != null)
            {
                myDog.Bark();
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }

            if (myAnimal is Dog myDog1)
            {
                myDog1.Bark();//실행
            }
            else
            {
                Console.WriteLine("변환할 수 없습니다.");
            }

        }
    }
}
