using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250306Task
{
    public class Info
    {
        public string Name;//이름
        public int Attack;//공격력
        public int Hp;//체력

        //데미지 
        public void SetDamage(int _attack)
        {
            Hp -= _attack;
        }

        //hp 설정
        public void SetHp(int _hp)
        {
            Hp = _hp;
        }

        
    }
}
