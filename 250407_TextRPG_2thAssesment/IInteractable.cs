using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    interface IInteractable
    {
        // 게임에서 플레이어가 다양한 물체 앞에서 상호작용 키를 누르면,
        // 키와 그 대상에 따라서 다양한 반응을 하게끔 하기.
        // 상자면 - 밀고 / 오르골은 - 멈추고 
        // 인터페이스는 can 관계에 사용. 
        // 이 셋의 공통점은 플레이어와 상호작용 하는 것.
        // 이 인터페이스를 상속하면, 상호작용할 수 있는 객체라는 것이다.

        //콘솔 키로 플레이어와 상호작용 할 것이므로, 두 가지를 받게끔 넣어주기.

        public void Interact(ConsoleKey key, Player player);

    }
}
