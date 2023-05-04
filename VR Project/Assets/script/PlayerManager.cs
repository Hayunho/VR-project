using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class PlayerManager : MonoBehaviour
{

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

    //��Ʈ�ѷ��� ���� 
    public void ActivateHaptic()
    {
        xr.SendHapticImpulse(0.7f, 2f);
    }
    
    public void EffectController()
    {

    }
}
