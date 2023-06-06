using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public UnityEvent Test;
    private XRController xr;

    IEnumerator Vibrate()
    {
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Quaternion quaterninon = Quaternion.identity;

        int cnt = 0;

        quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z + 10);

        //20�� ���� �ݺ�
        while (cnt<20)
        {
            quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z - 20);
            Player.transform.rotation =  quaterninon;
            yield return new WaitForSeconds(0.01f);
            quaterninon.eulerAngles = new Vector3(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z - 20);
            Player.transform.rotation = quaterninon;
            yield return new WaitForSeconds(0.01f);
            cnt++;
        }
        
        
    }

    //Scene �̵� �� ������Ʈ �ı� X
    private void Awake()
    {
        xr = (XRController)GameObject.FindObjectOfType(typeof(XRController));
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
        xr.SendHapticImpulse(0.7f, 2f);
    }
    
    //�÷��̾� ����
    public void VibratePlayer()
    {
        
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
