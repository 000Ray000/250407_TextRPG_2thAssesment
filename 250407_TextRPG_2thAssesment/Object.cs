using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public abstract class Object
    {
        // 게임 내 오브젝트들이 공통으로 가지는 변수 

        // 1. 이름 
        public string name;
        // 2. 상세 조회 시 디테일한 설명 
        public string details;

        // 3. 맵에서의 출력 형태
        // 색, 심볼, 위치, 쓰였는지 여부

        // 생성자 (색, 심볼, 위치)


    }
}
