using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// enum 데이터 선언 후 switch문 사용하기

namespace _011_Operator_Switch2
{
    class Program
    {
        enum DAT_OF_WEEK
        {
            SUN,
            MON,
            THE,
            WED,
            THU,
            FRI,
            SAT,
        }

        static void Main(string[] args)
        {
            DAT_OF_WEEK dayOfWeek = DAT_OF_WEEK.FRI;
            string dayString = "";
            
            switch(dayOfWeek)
            {
                case DAT_OF_WEEK.SUN:
                    dayString = "일";
                    break;
                case DAT_OF_WEEK.MON:
                    dayString = "월";
                    break;
                case DAT_OF_WEEK.THE:
                    dayString = "화";
                    break;
                case DAT_OF_WEEK.WED:
                    dayString = "수";
                    break;
                case DAT_OF_WEEK.THU:
                    dayString = "목";
                    break;
                case DAT_OF_WEEK.FRI:
                    dayString = "금";
                    break;
                case DAT_OF_WEEK.SAT:
                    dayString = "토";
                    break;
            
            }
            Console.WriteLine("{0}요일입니다.", dayString);
        }
    }
}
