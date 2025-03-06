using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503065
{
    //인터페이스
    //인터페이스는 클래스나 구조체에서 구현해야하는 메서드, 속성 등을 정의하는 추상적인 개념
    //어떤 기능을 반드시 포함하도록 강제하는 역할

    //인터페이스를 구현하는 클래스에서 반드시 구현해야함
    //다중 상속 가능
    //객체를 생성할 수 없음

    //인터페이스 정의
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("야옹~");
        }
    }

    //인터페이스를 활용한 공통메서드
    class AnimalTrainer
    {
        public void Train(IAnimal animal)
        {
            Console.Write("동물이 소리를 냅니다.");
            animal.Speak();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AnimalTrainer trainer = new AnimalTrainer();

            IAnimal myDog = new Dog();
            IAnimal myCat = new Cat();

            trainer.Train(myDog);
            trainer.Train(myCat);

        }
    }
}