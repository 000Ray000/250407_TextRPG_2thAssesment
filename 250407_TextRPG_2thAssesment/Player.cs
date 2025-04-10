using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public class Player 
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

        // 2. 위치 설정하기
        public void SetLocation(int x, int y)
        {
            playerlocation.x = x;
            playerlocation.y = y;
        }


        // 3. 움직이기 
        public void Action(ConsoleKey input, char[,] map)
        {
            Console.SetCursorPosition(playerlocation.x, playerlocation.y);
            Location targetlocation = playerlocation;
            
                switch (input)
                {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    targetlocation.y--;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    targetlocation.y++;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    targetlocation.x--;
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    targetlocation.x++;
                    break;
                case ConsoleKey.I:
                    inventory.Open();
                    return;
                }

            // 맵이 null이 아닌 경우에만 경계와 장애물 확인
            if (map != null)
            {
                int mapWidth = map.GetLength(0);  
                int mapHeight = map.GetLength(1); 

                // 움직이려는 위치가 벽인지 확인
                if (map[targetlocation.y, targetlocation.x] == '#')
                {
                    return; // 장애물이 있으면 이동 X
                }
            }

             // 콘솔 창의 범위를 벗어나지 않도록 위치 제한
             int maxWidth = Console.WindowWidth - 1; // 콘솔 창의 최대 너비
             int maxHeight = Console.WindowHeight - 1; // 콘솔 창의 최대 높이
            
             if (targetlocation.x >= 0 && targetlocation.x <= maxWidth &&
              targetlocation.y >= 0 && targetlocation.y <= maxHeight)
             {
                 playerlocation = targetlocation;
              }

            
        }

        public void InventoryAction(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.C:
                    Console.WriteLine("please select the first item's number.");
                    if (int.TryParse(Console.ReadLine(), out int itemindex1))
                    {
                        Console.WriteLine("Please select the second item's number");
                        if (int.TryParse(Console.ReadLine(), out int itemindex2))
                        {
                            if (itemindex1 >= 0 && itemindex1 < inventory.inventory.Count &&
                                itemindex2 >= 0 && itemindex2 < inventory.inventory.Count)
                            {
                                inventory.ItemCombine(inventory.inventory[itemindex1], inventory.inventory[itemindex2]);
                            }
                            else
                            {
                                Console.WriteLine("Invaild item number. please try again.");
                            }
                        }
                    }
                    inventory.Open();
                    break;

                case ConsoleKey.D:
                    Console.WriteLine("please select the item's number.");
                    if (int.TryParse(Console.ReadLine(), out int itemindex3))
                    {
                        if (itemindex3 >= 0 && itemindex3 < inventory.inventory.Count)
                        {
                            inventory.ItemDetail(inventory.inventory[itemindex3]);
                        }
                        else
                        {
                            Console.WriteLine("Invaild item number. please try again.");
                        }
                    }
                    inventory.Open();
                    break;
                case ConsoleKey.H:
                    inventory.Isdone();
                    break;
                case ConsoleKey.Spacebar:
                    Game.changeScene("LivingRoom");
                    break;
            }
        }

    }
}
