using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 무한 반복
// 점프문 (break, continue,goto)
// -무한루프 제어
// -break     
// -continue

namespace _013_Operator_while_true_
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int inputNum = 0;
        //    while (true) // for(;;)
        //    {
        //        Console.WriteLine("(1)구구단 중 몇단? (2)나가기(0번 입력)");
        //        inputNum = int.Parse(Console.ReadLine());

        //        if (inputNum == 0)
        //        {
        //            Console.WriteLine("종료 합니다.");
        //            break;
        //        }

        //        for(int i = 1; i<10; ++i)
        //        {
        //            Console.WriteLine("{0} X {1} = {2}", inputNum, i, (inputNum * i));
        //        }
        //    }
        //}
        static void Main(string[] args)
        {
            int total = 0;
            for(int i =0; i<10;++i)
            {
                if(i==5)
                {
                    Console.WriteLine();
                    continue;
                    //Console.WriteLine("i: " + i); -> 실행이 안된다.
                }

                Console.WriteLine("i: " + i);
            }

            for(int i=0; i<10; ++i)
            {
                if(i%2 ==1)
                {
                    continue;
                }

                total += i;
            }

            Console.WriteLine("total: " + total);
        }
    }
}
