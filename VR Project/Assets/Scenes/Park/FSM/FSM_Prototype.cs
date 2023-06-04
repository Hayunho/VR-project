using MonsterLove.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

//using Unity.EditorCoroutines;

public class FSM_Prototype : MonoBehaviour
{
    
    public GameObject GameManager;
    public GameObject uiManager;

    public UnityEvent Init_Start;
    public UnityEvent Init_End;
    public UnityEvent Prepare;
    public UnityEvent Grab_Sword;
    public UnityEvent Tutorial_Start;
    public UnityEvent Start_Start;
    public UnityEvent Start_End1;
    public UnityEvent Start_End2;

    public enum States
    {
        Start_Scene,
        Main_Scene,
        Forset_Scene,
        Polar_Scene,
        End_Scene,
        Init,
        Tutorial,
        Start,
        End
    }

    IEnumerator Create_Sword()
    {
        yield return new WaitForSeconds(3f);
        //���� ���� �� �� �������� ����Ʈ 
        //�� ���� ����
        //��Ʈ�ѷ� ���� ����
        Prepare.Invoke();
        //fsm.ChangeState(States.Tutorial);
    }

    IEnumerator Hide_8_9_Scene_UI()
    {
        //2�� ���
        yield return new WaitForSeconds(2f);

        //������ �� ����
        //��Ʈ�ѷ� ���� ����
        Start_End2.Invoke();
        
    }

    StateMachine<States> fsm;
  

    private void Awake()
    {
        DontDestroyOnLoad(this);
        fsm = StateMachine<States>.Initialize(this);
        
        fsm.ChangeState(States.Init);
        
    }

    private void Start_Scene_Enter()
    {
        SceneManager.LoadScene(0);
    }


    private void Start_Scene_Update()
    {
        Debug.Log(1);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(1);
            SceneManager.LoadScene(1);
            fsm.ChangeState(States.Init);
        }
    }

    private void Init_Enter()
    {
        
        Debug.Log("Init");
        //��Ʈ�ѷ� ���� �� ���� 
        Init_Start.Invoke();
        StartCoroutine(Create_Sword());
        //Init_End.Invoke();
        
    }

    private void Init_Update()
    {
        
        //����ڰ� �˰� ��ȣ�ۿ��� ���
        if (GameManager.GetComponent<GameManager>().isGrabSword == true)
        {
            //����Ǿ�� �ϴ� �Լ�
            //�˿� ���� �� ����Ʈ
            Grab_Sword.Invoke();
            fsm.ChangeState(States.Tutorial);
        }
        
    }

    private void Tutorial_Enter()
    {
        Debug.Log("Tutorial");
        //���� ����
        //���� �ı��϶�� �ڸ� ����
        Tutorial_Start.Invoke();
    }

    private void Tutorial_Update() 
    {
        
        //ù ������ �ı��� ���
        if (GameManager.GetComponent<GameManager>().isOzoneBroke == true)
        {
            fsm.ChangeState(States.Start);
        }
        
    }

    private void Start_Enter()
    {
        Debug.Log("Start");
        //���� �ı� ������ UI ����
        //�ʿ��� �� ���� �����ϴ� ������Ʈ Ȱ��ȭ ��ų �� ���� (coroutin Ȱ���Ͽ� ���� �ֱ� ����� ����)

        //slider value 0���� �ʱ�ȭ
        uiManager.GetComponent<UIManager>().gauge.value = 0;
        Start_Start.Invoke();
    }

    private void Start_Update()
    {
        //Debug.Log(uiManager.GetComponent<UIManager>().IsFullGauge());

        //�������� �� ä�����ٸ�
        if (uiManager.GetComponent<UIManager>().IsFullGauge() == true)
        {
            /*
            uiManager.GetComponent<UIManager>().ChangeSubtitle("mission clear");
            uiManager.GetComponent<UIManager>().ShowSubtitle();
            */

            Start_End1.Invoke();
            StartCoroutine(Hide_8_9_Scene_UI());
            fsm.ChangeState(States.End);
        }
        
    }

    private void End_Update()
    {
        //�����̴��� �ڸ��� ��� ��Ȱ��ȭ�� ������ ��
        if(!uiManager.GetComponent<UIManager>().gauge.IsActive() && !uiManager.GetComponent<UIManager>().subtitle.IsActive())
        {

        }
    }
}
