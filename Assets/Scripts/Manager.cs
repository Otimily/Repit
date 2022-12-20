using UnityEngine;

public class Manager : MonoBehaviour
{
    void Start()
    {
        // �ݺ��� ����

        // 1. �ﰢ�� �����
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

        // 2. ���ﰢ�� �����
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

        // �Ƕ�̵� �����

        for (int i = 0; i < 4; i++)
        {
            string pyramid = "";

            for (int j = 0; j < 3 - i; j++)
            {
                pyramid += "��";
            }

            for (int j = 0; j < (i * 2) + 1; j++)
            {
                pyramid += "��";
            }

            Debug.Log(pyramid);

        }

        Debug.Log("===========================");

        // ���Ƕ�̵� �����
        // ���Ƕ�̵��� ������ ������ 3���� ��� ��������.
        // ������ �������� ���̰� �ʿ��ϴ�.
        // ����ġ�� ��������.

        for (int i = 0; i < 4; i++)
        {
            string pyramid = "";

            for (int j = 0; j < i; j++)
            {
                pyramid += "��";
            }

            for (int j = 0; j < 7 - (i * 2); j++)
            {
                pyramid += "��";
            }

            Debug.Log(pyramid);

        }
        Debug.Log("===========================");

        BuildPyramid(5);

        Debug.Log("===========================");

        BuildReversePyramid(3);
    }

    void BuildPyramid(int floor)
    {
        // �Է��� floor�� ���缭 �Ƕ�̵� ����
        // �Է��� floor��� ���� �ٴ��� ������ �°� �Ƕ�̵带 ������� ���ΰ�?
        // �� �����Ⱑ floor�� �ǰ� �ؾ��Ѵٴ� ���ΰ�?
        // �� ���� �Է��ϴ��Ŀ� ���� �����ǰ� �ϱ�

        for (int i = 0; i < floor; i++)
        {
            string pyramid = "";
            for (int x = 0; x < (floor - 1) - i; x++)
            {
                pyramid += "��";
            }
            for (int x = 0; x < (i * 2); x++)
            {
                pyramid += "��";
            }
            Debug.Log(pyramid);
        }
    }

    void BuildReversePyramid(int floor)
    {

        for (int i = 0; i < floor; i++)
        {
            string pyramid = "";
            for (int x = 0; x < i; x++)
            {
                pyramid += "��";
            }
            for (int x = 0; x < (floor * 2 -1) - (i * 2); x++)
            {
                pyramid += "��";
            }
            Debug.Log(pyramid);
        }
    }

}