using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public static class Game
    {
        // 게임의 처음부터 끝까지(static으로) 필요한 정보들 (변수)
        // 1. 게임 오버 변수
        public static bool gameOver;

        // 2. 상황들 (넣을 수 있는 딕셔너리)
        public static Dictionary<String, Scene> sceneDic;

        // 2-1. 현재 씬을 일반화해서 사용할 것이므로 현재 씬 설정
        public static Scene curScene;

        // 3. 플레이어 (클래스)
        public static Player player;

        // 4. 인벤토리 (클래스)
        public static Inventory inventory;


        // 게임에 필요한 기능들 (함수)

        // 1. 시스템 - 초기화하기
        public static void Start()
        {
            // 게임오버 초기화 (false로)
            gameOver = false;
            
            // 플레이어 초기값(위치 포함)
            player = new Player(33, 30);

            // 씬 넣을 딕셔너리 생성, 씬 넣기
            sceneDic = new Dictionary<string, Scene>();

            sceneDic.Add("Intro",new S1_Intro());
            sceneDic.Add("Home", new S2_Home());
            sceneDic.Add("LivingRoom", new S3_LivingRoom());
            sceneDic.Add("Left", new S4_Left());
            sceneDic.Add("Front_Locked", new S5_Front_Locked());
            sceneDic.Add("Front_Unlocked", new S6_Front_Unlocked());
            sceneDic.Add("Right", new S65_Right());
            sceneDic.Add("Right_Freak", new S7_Right_Freak());
            sceneDic.Add("Right_Friend", new S8_Right_Friend());
            sceneDic.Add("HappyEnding", new S9_HappyEnd());
            sceneDic.Add("BadEnding", new S10_BadEnd());


            // 처음 시작할 씬 설정
            curScene = sceneDic["Intro"];

        }

        // 2. 시스템 - 기본 뼈대 반복수행하기
        public static void Run()
        {

            // 게임 초기화하기 
            Start();

            // gameOver가 될 때 까지 반복하는 것. -> 씬 렌더
            while(!gameOver)
            {
                //매회차 씬 렌더 전 콘솔 지워주기
                Console.SetCursorPosition(0, 0);
                Console.Clear();

                curScene.Enter();
                curScene.CommonRender();
                curScene.CustomMapRender(Scene.commonMap);
                curScene.CustomObjectRender();
                curScene.Input();
                curScene.Result(curScene.input);
            }


        }

        // 3. 시스템 - 씬 전환 구현하기
        // 지금 씬을 다른 씬으로 바꾸는 것 = 씬전환

        public static void changeScene(string scenename)
        {
            curScene = sceneDic[scenename];
        }





    }
}
