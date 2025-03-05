using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2503059
{
    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}이(가) 기본 공격을 합니다.");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은 치료할 수 없습니다.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}이(가) 이동합니다.");
        }
    }

    //토르비욘 유닛(건설과 수리 기능)
    class Torbjorn : Unit
    {
        public Torbjorn()
        {
            Name = "토르비욘";
            Health = 225;
        }

        public override void Attack()
        {
            Console.WriteLine("토르비욘이 망치로 공격합니다!");
        }

        public override void Heal(Unit target) {
            Console.WriteLine($"토르비욘이 {target.Name}을 수리합니다.");
        }
    }

    //솔저76 유닛(총기 공격)
    class Soldier : Unit
    {
        public Soldier()
        {
            Name = "솔저:76";
            Health = 250;
        }
        public override void Attack()
        {
            Console.WriteLine("솔저:76이 펄스 소총으로 공격합니다.");
        }
    }

    //메르시 유닛(힐러)
    class Mercy : Unit
    {
        public Mercy()
        {
            Name = "메르시";
            Health = 225;
        }
        public override void Heal(Unit target)
        {
            Console.WriteLine($"메르시가 {target.Name}을 치료합니다.");
        }
    }

    //포탑
    class Turret : Unit
    {
        public Turret()
        {
            Name = "포탑";
            Health = 250;

        }

        public override void Attack()
        {
            Console.WriteLine("포탑이 공격을 실시합니다.");
        }

        public override void Move()
        {
            //Console.WriteLine("포탑은 이동할 수 없습니다.");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();
            units.Add(new Torbjorn());
            units.Add(new Soldier());
            units.Add(new Mercy());
            units.Add(new Turret());

            //모든 유닛을 순회하며 다형성 적용
            foreach(var unit in units)
            {
                unit.Move();//이동
                unit.Attack();//공격
                Console.WriteLine();
            }

            //토르비욘이 포탑 수리
            Torbjorn scv = new Torbjorn();
            scv.Heal(units[3]);//포탑 수리

            //메르시가 솔저 치유
            Mercy medic = new Mercy();

            medic.Heal(units[1]);
        }
    }
}
