using _250407_TextRPG_2thAssesment.Items;
using _250407_TextRPG_2thAssesment.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    /// <summary>
    /// 자물쇠에 암호 입력.
    /// TODO: 맵이 계속 반복해서 출력되고, 빨간색 X는 처음에만 출력됨. 플레이어의 위치도 원하는대로 초기화되지 않음. 
    /// TODO: 더불어, 플레이어가 맵이 출력되는 동시에 움직일 수 있어야 함. 
    ///오른팔(◆)
    ///오른다리(◆)
    /// </summary>
    public class S7_Right_Freak : Scene
    {

        private char[,] FreakMap;

        public S7_Right_Freak()
        {
            //commonMap 초기화
            FreakMap = new char[,]
            {          
                //     0   1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30  31  32  33  
               /*0*/ {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
               /*1*/ {'#','X','X','X','X','X','X','X','X','X','X',' ','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X','X',' ','X','X','X','#'},
               /*2*/ {'#','X','X','X','X','X','X','X','X','X','X',' ','X','X','X','X','X','X',' ',' ',' ',' ',' ','X','X','X','X','X','X',' ','X','X','X','#'},
               /*3*/ {'#','X',' ','X','X','X','X','X','X',' ',' ',' ',' ',' ','X','X','X','X',' ','X','X','X','X','X','X','X','X',' ',' ',' ','X','X','X','#'},
               /*4*/ {'#',' ',' ',' ',' ',' ',' ','X','X',' ','X','X','X','X','X','X','X','X',' ','X','X','X','X','X','X','X','X',' ','X','X','X','X','X','#'},
               /*5*/ {'#',' ','X',' ','X','X',' ','X','X',' ','X','X','X','X','X','X','X','X',' ','X','X','X','X','X','X','X','X',' ','X','X','X','X','X','#'},
               /*6*/ {'#',' ','X',' ','X','X',' ','X','X',' ','X','X','X','X',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','X','X','X','X','X','#'},
               /*7*/ {'#',' ','X',' ',' ',' ',' ',' ',' ',' ','X','X','X','X',' ','X','X','X','X','X',' ','X','X','X','X',' ','X','X','X','X','X','X','X','#'},
               /*8*/ {' ',' ','X',' ','X','X','X','X','X','X','X','X','X','X',' ','X','X','X','X','X',' ','X','X','X','X',' ','X','X','X','X','X','X','X','#'},
               /*9*/ {'#','X','X',' ','X','X','X','X','X','X','X','X',' ',' ',' ',' ',' ','X','X','X',' ','X','X','X','X',' ','X',' ',' ',' ',' ',' ',' ','#'},
               /*10*/{'#','X','X',' ','X','X','X','X','X','X','X','X',' ','X','X','X',' ','X','X','X',' ',' ',' ','X','X',' ','X',' ','X','X','X','X','X','#'},
               /*11*/{'#','X','X',' ',' ',' ',' ',' ','X','X','X','X',' ','X','X','X',' ','X','X','X',' ','X',' ','X','X',' ','X',' ','X','X','X','X','X','#'},
               /*12*/{'#','X','●',' ','X',' ','X','X','X','X','X','X',' ','X','X','X',' ','X','X','X',' ','X',' ','X','X',' ',' ',' ',' ',' ','X','X','X','#'},
               /*13*/{'#','X','X',' ','X',' ','X','X','X',' ',' ',' ',' ','X','X','X',' ','X','X','X',' ','X',' ','X','X','X','X','X','X',' ','X','X','X','#'},
               /*14*/{'#',' ',' ',' ','X',' ','X','X','X',' ','X','X','X','X',' ',' ',' ','X','X','X',' ',' ',' ','X','X','X','X','X','X',' ','X','X','X','#'},
               /*15*/{'#',' ','X','X','X',' ',' ',' ',' ',' ',' ',' ','X','X','X',' ','X','X','X','X','X','X','X','X','X','X','X','X','X',' ','X','X','X','#'},
               /*16*/{'#','●','X','X','X','X','X','X','X','X','X','X','X','X','X',' ','X','X','X','X','X','X','X','X','X','X','X','X','X',' ','X','X','X','#'},
               /*17*/{'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };

        }



        public override void Enter()
        {

            commonMap = FreakMap;
            Game.player.SetLocation(0, 8);
        }

        public override void CustomMapRender(char [,] FreakMap)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);


            // 오브젝트는 검은색, 몬스터는 빨간색으로 출력해주기
            for (int i = 0; i < FreakMap.GetLength(0); i++)
            {
                for (int j = 0; j < FreakMap.GetLength(1); j++)
                {
                    char curChar = FreakMap[i, j];

                    if (curChar == '●')
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(curChar);
                        Console.ResetColor();
                    }
                    else if (curChar == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
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
            Game.player.PlayerRender();

            Console.SetCursorPosition(0, 20);
            Util.Print("WARNING: MONSTERS",ConsoleColor.Red,0);

        }


            public override void Result(ConsoleKey input)
        {
            Game.player.Action(input, FreakMap);

            char curChar = FreakMap[Game.player.playerlocation.y, Game.player.playerlocation.x];

            switch (curChar)
            {
                case ' ':
                    if (Game.player.playerlocation.y == 8 && Game.player.playerlocation.x == 0)
                    {
                        Game.changeScene("LivingRoom");
                    }
                    break;
                case 'X':
                    Console.SetCursorPosition(0, 20);
                    Util.Print("You Died. Try Agian.", ConsoleColor.White, 2000);
                    Game.changeScene("LivingRoom");
                    break;
                case '●':
                    if (Game.player.playerlocation.y == 16 && Game.player.playerlocation.x == 1)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found a Right Leg.", ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        RightLeg rightleg = new RightLeg();
                        Game.player.inventory.Add(rightleg);
                    }
                    else if (Game.player.playerlocation.y == 12 && Game.player.playerlocation.x == 2)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found a Right Arm.", ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        RightArm rightarm = new RightArm();
                        Game.player.inventory.Add(rightarm);
                    }
                    break;

            }

        }

    }

    
}
