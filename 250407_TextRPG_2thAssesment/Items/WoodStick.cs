using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment.Items
{
    public class WoodStick : Item
    {
        public WoodStick()
        {
            // Object 클래스에서 상속받은 name,details, isused 필드에 값 설정.
            // 상속받은 값들은 자식 클래스에서 생성자 안에서 할당해주면 된다.
            name = "Wood Stick";
            details = "It’s a sturdy wooden stick, easy to grip.";
            isused = false;
        }
    }
}
