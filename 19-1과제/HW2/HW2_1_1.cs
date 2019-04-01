using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2_1_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 현재 월이 주어졌을 때 계절을 출력하는 코드를 작성하라.
        
        // 현재 month는 7로 주어졌다고 가정,
        int month = 7;

        // month가 3이상 5이하 일경우 : 봄
        if(month >= 3 && month <= 5)
        {
            Debug.Log("봄");
        }
        // month가 6이상 8이하 일경우 : 여름
        else if (month >= 6 && month <= 8)
        {
            Debug.Log("여름");
        }
        // month가 9이상 11이하 일경우 : 가을
        else if (month >= 9 && month <= 11)
        {
            Debug.Log("가을");
        }
        // 4계절 중 봄, 여름, 가을을 빼면 무조건 겨울 이다.
        else
        {
            Debug.Log("겨울");
        }

        // 혹은 다음과 같이 코드를 작성해도 됩니다.

        // month가 3이상 5이하 일경우 : 봄
        if (month >= 3 && month <= 5)
        {
            Debug.Log("봄");
        }
        else
        {
            // month가 6이상 8이하 일경우 : 여름
            if (month >= 6 && month <= 8)
            {
               // Debug.Log("여름");
            }
            else
            {
                // month가 9이상 11이하 일경우 : 가을
                if (month >= 9 && month <= 11)
                {
                    Debug.Log("가을");
                }
                // 4계절 중 봄, 여름, 가을을 빼면 무조건 겨울 이다.
                else
                {
                    Debug.Log("겨울");
                }
            }
        }
    }

}
