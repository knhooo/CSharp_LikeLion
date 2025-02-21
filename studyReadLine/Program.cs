using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력을 문자열에 저장
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); //사용자로부터 입력 받기

            //Console.WriteLine($"안녕하세요, {userName}님!");

            ////문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine();//사용자로부터 입력 받기
            //int age = int.Parse(input);//문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");//변환된 값 사용
            //Console.WriteLine("내년에는 "+age + "살이 되겠군요!");
            //Console.WriteLine("내년에는 {0}살이 되겠군요!",age);

            //과제
            float skilldam;
            float card;
            float damage;
            int maxMana;
            int manaUp_battle;
            int manaUp_nobattle;
            float speed;
            float rideSpeed;
            float moveSpeed;
            float coolTime;

            Console.Write("루인 스킬 피해: ");
            skilldam = float.Parse(Console.ReadLine());

            Console.Write("카드 게이지 획득량: ");
            card = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해: ");
            damage = float.Parse(Console.ReadLine());

            Console.Write("최대 마나: ");
            maxMana = int.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량: ");
            manaUp_battle = int.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량: ");
            manaUp_nobattle = int.Parse(Console.ReadLine());

            Console.Write("이동 속도: ");
            speed = float.Parse(Console.ReadLine());

            Console.Write("탈 것 속도: ");
            rideSpeed = float.Parse(Console.ReadLine());

            Console.Write("운반 속도: ");
            moveSpeed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소: ");
            coolTime = float.Parse(Console.ReadLine());


            Console.WriteLine("====================================");
            Console.WriteLine("루인 스킬 피해: "+skilldam+"%");
            Console.WriteLine("카드 게이지 획득량: " + card+"%");
            Console.WriteLine("각성기 피해: "+damage+"%");
            Console.WriteLine("최대 마나: "+maxMana);
            Console.WriteLine("전투 중 마나 회복량: "+manaUp_battle);
            Console.WriteLine("비전투 중 마나 회복량: "+manaUp_nobattle);
            Console.WriteLine("이동 속도: "+speed+"%");
            Console.WriteLine("탈 것 속도: "+rideSpeed+"%");
            Console.WriteLine("운반 속도: "+moveSpeed+"%");
            Console.WriteLine("스킬 재사용 대기시간 감소: "+coolTime+"%");
        }
    }
}
