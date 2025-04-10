using _250407_TextRPG_2thAssesment.Items;
using _250407_TextRPG_2thAssesment.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{

    public class S8_Right_Friend : Scene
    {
        private char[,] FriendMap;

        public S8_Right_Friend()
        {
            //commonMap 초기화
            FriendMap = new char[,]
            {
                       
                //     0   1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30  31  32  33  
               /*0*/ {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
               /*1*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*2*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*3*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*4*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*5*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*6*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*7*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','♪',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*8*/ {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*9*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*10*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*11*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*12*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*13*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*14*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*15*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*16*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','●','#'},
               /*17*/{'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };

        }

        public bool isFirstEnter = true;
        public override void Enter()
        {
            if (isFirstEnter)
            {
                Game.player.SetLocation(0, 8);
                isFirstEnter = false;
            }

            commonMap = FriendMap;

        }


        public override void CustomMapRender(char[,] FriendMap)
        {
            Console.SetCursorPosition(0, 0);
            Console.Clear();

            // 오브젝트는 초록색으로 | 오르골은 분홍색으로 출력해주기
            for (int i = 0; i < FriendMap.GetLength(0); i++)
            {
                for (int j = 0; j < FriendMap.GetLength(1); j++)
                {
                    char curChar = FriendMap[i, j];

                    if (curChar == '●')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(curChar);
                        Console.ResetColor();
                    }
                    else if (curChar == '♪')
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
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

            Console.SetCursorPosition(0, 20);
            Util.Print("♩  ♪  ♩   ♬   ♪   ♬ ....", ConsoleColor.DarkGray,0);

        }


        public override void Result(ConsoleKey input)
        {
            Game.player.Action(input, FriendMap);

            char curChar = FriendMap[Game.player.playerlocation.y, Game.player.playerlocation.x];

            switch (curChar)
            {
                case ' ':
                    if (Game.player.playerlocation.y == 8 && Game.player.playerlocation.x == 0)
                    {
                        Game.changeScene("LivingRoom");
                    }
                    break;
                case '●':
                    Console.SetCursorPosition(0, 22);
                    Util.Print("You found a Note.", ConsoleColor.White, 1000);
                    Console.WriteLine();
                    Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                    Note note = new Note();
                    Game.player.inventory.Add(note);
                    break;
                case '♪':
                    Console.SetCursorPosition(0, 22);
                    Util.Print("You found a Thread and Needle.", ConsoleColor.White, 1000);
                    Util.Print("And at last... You found a HEART.", ConsoleColor.White, 1500);
                    Console.WriteLine();
                    Console.WriteLine();
                    Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                    ThreadAndNeedle threadandneedle = new ThreadAndNeedle();
                    Heart HEART = new Heart();
                    Game.player.inventory.Add(threadandneedle);
                    Game.player.inventory.Add(HEART);
                    break;

            }

        }

    }

}
