using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabSword : MonoBehaviour
{
    //���߿� �� ������ ����� ��Ʈ�ѷ����� �� ����
    public GameObject Sword_Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Click");
        Sword_Prefab.SetActive(true);
    }
}
