using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// boxing, unboxing 기초 (boxing 하는 과정에서 heap 영역에 메모리가 할당)
// 최적화에 굉장히 좋지 않다. 
namespace _004_DataBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;      //boxing
            int j = (int)o; //unboxing
            i = 456;

            Console.WriteLine("i: {0},  o: {1},  j:  {2}", i, o, j);
            Console.WriteLine("ReferenceEquals: {0}", Object.ReferenceEquals(i, o));
        }
    }
}
