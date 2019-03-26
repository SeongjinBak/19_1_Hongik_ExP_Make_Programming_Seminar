using System;
using System.Collections.Generic;
using System.Threading;
namespace CsharpPractice
{
    class HW1_3_1
    {
        static void Main(string[] args)
        {
            // 문자를 하나 입력받음
            char text = char.Parse(Console.ReadLine());

            // 입력받은 문자를 아스키 코드로 변환.
            // 문자는 기본적으로 '정수' 임을 1주차 스터디 ppt에서 공부함.
            // 따라서 입력받은 문자를 int 로 형 변환 하면 됨.
            Console.WriteLine("아스키 코드 변환 : " + (int)text);
            
        }
    }
}