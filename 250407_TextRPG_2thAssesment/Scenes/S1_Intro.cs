using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    /// <summary>
    /// 인트로 메시지 출력
    /// He will find his kin at last.
    /// press A for start
    /// </summary>

    public class S1_Intro : Scene
    {
        public override void Enter()
        {

        }

        public override void CommonRender()
        {
            char[] introchar = { 'H', 'e', ' ', 'w', 'i', 'l', 'l', ' ', 'f', 'i', 'n', 'd', ' ', 
                                 'h', 'i', 's', ' ', 'k', 'i', 'n', ' ', 'a', 't', ' ', 'l','a','s','t','.'};

            for (int i = 0; i < introchar.Length; i++)
            {
                Console.Write(introchar[i]);
                // Thread.Sleep(600);
            }

            Util.Print(" \n \n \n \n \n \n ", ConsoleColor.Black, 1000);

            Util.Print("Press Spacebar to Start.", ConsoleColor.White, 1000);
            Console.SetCursorPosition(0, 0);

        }

        public override void CustomMapRender()
        {
            
        }

        public override void CustomObjectRender()
        {

        }

        public override void Result(ConsoleKey input)
        {
           switch (input)
            {
                case ConsoleKey.Spacebar:
                    Game.changeScene("Home");
                    break;
                default:
                    Console.WriteLine(" \n \n ");
                    break;
            }

        }
    }
}
