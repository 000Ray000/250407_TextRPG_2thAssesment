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

        // 콘솔 키 입력을 받는 변수
        public ConsoleKey input;

        // 1. 출입 가부여부 확인하기

        public abstract void Enter();


        // 2. 기본맵 그려주기
        public virtual void CommonRender()
        {
            char[,] commonMap =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };
        }

        // 3. 커스텀맵 그려주기 
        public abstract void CustomMapRender();

        // 4. 커스텀 오브젝트 그려주기
        public abstract void CustomObjectRender();

        // 5. 입력받기
        public void Input()
        {
            input = Console.ReadKey(true).Key; 
        }


        // 6. 업데이트 (장면 전환 등)하기
        public abstract void Result(ConsoleKey input);











    }
}
