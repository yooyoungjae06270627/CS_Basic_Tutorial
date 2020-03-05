using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 비트 연산자

// 쓰는 이유: 메모리의 효율성이 올라간다. 빠르게, 최적화 
// 게임 : 그래픽 연산 처리 / 토글 방식의 옵션 값들 

namespace _001_Operator_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;     // 0000 0000    0000 0000    0000 0000    0000 1111
            int b = 22;     // 0000 0000    0000 0000    0000 0000    0001 0110

            int c = a & b;  // 0000 0000    0000 0000    0000 0000    0000 0110  -> 6
            Console.WriteLine("a & b: " + c);


                            // 0000 0000    0000 0000    0000 0000    0000 1111
                            // 0000 0000    0000 0000    0000 0000    0001 0110
            int d = a | b;  // 0000 0000    0000 0000    0000 0000    0001 1111 -> 31
            Console.WriteLine("a | b: " + d);


                            // 0000 0000    0000 0000    0000 0000    0000 1111
                            // 0000 0000    0000 0000    0000 0000    0001 0110
            int e = a ^ b;  // 0000 0000    0000 0000    0000 0000    0001 1001 -> 25
            Console.WriteLine("a ^ b: " + e);


                             // 0000 0000    0000 0000    0000 0000    0000 1111 -> 15
            int f = a << 2;  // 0000 0000    0000 0000    0000 0000    0011 1100 -> 15 x 2 x 2 = 60
            Console.WriteLine("a << 2: " + f);
            Console.WriteLine("a << 1: " + (a<<1));      // 30 왼쪽으로 1시프트 하면 2배로 증가 (곱셈 연산)

                              // 0000 0000    0000 0000   0000 0000   0001 0100 -> 20
            int g = 20 >> 2;  // 0000 0000    0000 0000   0000 0000   0000 1010 -> 20 / 2 / 2 = 5
            Console.WriteLine("20 >> 2: " + g);
            Console.WriteLine("(20 >> 1): " + (20 >> 1)); // 20 / 2 : 오른쪽 1시프트 하면 2로 나눔 (나눗셈 연산)

                              // 0000 0000    0000 0000   0000 0000   0001 0110 -> 22
            int h = ~b;       // 1111 1111    1111 1111   1111 1111   1110 1001 -> -23
            Console.WriteLine("h = ~b: " + h);

            int i = ~b + 1;   // 2의 보수 
            Console.WriteLine("i = ~b+1: " + i);


            // 비트로 출력하기
            //int a = 15;     // 0000 0000    0000 0000    0000 0000    0000 1111
            //int b = 22;     // 0000 0000    0000 0000    0000 0000    0001 0110

            string s = Convert.ToString(a, 2).PadLeft(32, '0');
            Console.WriteLine("s: " + s);
            s = Convert.ToString(b, 2).PadLeft(32, '0');
            Console.WriteLine("s: " + s);
        }
    }
}
