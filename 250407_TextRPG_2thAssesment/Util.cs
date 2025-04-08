using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public class Util
    {
        // 게임 메인에 들어가진 않지만 게임 전체에 있으면 좋은 기능.

        // 1. 텍스트 출력 옵션 (문구, 색, 지연시간)
        public static void Print(string context, ConsoleColor textColor, int delay)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }

    }
}
