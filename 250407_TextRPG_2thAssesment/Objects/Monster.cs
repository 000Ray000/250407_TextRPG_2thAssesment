using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public class Monster : Object, IInteractable
    {
        // 필요한 정보들 (변수)
        // 1. 몬스터의 위치 (추후 생성 위치 결정해줘야 해서)
        public Location monsterlocation;

        // 생성자 만들기
        public Monster(int x, int y)
        {
            monsterlocation.x = x;
            monsterlocation.y = y;
        }

        // 필요한 기능들 (함수)



        // 1. 렌더되는 형태


        // 2. 상호작용 함수
        public void Interact(ConsoleKey Key)
        {

        }

        // 3. 생성패턴 
        // TODO: 추후 구체적인 구현 확인 필요 

    }
}
