using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    /// <summary>
    /// " 비밀번호를 입력해 주세요" 
    ///(텍스트 상자 그리기)
    ///비밀번호(4769) 입력 시 입장 가능
    ///상자가 여기저기 놓여있고, 상자를 밀어야 얻을 수 있다.
    ///
    ///얻을 수 있는 아이템:
    ///촛불(●)
    ///왼팔(◆)
    ///왼다리(◆)
    /// </summary>
    public class S4_Left : Scene
    {
        public override void Enter()
        {
            Console.WriteLine("Enter the Password.");

            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int inputPassword) && inputPassword == 4769)
                {
                    Console.WriteLine("Access Granted.");
                    CommonRender();
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
            // 상자 배치하기 

            // 플레이어 그려주기
        }

        public override void Result(ConsoleKey input)
        {

        }

    }
}
