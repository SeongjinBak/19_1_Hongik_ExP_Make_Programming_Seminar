using System;
using System.Collections.Generic;
using System.Threading;
namespace CsharpPractice
{
    class HW1_1_1
    {
        static void Main(string[] args)
        {
            // inch 단위를 입력받음
            int inch = int.Parse(Console.ReadLine());
            
            // 2.54(실수형) 과 inch(정수형)을 곱했을 때 계산결과로는 double이 이미 나오나,
            // 자료형 연습할 겸, 불필요한 (double) 코드로 명시적 형 변환 하였음.
            double cm = (double)((2.54) * inch);
            
            // 예쁘게 출력
            Console.WriteLine(inch + "inch 를 " + cm + "cm 로 변환");
        }
     }
    
}