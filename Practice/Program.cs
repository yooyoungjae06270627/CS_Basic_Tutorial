﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 삼항 연산자 

class Program
{
    static void Main()
    {
        int num = 0;
        bool result;

        result = (num == 0) ? true : false;
        Console.WriteLine("num: {0}", num);
        Console.WriteLine("(num == 0) ? true : false : {0}", result);

        result = (num > 10) ? true : false;
        Console.WriteLine("(num > 10) ? true : false : {0}", result);
    }
}



