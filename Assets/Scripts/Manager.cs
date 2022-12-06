using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    void Start()
    {
        // 반복문 제어

        // 1. 삼각형 만들기
        // 0
        // 00
        // 000
        // 0000
        // 00000


        // for
        // 1 Debug.Log("0");
        // 2
        // 3
        // 4
        // 5


        for (int i = 1; i <= 5; i++)
        {
            string pyramid = "";

            for (int x = 0; x < i; x++)
            {
                pyramid += "0";
            }

            Debug.Log(pyramid);
        }

        Debug.Log("===========================");

        // 2. 역삼각형 만들기
        // 00000
        // 0000
        // 000
        // 00
        // 0


        // for
        // 5 Debug.Log("00000");
        // 4
        // 3
        // 2
        // 1


        for (int i = 5; i >= 1; i--)
        {
            string pyramid = "";

            for (int x = 0; x < i; x++)
            {
                pyramid += "0";
            }

            Debug.Log(pyramid);
        }


        Debug.Log("===========================");

        // 피라미드 만들기

        for (int i = 0; i < 4; i++)
        {
            string pyramid = "";

            for (int j = 0; j < 3 - i; j++)
            {
                pyramid += "　";
            }

            for (int j = 0; j < (i * 2) + 1; j++)
            {
                pyramid += "ㅇ";
            }

            Debug.Log(pyramid);

        }

        Debug.Log("===========================");

        // 역피라미드 만들기
        // 역피라미드의 마지막 개수가 3개로 계속 떨어졌다.
        // 무엇이 원인인지 종이가 필요하다.
        // 스케치북 가져오자.

        for (int i = 0; i < 4; i++)
        {
            string pyramid = "";

            for (int j = 0; j < i; j++)
            {
                pyramid += "　";
            }

            for (int j = 0; j < 7 - (i * 2); j++)
            {
                pyramid += "ㅇ";
            }

            Debug.Log(pyramid);

        }

    }

    void BuildPyramid(int floor)
    {

    }
}