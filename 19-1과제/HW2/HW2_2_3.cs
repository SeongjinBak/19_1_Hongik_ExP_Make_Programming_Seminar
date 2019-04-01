using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2_2_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // a 는 몇번째 단 을 정함
        for (int a = 2; a < 10; a++)
        {
            // b는 a단의 몇 을 정함.
            for (int b = 1; b < 10; b++)
            {
                // ex) 3 * 6 = 18 의 경우 a = 3, b = 6.
                Debug.Log(a + " * " + b + " = " + a * b);
            }
        }
    }

    
}
