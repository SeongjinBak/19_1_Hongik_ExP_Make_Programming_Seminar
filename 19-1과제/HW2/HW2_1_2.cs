using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2_1_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 태어난 년도 1996으로 가정
        int year = 1996;
        Debug.Log("year = " + year);

        // 태어난 년도를 12로 나눈 나머지가 year에 들어가게 됨
        // year = year % 12와 같은 코드.
        year %= 12;

        // year를 매개로 하는 switch 문.
        switch (year)
        {
            // year 가 0 이라면 원숭이 띠임.
            case 0:
                Debug.Log("원숭이");
                break;
            case 1:
                Debug.Log("닭");
                break;
            case 2:
                Debug.Log("개");
                break;
            case 3:
                Debug.Log("돼지");
                break;
            case 4:
                Debug.Log("쥐");
                break;
            case 5:
                Debug.Log("소");
                break;
            case 6:
                Debug.Log("범");
                break;
            case 7:
                Debug.Log("토끼");
                break;
            case 8:
                Debug.Log("용");
                break;
            case 9:
                Debug.Log("뱀");
                break;
            case 10:
                Debug.Log("말");
                break;
            case 11:
                Debug.Log("양");
                break;
            default:
                break;
        }
    }

   
}
