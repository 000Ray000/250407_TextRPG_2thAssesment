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

        // 인벤토리가 가지는 기본 기능 (함수)

        // 1. UI 출력 (인벤토리 창 출력)
        public void Open()
        {

        }

        // 2. 아이템 추가하기 
        public void Add(Object item)
        {
            inventory.Add(item);
        }


        // 3. 아이템 조합하기
        public void Combine(Object item1, Object item2)
        {

        }

    }
}
