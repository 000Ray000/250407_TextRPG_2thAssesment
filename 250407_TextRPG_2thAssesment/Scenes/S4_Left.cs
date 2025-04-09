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
    ///상자가 여기저기 놓여있고, 상자를 밀면 다른 글자가 나오게 하기
    ///
    ///얻을 수 있는 아이템:
    ///촛불
    ///왼팔
    ///왼다리
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
            // 오브젝트 (상자) 배치하기 
            commonMap[3, 4] = commonMap[8, 5] = commonMap[15, 3] = commonMap[22, 4] = commonMap[29, 4] = commonMap[3, 9] = commonMap[11, 9] = commonMap[21, 8] = commonMap[26, 11] = commonMap[9, 13] = commonMap[19, 13] = commonMap[30, 13] = commonMap[3, 14] = commonMap[9, 14] = '■';


            // 상자는 초록색으로 출력해주기
            for (int i = 0; i < commonMap.GetLength(0); i++)
            {
                for (int j = 0; j < commonMap.GetLength(1); j++)
                {
                    char curChar = commonMap[i, j];

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
            Game.player.SetLocation(20, 10);
            Game.player.PlayerRender();
        }

        public override void Result(ConsoleKey input)
        {
            // 플레이어가 상자를 밀면, 특정 위치에서는 상자를 민 자리에서 동그라미가 남는다.
            // 플레이어 이동 함수를 생각해보자. 
        }

    }
}
