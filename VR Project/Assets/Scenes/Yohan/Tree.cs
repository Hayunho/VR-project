using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField]
    private float changeStartTime = 2f;

    private float timer = 0f;
    private bool timerFlag = false;

    void Update()
    {
        if (timerFlag == false)
        {
            if (timer > changeStartTime)
            {
                ColorChange();

                timerFlag = true;
            }
            timer += Time.deltaTime;
        }
    }

    private void ColorChange()
    {
        //TODO:���� �� ����ó��
        Debug.Log("���� �� ����!");
    }
}
