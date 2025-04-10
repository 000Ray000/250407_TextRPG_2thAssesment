using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    /// <summary>
    /// He found his kin by himself.
    /// He is not alone anymore.
    /// </summary>
    public class S9_HappyEnd : Scene
    {

        public override void CustomMapRender(char[,] commonMap)
        {
            Util.Print("He found his kin by himself.", ConsoleColor.White, 2000);
            Util.Print(" \n \n \n \n \n \n ", ConsoleColor.Black, 2000);
            Util.Print("He is not alone anymore.", ConsoleColor.White, 2000);
            Util.Print(" \n \n \n \n \n \n ", ConsoleColor.Black, 2000);
            Util.Print("                                                                                                                                                           \r\n                                                                                                                                   ___   ___               \r\n    //   / /     //   ) )     // | |     /|    / /     //   / /     //   / /     /|    / /     //   ) )  /__  ___/     //   / /       / /        /|    / / \r\n   //___        //___/ /     //__| |    //|   / /     //__ / /     //____       //|   / /     ((           / /        //____         / /        //|   / /  \r\n  / ___        / ___ (      / ___  |   // |  / /     //__  /      / ____       // |  / /        \\\\        / /        / ____         / /        // |  / /   \r\n //           //   | |     //    | |  //  | / /     //   \\ \\     //           //  | / /           ) )    / /        //             / /        //  | / /    \r\n//           //    | |    //     | | //   |/ /     //     \\ \\   //____/ /    //   |/ /     ((___ / /    / /        //____/ /    __/ /___     //   |/ /     \r\n", ConsoleColor.DarkCyan, 3000);

        }

        public override void Result(ConsoleKey input)
        {
            Console.WriteLine("Press spacebar to Restart.");
            switch (input)
            {
                case ConsoleKey.Spacebar:
                    Game.changeScene("Intro");
                    break;
                default:
                    break;
            }
        }

    }
}
