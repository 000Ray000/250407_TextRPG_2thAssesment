using System.Runtime.InteropServices;
using System.Text;

namespace _250407_TextRPG_2thAssesment
{
    internal class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetConsoleOutputCP(uint wCodePageID);

        static void Main(string[] args)
        {
            // 콘솔 출력 인코딩을 UTF-8로 설정
            Console.OutputEncoding = Encoding.UTF8;

            // 콘솔 코드 페이지를 65001 (UTF-8)로 설정
            SetConsoleOutputCP(65001);

            // 콘솔 사이즈를 더 크게 설정.
            Console.SetBufferSize(500, 500);

            // 게임을 실행하기
            Game.Run();
        }
    }
}
