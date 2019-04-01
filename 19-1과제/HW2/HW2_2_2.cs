using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2_2_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // n번째 단 입력
        int n;

        // 2번째 단을 입력받았다고 가정함.
        n = 2;

        // 1~9까지 반복문 돈다.
        for (int i = 1; i < 10; i++)
        {
            Debug.Log(n + " * " + i + " = " + n * i);
        }
    }

    
}
