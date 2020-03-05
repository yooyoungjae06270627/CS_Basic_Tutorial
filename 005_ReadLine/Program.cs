using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Console.ReadLine()
// -한 번에 한 줄씩 반드시 문자열(String)로 입력 받음
namespace _005_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수를 입력하세요?");
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);   
            // Parse(String) 숫자의 문자열 표현을 해당하는 32비트 부호 있는 정수로 변환합니다.
            Console.WriteLine("입력한 수는: " + num);
        }
    }
}
