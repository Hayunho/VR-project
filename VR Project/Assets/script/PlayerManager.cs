using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class PlayerManager : MonoBehaviour
{

    //Scene �̵� �� ������Ʈ �ı� X
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private XRController xr;

    //Scene ���� �� Player Controller ����
    void Start()
    {
        xr = (XRController)GameObject.FindObjectOfType(typeof(XRController));
    }

    //��Ʈ�ѷ��� ���� 
    void ActivateHaptic()
    {
        xr.SendHapticImpulse(0.7f, 2f);
    }

    void EffectController()
    {

    }
}
