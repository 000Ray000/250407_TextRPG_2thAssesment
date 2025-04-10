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
    /// 횃불아이템 사용 시 들어갈 수 있다.
    ///드래그 해야 얻을 수 있다.
    ///얻을 수 있는 아이템:
    ///머리(◆)
    ///몸통(◆)
    ///오래된 사진(●)
    ///ㄴ> You were a ______
    ///알파벳을 획득한다.
    ///F / R / E / A / K / I / N / D
    /// </summary>
    public class S6_Front_Unlocked : Scene
    {
        private char[,] FrontUnlockedMap;

        public S6_Front_Unlocked()
        {
            //commonMap 초기화
            FrontUnlockedMap = new char[,]
            {
                       
                //     0   1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30  31  32  33  
               /*0*/ {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
               /*1*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*2*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','●',' ',' ',' ',' ','#'},
               /*3*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*4*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*5*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ','●',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*6*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*7*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*8*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*9*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*10*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*11*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*12*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','●',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*13*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*14*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*15*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*16*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*17*/{'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#',' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };

        }

        public override void Enter()
        {
            // 플레이어 위치 설정
            Game.player.SetLocation(17, 16);
            commonMap = FrontUnlockedMap;
        }


        public override void CustomMapRender(char[,] FrontUnlockedMap)
        {
            Console.SetCursorPosition(0, 0);
            Console.Clear();

            // 오브젝트는 초록색으로 출력해주기
            for (int i = 0; i < FrontUnlockedMap.GetLength(0); i++)
            {
                for (int j = 0; j < FrontUnlockedMap.GetLength(1); j++)
                {
                    char curChar = FrontUnlockedMap[i, j];

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
            Game.player.PlayerRender();



        }

        public override void Result(ConsoleKey input)
        {
            Game.player.Action(input, FrontUnlockedMap);

            char curChar = FrontUnlockedMap[Game.player.playerlocation.y, Game.player.playerlocation.x];

            switch (curChar)
            {
                case ' ':
                    if (Game.player.playerlocation.y == 17 && Game.player.playerlocation.x == 17)
                    {
                        Game.changeScene("LivingRoom");
                    }
                    break;
                case '●':
                    if (Game.player.playerlocation.y == 5 && Game.player.playerlocation.x == 9)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found a Head.", ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        Head head = new Head();
                        Game.player.inventory.Add(head);
                    }
                    else if (Game.player.playerlocation.y == 2 && Game.player.playerlocation.x == 28)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found a Torso.", ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        Torso torso = new Torso();
                        Game.player.inventory.Add(torso);
                    }
                    else if (Game.player.playerlocation.y == 12 && Game.player.playerlocation.x == 24)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found an Old Photo.", ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        OldPhoto oldphoto = new OldPhoto();
                        Game.player.inventory.Add(oldphoto);
                    }
                    break;

            }
        }
    }
}
