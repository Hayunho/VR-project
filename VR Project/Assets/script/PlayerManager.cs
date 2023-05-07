using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.Events;

public class PlayerManager : MonoBehaviour
{
    public UnityEvent Test;
    private XRController xr;

    //Scene �̵� �� ������Ʈ �ı� X
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    //Scene ���� �� Player Controller ����
    void Start()
    {
        xr = (XRController)GameObject.FindObjectOfType(typeof(XRController));
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Test.Invoke();
        }
    }

    //��Ʈ�ѷ��� ���� 
    public void ActivateHaptic()
    {
        xr.SendHapticImpulse(0.7f, 2f);
    }
    
    //��Ʈ�ѷ��� Red ����Ʈ
    public void EffectController(string color)
    {

        Debug.Log(color);
        switch (color)
        {
            case "red":
                break;
            case "yellow":
                break;
            case "green":
                break;

        }
    }
}
