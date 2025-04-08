using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    /// <summary>
    /// 큰 방이 보인다.
    /// 움직이려고 하면 어두워서 움직일 수 없다고 함.
    /// </summary>
    public class S5_Front_Locked : Scene
    {


        public override void CustomMapRender(char[,] commonMap)
        {
            Console.WriteLine("It's too dark to move.");
       
        }

        public override void Result(ConsoleKey input)
        {
            while (true)
            {

            }
        }

    }
}
