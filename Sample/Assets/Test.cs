using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    void Start()
    {
        Vector2 PlayerPos = new Vector2(0.0f, 0.0f);
    

    int[] points = new int[5];

        for(int i= 0; i <  5; i++) {
            PlayerPos.x += 2.0f;
            Debug.Log(PlayerPos);
        }
    }
}