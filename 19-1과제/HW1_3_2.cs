using System;
using System.Collections.Generic;
using System.Threading;
namespace CsharpPractice
{
    class HW1_3_2
    {
        static void Main(string[] args)
        {
            // 문자열로 "홍익대학교" 저장
            string str = "홍익대학교";

            // "홍익대학교"가 저장되어 있는 문자열에 
            // + 연산자를 사용하여 "홍익대학교 ExP" 문자열을 저장
            // str += " ExP"; 와 같은 코드임
            str = str + " ExP";

            Console.WriteLine(str);

        }
    }
}