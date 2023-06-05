using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.Events;
using System;

public class PlayerManager : MonoBehaviour
{
    public UnityEvent Test;
    private XRController left_Controller;
    private XRController right_Controller;

    public GameObject Player;

    //Scene �̵� �� ������Ʈ �ı� X
    private void Awake()
    {
        left_Controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[0];
        right_Controller = (XRController)GameObject.FindObjectsOfType(typeof(XRController))[1];
        DontDestroyOnLoad(this);
    }

    //Scene ���� �� Player Controller ����
    void Start()
    {

    }

    private void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.Space)) {
            Test.Invoke();
        }
        */
    }

    //��Ʈ�ѷ��� ���� 
    public void ActivateHaptic()
    {
        //Debug.Log("Haptic");
        left_Controller.SendHapticImpulse(0.7f, 2f);
        right_Controller.SendHapticImpulse(0.7f, 2f);
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

    public void FallPlayer()
    {
        Player.AddComponent<Rigidbody>();
    }
}
