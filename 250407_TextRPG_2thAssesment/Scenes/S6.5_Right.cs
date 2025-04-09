using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public class S65_Right : Scene
    {
        public bool isFirstEnter = true;
        public override void Enter()
        {
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            Console.WriteLine("Enter the Password.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "FRIEND")
                {
                    Util.Print("Access Granted.", ConsoleColor.Green, 2000);
                    Game.changeScene("Right_Friend");

                    if (isFirstEnter)
                    {
                        Game.player.SetLocation(33, 9);
                        isFirstEnter = false;
                    }
                    break;
                }
                else if (input == "FREAK")
                {
                    Util.Print("Access Granted.", ConsoleColor.Green, 2000);
                    Game.changeScene("Right_Freak");

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
        }


        public override void CustomMapRender(char[,] commonMap)
        {

        }

        public override void Result(ConsoleKey input)
        {

        }

    }
}
