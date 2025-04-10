using _250407_TextRPG_2thAssesment.Items;
using _250407_TextRPG_2thAssesment.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public class S4_Left : Scene
    {
        private char[,] leftMap;

        public S4_Left()
        {
            //commonMap 초기화
            leftMap = new char[,]
            {
                       
                //     0   1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30  31  32  33  
               /*0*/ {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
               /*1*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*2*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ','#'},
               /*3*/ {'#',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*4*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*5*/ {'#',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*6*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ','#'},
               /*7*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*8*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*9*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
               /*10*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*11*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ','#'},
               /*12*/{'#',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*13*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*14*/{'#',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','■',' ',' ','#'},
               /*15*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*16*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*17*/{'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };

        }




        public bool isFirstEnter = true;
        public override void Enter()
        {
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            Console.WriteLine("Enter the Password.");

            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int inputPassword) && inputPassword == 4769)
                {
                    Util.Print("Access Granted.", ConsoleColor.Green, 2000);
                    CustomMapRender(leftMap);
                    
                   if (isFirstEnter)
                   {
                        Game.player.SetLocation(33, 9);
                        isFirstEnter = false;
                   }
                   break;

                    
                }
                else
                {
                    Console.WriteLine("Incorrect password. Please try again.");
                }
            }
            commonMap = leftMap;
        }



        public override void CustomMapRender(char[,] leftmap)
        {

            Console.SetCursorPosition(0, 0);
            Console.Clear();

            for (int i = 0; i < leftMap.GetLength(0); i++)
            {
                for (int j = 0; j < leftMap.GetLength(1); j++)
                {
                    char curChar = leftMap[i, j];

                    if (curChar == '■')
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
            // 추후, 플레이어가 상자를 밀면 동그라미가 드러나는 식으로 구현해볼 것.
            Game.player.Action(input, commonMap);

            char curChar = leftMap[Game.player.playerlocation.y, Game.player.playerlocation.x];

            switch (curChar)
            {
                case ' ':
                    if (Game.player.playerlocation.y == 9 && Game.player.playerlocation.x == 33)
                    {
                        Game.changeScene("LivingRoom");
                    }
                    break;
                case '■':
                    if (Game.player.playerlocation.y == 5 && Game.player.playerlocation.x == 8)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found a Candle.", ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        Candle candle = new Candle();
                        Game.player.inventory.Add(candle);
                    }
                    else if (Game.player.playerlocation.y == 14 && Game.player.playerlocation.x == 9)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found a Left Arm.", ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        LeftArm leftarm = new LeftArm();
                        Game.player.inventory.Add(leftarm);
                    }
                    else if (Game.player.playerlocation.y == 11 && Game.player.playerlocation.x == 26)
                    {
                        Console.SetCursorPosition(0, 20);
                        Util.Print("You found a Left Leg.", ConsoleColor.White, 1000);
                        Console.WriteLine();
                        Util.Print("Press 'I' to open Inventory.", ConsoleColor.White, 1500);
                        LeftLeg leftleg = new LeftLeg();
                        Game.player.inventory.Add(leftleg);
                    }
                    break;


            }






        }

    }
}
