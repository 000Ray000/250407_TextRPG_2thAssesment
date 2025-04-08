using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public class Player : IInteractable
    {
        // 플레이어가 가지는 기본 정보 (변수)

        // 1. 위치
        // Location 구조체에서 받아오기
        public Location playerlocation;

        // 2. 인벤토리를 가짐 
        public Inventory inventory;

        // 생성자 만들기
        public Player(int x, int y)
        {
            inventory = new Inventory();
            playerlocation.x = x;
            playerlocation.y = y;
        }



        // 플레이어가 가지는 기본 기능 (함수)

        // 1. 맵에 출력되기 
        public void PlayerRender()
        {
            Console.SetCursorPosition(playerlocation.x, playerlocation.y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("P");
            Console.ResetColor();

        }


        // 2. 움직이기 
        public void Action(ConsoleKey input)
        {
            Location targetLocation = playerlocation;
            
            switch(input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    targetLocation.y--;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    targetLocation.y++;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    targetLocation.x--;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    targetLocation.x++;
                    break;
                case ConsoleKey.I:
                    inventory.Open();
                    break;
            }

            playerlocation = targetLocation;
            // if (targetLocation == ) ;


        }


        // 2. 오브젝트와 상호작용 -
        // Interactable 인터페이스 받아오기 
        // TODO: 소코반 확인하기 
        public void Interact(ConsoleKey Key, Player player)
        {

        }



    }
}
