using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class Info
    {
        public string name;//이름
        public int hp;//체력
        public int att;//공격력

        public void GetDamage(int damage)
        {
            hp -= damage;
        }
    }
}
