using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    /// <summary>
    /// (몬스터에게 죽으면)
    /// there has be something you missed.
    /// </summary>
    public class S10_BadEnd : Scene
    {
        public override void CustomMapRender(char[,] commonMap)
        {
            Util.Print("there has be something you missed.", ConsoleColor.White, 1500);
            Util.Print(" \n \n \n \n \n \n ", ConsoleColor.Black, 3000);

        }

        public override void Result(ConsoleKey input)
        {
            Console.WriteLine("Press spacebar to Restart.");
            switch (input)
            {
                case ConsoleKey.Spacebar:
                    Game.changeScene("LivingRoom");
                    break;
                default:
                    break;
            }
        }

    }
}
