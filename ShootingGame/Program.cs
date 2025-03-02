using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ShootingGame
{

    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }

    //플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져오기

        public int playerX;//플레이어 X좌표
        public int playerY;//플레이어 Y좌표
        public BULLET[] playerBullet = new BULLET[20];
        public BULLET[] playerBullet2 = new BULLET[20];
        public BULLET[] playerBullet3 = new BULLET[20];
        public int Score = 100;
        public Item item = new Item();
        public int itemCount = 0;
        public int Life = 3;

        const int UPKEY = 72;
        const int DOWNKEY = 80;
        const int LEFTKEY = 75;
        const int RIGHTKEY = 77;
        const int SPACEBAR = 32;

        public Player()//디폴트 생성자
        {
            //플레이어 좌표 위치 초기화
            playerX = 0;
            playerY = 12;

            for(int i=0; i<20; i++)//총알 초기화
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;

                playerBullet2[i] = new BULLET();
                playerBullet2[i].x = 0;
                playerBullet2[i].y = 0;
                playerBullet2[i].fire = false;

                playerBullet3[i] = new BULLET();
                playerBullet3[i].x = 0;
                playerBullet3[i].y = 0;
                playerBullet3[i].fire = false;
            }
            
        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            //플레이어 출력
            PlayerDraw();

            //UI점수
            UIScore();

            if (item.ItemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        private void KeyControl()
        {
            int pressKey;//정수형 초기 선언 
            if(Console.KeyAvailable)//키가 눌렸을 때 true
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽

                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case UPKEY://위쪽 방향 아스키코드
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        break;
                    case LEFTKEY://왼쪽 방향 아스키코드
                        playerX--;
                        if (playerX < 0)
                            playerY = 0;
                        break;
                    case RIGHTKEY://오른쪽 방향 아스키코드
                        playerX++;
                        if (playerX > 75)
                            playerY = 75;
                        break;
                    case DOWNKEY://아래쪽 방향 아스키코드
                        playerY++;
                        if (playerY > 23)
                            playerY = 23;
                        break;
                    case SPACEBAR://스페이스바
                        //총알 발사
                        for(int i=0; i<20; i++)
                        {
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 +5;
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1 ;
                                //한 발씩 쏜다
                                break;
                            }
                        }
                        //총알2 발사
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet2[i].fire == false)
                            {
                                playerBullet2[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 +5;
                                playerBullet2[i].x = playerX + 5;
                                playerBullet2[i].y = playerY;
                                break;
                            }
                        }
                        //총알3 발사
                        for (int i = 0; i < 20; i++)
                        {
                            if (playerBullet3[i].fire == false)
                            {
                                playerBullet3[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 +5;
                                playerBullet3[i].x = playerX + 5;
                                playerBullet3[i].y = playerY + 2;
                                //한 발씩 쏜다
                                break;
                            }
                        }
                        break;

                }
            }    
        }

        //미사일 그리기
        public void BulletDraw()
        {
            string bullet = "->";//미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet[i].fire == true)
                {
                    //좌표 설정 -> 중간 위치 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet[i].x - 1, playerBullet[i].y);

                    //총알 출력
                    Console.Write(bullet);

                    playerBullet[i].x++;//미사일 오른쪽으로 이동
                    if (playerBullet[i].x > 78)
                    {
                        playerBullet[i].fire = false;//다시 준비상태로
                    }

                }
            }
        }
        public void BulletDraw2()
        {
            string bullet = "->";//미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet2[i].fire == true)
                {
                    //좌표 설정 -> 중간 위치 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet2[i].x - 1, playerBullet2[i].y);

                    //총알 출력
                    Console.Write(bullet);

                    playerBullet2[i].x++;//미사일 오른쪽으로 이동
                    if (playerBullet2[i].x > 78)
                    {
                        playerBullet2[i].fire = false;//다시 준비상태로
                    }

                }
            }
        }
        public void BulletDraw3()
        {
            string bullet = "->";//미사일 모습

            //20개
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet3[i].fire == true)
                {
                    //좌표 설정 -> 중간 위치 보정을 위해 x-1
                    Console.SetCursorPosition(playerBullet3[i].x - 1, playerBullet3[i].y);

                    //총알 출력
                    Console.Write(bullet);

                    playerBullet3[i].x++;//미사일 오른쪽으로 이동
                    if (playerBullet3[i].x > 78)
                    {
                        playerBullet3[i].fire = false;//다시 준비상태로
                    }

                }
            }
        }
        public void PlayerDraw()
        {
            String[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };//배열 문자열로 그리기

            for(int i=0; i < player.Length; i++)
            {
                //콘솔 좌표 설정 플레이어x, 플레이어 y
                Console.SetCursorPosition(playerX, playerY + i);
                //플레이어 출력
                Console.WriteLine(player[i]);
            }

        }

        public void CollisionWithEnemy(Enemy enemy)
        {
            if (playerY >= enemy.enemyY-1 && playerY <= enemy.enemyY + 1)
            {
                //충돌시
                if (playerX >= (enemy.enemyX - 1)
                    && playerX <= (enemy.enemyX + 1))
                {
                    //목숨 감소
                    Life--;
                    //적 삭제
                    Random rand = new Random();
                    enemy.enemyX = 75;
                    enemy.enemyY = rand.Next(2, 22);

                }
            }
        }
        ////충돌처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {
            //미사일 20개 체크
            for(int i=0; i<20; i++)
            {
                //살아있는 미사일
                if (playerBullet[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet[i].y == enemy.enemyY)
                    {
                        //충돌시
                        if (playerBullet[i].x >= (enemy.enemyX-1) 
                            && playerBullet[i].x <= (enemy.enemyX + 1))
                        {
                            //아이템 생성
                            item.ItemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet[i].fire = false;//미사일 준비상태로

                            //점수 증가
                            Score += 100;
                        }
                    }
                }
            }
            //미사일 20개 체크
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet2[i].y == enemy.enemyY)
                    {
                        //충돌시
                        if (playerBullet2[i].x >= (enemy.enemyX - 1)
                            && playerBullet2[i].x <= (enemy.enemyX + 1))
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet2[i].fire = false;//미사일 준비상태로

                            //점수 증가
                            Score += 100;
                        }
                    }
                }
            }
            //미사일 20개 체크
            for (int i = 0; i < 20; i++)
            {
                //살아있는 미사일
                if (playerBullet3[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (playerBullet3[i].y == enemy.enemyY)
                    {
                        //충돌시
                        if (playerBullet3[i].x >= (enemy.enemyX - 1)
                            && playerBullet3[i].x <= (enemy.enemyX + 1))
                        {
                            Random rand = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = rand.Next(2, 22);

                            playerBullet3[i].fire = false;//미사일 준비상태로

                            //점수 증가
                            Score += 100;
                        }
                    }
                }
            }
        }
        public void UIScore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Life : " + Life);
            Console.SetCursorPosition(63, 2);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 2);
            Console.Write("Score : " + Score);
            Console.SetCursorPosition(63, 3);
            Console.Write("┗━━━━━━━━━━━━━━┛");
            if (Life < 1)
            {
                Console.SetCursorPosition(30, 0);
                Console.Write("┏━━━━━━━━━━━━━━┓");
                Console.SetCursorPosition(30, 1);
                Console.Write("┃              ┃");
                Console.SetCursorPosition(33, 1);
                Console.Write("Game Over");
                Console.SetCursorPosition(30, 2);
                Console.Write("┗━━━━━━━━━━━━━━┛");

                Thread.Sleep(3000);
                Console.Clear();
            }
        }

        //아이템 충돌이 일어나면 양쪽 미사일 발사
        public void CrashItem()
        {
            if(playerY+1 == item.itemY)
            {
                if(playerX >= item.itemX-2 && playerX<= item.itemX +2)
                {
                    item.ItemLife = false;
                    if(itemCount < 3)
                    {
                        itemCount++;
                    }
                    
                    for(int i=0; i<20; i++)//총알 초기화
                    {
                        playerBullet[i] = new BULLET();
                        playerBullet[i].x = 0;                    
                        playerBullet[i].y = 0;                    
                        playerBullet[i].fire = false;

                        playerBullet2[i] = new BULLET();
                        playerBullet2[i].x = 0;
                        playerBullet2[i].y = 0;
                        playerBullet2[i].fire = false;
                        
                        playerBullet3[i] = new BULLET();
                        playerBullet3[i].x = 0;
                        playerBullet3[i].y = 0;
                        playerBullet3[i].fire = false;
                    }
                }
            }
        }
    }

    public class Enemy//적 클래스
    {
        public int enemyX;//x좌표
        public int enemyY;//y좌표

        public Enemy()
        {
            //적 좌표 초기화
            enemyX = 77;
            enemyY = 12;
        }

        public void EnemyDraw()
        {
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);//좌표 설정
            Console.Write(enemy);//출력
        }

        public void EnemyMove()
        {
            Random rand = new Random();
            enemyX--;//왼쪽으로 이동

            if(enemyX < 3)//화면 왼쪽에 닿을 경우
            {
                enemyX = 77;
                enemyY = rand.Next(2, 22);//2~21
            }
        }
    }

    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int itemX = 0;
        public int itemY = 0;
        public bool ItemLife = false;

        public void ItemMove()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "☆★";
            Console.Write(ItemSprite);
        }

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            ItemSprite = "☆★";
            Console.Write(ItemSprite);
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //플레이어 생성
            Player player = new Player();
            Enemy enemy = new Enemy();//적 생성

            //유니티처럼 프레임 속도
            int dwTime = Environment.TickCount;// 1/1000가 흐른다.

            while (true)
            {
                //0.05초 지연
                if(dwTime + 50 < Environment.TickCount)
                {
                    //현재 시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();

                    //총알
                    if(player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if(player.itemCount == 1){
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2(); 
                        player.BulletDraw3();
                    }


                    enemy.EnemyMove();
                    enemy.EnemyDraw();

                    //충돌처리
                    player.ClashEnemyAndBullet(enemy);
                    player.CollisionWithEnemy(enemy);
                }
            }

        }
    }
}
