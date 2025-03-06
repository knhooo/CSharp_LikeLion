using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250306Task
{
    class Monster : Info
    {
        //정보 출력
        public void Render()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("몬스터 이름 : " + Name);
            Console.WriteLine("체력 : " + Hp + "\t공격력 :  " + Attack);
        }

        public void SetMonster(string _name, int _hp, int _attack)
        {
            Name = _name;
            Hp = _hp;
            Attack = _attack;
        }

        public Monster() { }//기본 생성자
        ~Monster() { }//소멸자

    }
}
