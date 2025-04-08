using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    /// <summary>
    /// 큰 방이 보인다.	(15 * 15)
    /// 방의 입구(뚫린 곳)이 각 면에 하나씩 있다.(좌 / 우 / 앞)	
    ///빈 칸을 덧그리기?	
    ///기본 맵 아래에 숫자가 있고	
    ///그 위에 기본 맵을 덧그린다.	
    ///	
    ///얻을 수 있는 아이템	
    ///나무막대기(●)	
    ///확대경(●)	
    /// </summary>
    public class S3_LivingRoom : Scene
    {

        public override void CustomMapRender(char[,] commonMap)
        {
            // 입구 배치해주기 
            commonMap[10, 0] = 'L';
            commonMap[0, 16] = 'F';
            commonMap[10, 33] = 'R';
            commonMap[17, 16] = ' ';

            // L, R, F만 노랗게 출력해주기
            for (int i = 0; i < commonMap.GetLength(0); i++)
            {
                for (int j = 0; j < commonMap.GetLength(1); j++)
                {
                    char curChar = commonMap[i, j];

                    if (curChar == 'L' || curChar == 'F' || curChar == 'R')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(curChar);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(curChar);
                    }
                }
                Console.WriteLine();
            }

        }

        public override void CustomObjectRender()
        {
            Game.player.SetLocation(10, 10);
            Game.player.PlayerRender();




        }

        public override void Result(ConsoleKey input)
        {
            Game.player.Action(input);

            char curChar = commonMap[Game.player.playerlocation.x, Game.player.playerlocation.y];

            switch(curChar)
            {
                case 'L':
                    Game.changeScene("Left");
                    break;
                case 'F':
                    
                    if (플레이어가 횃불을 가지고 있지 않으면)
                        {
                            Game.changeScene("Front_Locked");
                        }
                    else if (플레이어가 횃불을 가지고 있으면)
                        {
                            Game.changeScene("Front_Unlocked");
                        }
                    break;
                case 'R':
                    Game.changeScene("Right");
                    break;

            }


            }

        }
    }
}
