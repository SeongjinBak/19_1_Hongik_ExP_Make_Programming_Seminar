using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2_2_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1부터 10까지 합 출력
        int sum = 0;

        for(int i = 1; i <= 10; i++)
        {
            sum = sum + i;
        }

        Debug.Log(sum);
    }
    
}
