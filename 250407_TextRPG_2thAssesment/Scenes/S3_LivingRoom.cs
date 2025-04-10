using _250407_TextRPG_2thAssesment.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public class S3_LivingRoom : Scene
    {
       public S3_LivingRoom()
        {
            //commonMap 초기화
            commonMap = new char[,]
            {
                       
                //     0   1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30  31  32  33  
               /*0*/ {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','F','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
               /*1*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*2*/ {'#',' ',' ',' ','4',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','6',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*3*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*4*/ {'#',' ',' ',' ',' ','●',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*5*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*6*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*7*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*8*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*9*/ {'L',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','R'},
               /*10*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*11*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','9',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*12*/{'#',' ',' ',' ',' ',' ',' ','7',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','●',' ',' ',' ',' ',' ','#'},
               /*13*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*14*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*15*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*16*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*17*/{'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
        };
        
        }




        public override void Enter()
        {
            // 플레이어 위치 설정
            Game.player.SetLocation(17, 16);
        }

        public override void CustomMapRender(char[,] commonMap)
        {

            // L, R, F는 노란색으로 | 숫자는 까만색으로 | 오브젝트는 초록색으로 출력해주기
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
                    else if (curChar == '4' || curChar == '7' || curChar == '6' || curChar == '9')
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(curChar);
                        Console.ResetColor();
                    }
                    else if (curChar == '●')
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
            Game.player.PlayerRender();

        }

        public override void Result(ConsoleKey input)
        {
            Game.player.Action(input,commonMap);

            char curChar = commonMap[Game.player.playerlocation.y, Game.player.playerlocation.x];

            switch(curChar)
            {
                case 'L':
                    Game.changeScene("Left");
                    break;
                case 'F':
                    bool hasTorch = false;
                    //TODO: 이렇게 안 하면 인벤토리 클래스의 인벤토리일 뿐이고, 한 번 더 붙여야 인벤토리 필드에 접근 가능하다는데 공부 필요.
                    foreach (Object item in Game.player.inventory.inventory)
                    {
                        if (item.name == "Torch")
                        {
                            hasTorch = true;
                            break;
                        }
                    }
                        if (hasTorch)
                        {
                            Game.changeScene("Front_Unlocked");
                        }
                        else
                        {
                            Game.changeScene("Front_Locked");
                        }
                    
                    break;
                case 'R':
                    Game.changeScene("Right");
                    break;
                case '●':
                    if (Game.player.playerlocation.y == 4 && Game.player.playerlocation.x == 5)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found a WoodStick.",ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        WoodStick woodstick = new WoodStick();
                        Game.player.inventory.Add(woodstick);
                        return;
                    }
                    else if (Game.player.playerlocation.y == 12 && Game.player.playerlocation.x == 27)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found a Magnifier.", ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        Magnifier magnifier = new Magnifier();
                        Game.player.inventory.Add(magnifier);
                        return;
                    }
                    break;


            }


            

        }
    }
}
