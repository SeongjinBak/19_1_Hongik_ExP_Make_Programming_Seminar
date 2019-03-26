using System;
using System.Collections.Generic;
using System.Threading;
namespace CsharpPractice
{
    class HW1_3_3
    {
        static void Main(string[] args)
        {
            // 문자열로 "ExP" 저장
            string str = "ExP";

            // "ExP" 의 문자열이 저장되어있는 변수 str의 1번째 원소를 출력
            // 문자열은 0번째 index 부터 시작임. 
            // 따라서 str[0] = 'E', str[1] = 'x', str[2] = 'P' 임.
            Console.WriteLine(str[1]);
        }
    }
}