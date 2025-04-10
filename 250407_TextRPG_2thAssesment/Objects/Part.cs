using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public class Part : Object
    {

        // 필요한 정보들 (변수)
        public bool isused;

        // 필요한 기능들 (함수)

        // 1. 렌더되는 형태

        // 2. 사용 여부
        public void SetStatus(bool used)
        {
            this.isused = used;
        }
    }
}
