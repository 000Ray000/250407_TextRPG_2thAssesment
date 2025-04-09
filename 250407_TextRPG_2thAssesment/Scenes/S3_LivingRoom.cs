using _250407_TextRPG_2thAssesment.Items;
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

        public override void CommonRender()
        {

        }

        public override void CustomMapRender(char[,] commonMap)
        {
            // 입구 배치해주기 
            commonMap[10, 0] = 'L';
            commonMap[0, 16] = 'F';
            commonMap[10, 33] = 'R';
            commonMap[17, 16] = ' ';

            // 숫자 배치해주기
            commonMap[2, 8] = '4';
            commonMap[15, 6] = '7';
            commonMap[3, 21] = '6';
            commonMap[13, 23] = '9';

            //오브젝트 배치해주기
            commonMap[4, 4] = commonMap[8, 28] = '●';

            // L, R, F는 노란색으로 | 숫자는 까만색으로 | 오브젝트는 초록색으로 출력해주기
            for (int i = 0; i < commonMap.GetLength(0); i++)
            {
                for (int j = 0; j < commonMap.GetLength(1); j++)
                {
                    char curChar = commonMap[i, j];

                    if (curChar == 'L' || curChar == 'F' || curChar == 'R')
                    {
                        Console.SetCursorPosition(j, i);
                        Console.ForegroundColor = ConsoleColor.Yellow;                    
                        Console.Write(curChar);
                        Console.ResetColor();
                    }
                    if (curChar == '4' || curChar == '7' || curChar == '6' || curChar == '9')
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(curChar);
                        Console.ResetColor();
                    }
                    if (curChar == '●')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
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


            // 플레이어 그려주기
            Game.player.SetLocation(16, 17);
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
                    //TODO: 이렇게 안 하면 인벤토리 클래스의 인벤토리일 뿐이고, 한 번 더 붙여야 인벤토리 필드에 접근 가능하다는데 공부 필요.
                   foreach (Object item in Game.player.inventory.inventory)
                    {
                        if (item.name is "Torch")
                        {
                            Game.changeScene("Front_Unlocked");
                        }
                        else
                        {
                            Game.changeScene("Front_Locked");
                        }
                    }
                    break;
                case 'R':
                    Game.changeScene("Right");
                    break;
                case '●':
                    if (commonMap[4, 4] == commonMap[Game.player.playerlocation.x, Game.player.playerlocation.y])
                    {
                        Console.WriteLine("You found a WoodStick.");
                        Console.WriteLine("Press 'I' to open Inventory.");
                        WoodStick woodstick = new WoodStick();
                        Game.player.inventory.Add(woodstick);
                    }
                    if (commonMap[8, 28] == commonMap[Game.player.playerlocation.x, Game.player.playerlocation.y])
                    {
                        Console.WriteLine("You found a Magnifier.");
                        Console.WriteLine("Press 'I' to open Inventory.");
                        Magnifier magnifier = new Magnifier();
                        Game.player.inventory.Add(magnifier);
                    }
                    break;


            }


            

        }
    }
}
