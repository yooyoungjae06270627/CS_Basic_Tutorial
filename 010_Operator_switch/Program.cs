﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Operator_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string strGrade = null;

            Console.Write("점수를 입력하세요: ");
            num = int.Parse(Console.ReadLine());

            switch(num /10)
            {
                case 10:   // if((num/10) == 9 || (num/10) == 10)
                case 9:
                    strGrade = "A";
                    break;
                case 8:
                    strGrade = "B";
                    break;
                case 7:
                    strGrade = "C";
                    break;
                case 6:
                    strGrade = "D";
                    break;
                default:
                    strGrade = "F";
                    break;
            }
            Console.WriteLine("결과값은 = {0}", strGrade);
        }
    }
}
