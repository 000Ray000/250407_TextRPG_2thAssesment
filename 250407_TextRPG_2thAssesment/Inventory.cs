using _250407_TextRPG_2thAssesment.Items;
using _250407_TextRPG_2thAssesment.Objects_Instances;
using _250407_TextRPG_2thAssesment.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public class Inventory
    {

        // 인벤토리가 가지는 기본 정보 (변수)

        // 1. 구조 - 리스트로 선언 
        public List<Object> inventory; 

        // 2. UI - 스택으로 표시
        public Stack<string> stack; 

        // 3. UI - 선택아이템 인덱스 확인
        public int selectint;

        //TODO: 이게 없으면 LivingRoom에서 사용 시에 오류가 생기는데, 추후 공부 필요.(초기화되는건 알겠는데 왜 이런식으로 되어야 하는지?)
        public Inventory()
        {
            inventory = new List<Object>();
        }

        // 인벤토리가 가지는 기본 기능 (함수)

        // 1. UI 출력 (인벤토리 창 출력)
        public void Open()
        {
            Console.SetCursorPosition(0, 0);
            Console.Clear();

            Console.WriteLine("╔⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶✞⊷⊷⊷⊷⊷⊶⊶⊶⊷⊷⊷⊷⊷╗");
            Console.WriteLine();
            if (inventory.Count == 0)
            {
                Console.WriteLine(" Inventory is Empty. ");
            }
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, inventory[i].name);
            }
            Console.WriteLine();
            Console.WriteLine("╚⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶⊶✞⊷⊷⊶⊶⊶⊶⊶⊶⊶⊶⊷⊷⊷╝");
            Console.WriteLine();
            Console.WriteLine("Press D to see the description.");
            Console.WriteLine("Press C to Combine the items.");
        }

        // 2. 아이템 추가하기 
        public void Add(Object item)
        {
            inventory.Add(item);
        }

        // 3. 아이템 삭제하기 
        public void Remove(Object item)
        {
            inventory.Remove(item);
        }

        // 4. 파츠 다 모았는지 확인하기(검색으로 확인)
        public bool PartsCheck()
        {
            // 필요한 파츠의 타입 리스트
            Type[] requiredParts = new Type[]
            {
                typeof(Head),
                typeof(Heart),
                typeof(Torso),
                typeof(LeftArm),
                typeof(RightArm),
                typeof(LeftLeg),
                typeof(RightLeg),
                typeof(ThreadAndNeedle)
            };

            // 인벤토리에서 각 파츠 타입이 모두 존재하는지 확인
            // TODO: 추후 공부 필요한 코드.
            return requiredParts.All(partType => inventory.Any(item => item.GetType() == partType));
        }
        
        // 5. 아이템 디테일 확인하기 
        // TODO: 아이템 디테일 확인하기 구현하기 & 플레이어 Action에도 넣어주기 


        // 6. 아이템 조합하기
        public void ItemCombine(Object item1, Object item2, Part part1, Part part2, Part part3, Part part4, Part part5, Part part6, Part part7, Part part8)
        {

            if ((item1.name == "Candle" && item2.name == "WoodStick") || (item1.name == "WoodStick" && item2.name == "Candle"))
            {
                Torch torch = new Torch();
                inventory.Add(torch);
                inventory.Remove(item1);
                inventory.Remove(item2);

            }
            if ((item1.name == "Old Photo" && item2.name == "Magnifier") || (item1.name == "Magnifier" && item2.name == "Old Photo"))
            {
                Letters letters = new Letters();
                inventory.Add(letters);
                inventory.Remove(item1);
                inventory.Remove(item2);
            }
            if (this.PartsCheck() == true)
            {
                Console.WriteLine("It's done.");
                inventory.RemoveAll(item => item is Part);
                Game.changeScene("HappyEnd");
            }


        }


        

    }
}
