﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public abstract class Scene
    {
        // 씬에 필요한 기능
        // 1. 출입 가부여부 확인하고 
        // 2. 기본맵을 그려주고 (공통)
        // 3. 커스텀맵을 그려주고
        // 4. 커스텀 오브젝트를 그려주고
        // 5. 입력을 받고 (공통)
        // 6. 장면을 전환한다.

        // 1. 콘솔 키 입력을 받는 변수
        public ConsoleKey input;

        // 2. 기본 맵 변수

            public char[,] commonMap = 
            {
                 //     0   1   2   3   4   5   6   7   8   9  10  11  12  13  14  15  16  17  18  19  20  21  22  23  24  25  26  27  28  29  30  31  32  33  
               /*0*/ {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
               /*1*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*2*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*3*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*4*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*5*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*6*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*7*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*8*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*9*/ {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*10*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*11*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*12*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*13*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*14*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*15*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*16*/{'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
               /*17*/{'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };

       

        // 1. 출입 가부여부 확인하기

        public virtual void Enter() { }


      // 2. 기본맵 그려주기
      public virtual void CommonRender()
      {
      
          for (int i = 0; i <commonMap.GetLength(0); i++)
          {
              for (int j = 0; j < commonMap.GetLength(1); j++)
              {
                  Console.Write(commonMap[i, j]);
              }
      
              Console.WriteLine();
          }
      
      
      }
      


        // 3. 커스텀맵 그려주기 
        public virtual void CustomMapRender(char[,] commonMap) { }


        // 4. 입력받기
        public void Input()
        {
            input = Console.ReadKey(true).Key; 
        }


        // 6. 업데이트 (장면 전환 등)하기
        public abstract void Result(ConsoleKey input);











    }
}
