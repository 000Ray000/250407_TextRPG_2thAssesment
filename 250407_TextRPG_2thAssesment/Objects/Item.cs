using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public abstract class Item : Object
    {
        // 필요한 정보들 (변수)
        public bool isused;

        // 필요한 기능들 (함수)

        // 1. 렌더되는 형태

        // 2. 상호작용 함수 (결국 이 방식으로는 구현하지 않음)

        // 3. 사용형태 (결국 이 방식으로는 구현하지 않음)

        // 4. 사용여부
        public void SetStatus(bool used)
        {
            this.isused = used;
        }
    }
}
