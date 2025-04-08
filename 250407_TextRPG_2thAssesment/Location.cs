using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public struct Location
    {
        // 위치 저장 기본 변수
        public int x;
        public int y;

        // 위치 생성 시 설정
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
