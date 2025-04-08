using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment
{
    public abstract class Object : IInteractable
    {
        // 게임 내 오브젝트들이 공통으로 가지는 변수 

        // 1. 이름 
        // 2. 상세 조회 시 디테일한 설명 
        protected struct BasicInfo()
        {

        }

        // 3. 맵에서의 출력 형태
        // 색, 심볼, 위치, 쓰였는지 여부

        // 생성자 (색, 심볼, 위치, 쓰였는지)

        public GameObject()
        {

        }


        // 게임 내 오브젝트들이 공통으로 가지는 함수

        // 1. 맵에 그려지기 
        public void ObjectRender()
        {

        }

        // 2. 플레이어 및 오브젝트와 상호작용 -
        // Interactable 인터페이스 받아오기 
        public void Interact(ConsoleKey Key)
        {
            
        }


    }
}
