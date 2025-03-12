using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickOut
{
    public class Ball
    {
        BallData ballData = new BallData();

        //공의 방향 배열 정의
        int[,] wallCollision = new int[4, 6]
        {
            { 3, 2,-1,-1,-1, 4},
            {-1,-1,-1,-1, 2, 1},
            {-1, 5, 4,-1,-1,-1},
            {-1,-1, 1, 0, 5,-1}
        };

        Bar bar;
        Block block;

        public void SetBar(Bar _bar)
        {
            bar = _bar;
        }
        public void SetBlock(ref Block _block)
        {
            block = _block;
        }
        public void ScreenWall()
        {
            Program.GoToXY(0, 0);
            Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Program.GoToXY(0, 1);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 2);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 3);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 4);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 5);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 6);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 7);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 8);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 9);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 10);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 11);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 12);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 13);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 14);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 15);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 16);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 17);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 18);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 19);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 20);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 21);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 22);
            Console.Write("┃                                                                             ┃");
            Program.GoToXY(0, 23);
            Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }

        public int Collision(int x, int y)
        {
            //벽에 충돌
            if (y == 0)
            {
                ballData.Direct = wallCollision[0, ballData.Direct];
                return 1;//공의 방향이 바뀌면 1을 반환
            }
            if (x == 1)
            {
                ballData.Direct = wallCollision[1, ballData.Direct];
                return 1;
            }
            if (x == 77)
            {
                ballData.Direct = wallCollision[2, ballData.Direct];
                return 1;
            }
            if (y == 23)
            {
                ballData.Direct = wallCollision[3, ballData.Direct];
                return 1;
            }
            

            //바 충돌
            if (x >= bar.m_tBar.nX[0] && x <= bar.m_tBar.nX[2] + 1 &&
              y == (bar.m_tBar.nY + 1)) //바 아래 충돌
            {
                if (ballData.Direct == 1)
                    ballData.Direct = 2;
                else if (ballData.Direct == 2)
                    ballData.Direct = 1;
                else if (ballData.Direct == 5)
                    ballData.Direct = 4;
                else if (ballData.Direct == 4)
                    ballData.Direct = 5;

                return 1; //방향이 바뀐다.
            }

            if (x >= bar.m_tBar.nX[0] && x <= bar.m_tBar.nX[2] + 1 &&
                y == (bar.m_tBar.nY)) //바 위 충돌
            {
                if (ballData.Direct == 1)
                    ballData.Direct = 2;
                else if (ballData.Direct == 2)
                    ballData.Direct = 1;
                else if (ballData.Direct == 5)
                    ballData.Direct = 4;
                else if (ballData.Direct == 4)
                    ballData.Direct = 5;

                return 1; //방향이 바뀐다.
            }
            //벽돌충돌
            for (int i = 0; i < 20; i++)
            {
                if (block.tBlock[i].nLife == 1)
                {
                    if (x >= block.tBlock[i].nX && x <= block.tBlock[i].nX + 1 &&
                        y == block.tBlock[i].nY)
                    {
                        if (ballData.Direct == 1)
                            ballData.Direct = 2;
                        else if (ballData.Direct == 2)
                            ballData.Direct = 1;
                        else if (ballData.Direct == 5)
                            ballData.Direct = 4;
                        else if (ballData.Direct == 4)
                            ballData.Direct = 5;

                        //벽돌 삭제
                        block.tBlock[i].nLife = 0;

                        return 1;
                    }


                    if (x >= block.tBlock[i].nX && x <= block.tBlock[i].nX + 1 &&
                       y == block.tBlock[i].nY + 1)
                    {
                        if (ballData.Direct == 1)
                            ballData.Direct = 2;
                        else if (ballData.Direct == 2)
                            ballData.Direct = 1;
                        else if (ballData.Direct == 5)
                            ballData.Direct = 4;
                        else if (ballData.Direct == 4)
                            ballData.Direct = 5;

                        //벽돌 삭제
                        block.tBlock[i].nLife = 0;

                        return 1;
                    }
                }
            }

             return 0;

        }

        public BallData GetBall() { return ballData; }
        public void SetX(int x) { ballData.X = x; }
        public void SetY(int y) { ballData.Y = y; }
        public void SetBall(BallData _ballData) { ballData = _ballData; }
        public void SetReady(int ready) { ballData.Ready = ready; }

        public void Initialize()
        {
            ballData.Ready = 0;//0: 공 움직임 1: 공 안움직임
            ballData.Direct = 1;
            ballData.X = 30;
            ballData.Y = 10;

            //커서 안보이게 하기
            Console.CursorVisible = false;
        }
        public void Progress()
        {
            if (ballData.Ready == 0)//움직임
            {
                //공의 방향에 따른 스위치문
                switch (ballData.Direct)
                {
                    case 0://위
                        if (Collision(ballData.X, ballData.Y - 1) == 0)
                            ballData.Y--;
                        break;
                    case 1://오른쪽 위
                        if (Collision(ballData.X + 1, ballData.Y - 1) == 0)
                        {
                            ballData.X++;
                            ballData.Y--;
                        }
                        break;
                    case 2://오른쪽 아래
                        if (Collision(ballData.X + 1, ballData.Y + 1) == 0)
                        {
                            ballData.X++;
                            ballData.Y++;
                        }
                        break;
                    case 3://아래
                        if (Collision(ballData.X, ballData.Y + 1) == 0)
                            ballData.Y++;
                        break;
                    case 4://왼쪽 아래
                        if (Collision(ballData.X - 1, ballData.Y + 1) == 0)
                        {
                            ballData.X--;
                            ballData.Y++;
                        }
                        break;
                    case 5://왼쪽 위
                        if (Collision(ballData.X - 1, ballData.Y - 1) == 0)
                        {
                            ballData.X--;
                            ballData.Y--;
                        }
                        break;
                }
            }
        }
        public void Render()
        {
            ScreenWall();
            Program.GoToXY(ballData.X, ballData.Y);
            Console.Write("●");
        }

        public void Release() { }
    }
}
