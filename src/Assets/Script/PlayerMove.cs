using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    //// InputActionAsset�ւ̎Q��
    //[SerializeField] private InputActionReference _moveAction;


    public float playerMove = 0.01f;
    private StartTimer timer;

    public NormalFall normalFall;

    GameObject Player;

    private float UpDown;

    private bool AbuttonDownFlag = false;
    private bool BbuttonDownFlag = false;
    private bool XbuttonDownFlag = false;
    private bool LTriggerDownFlag = false;
    private bool RTriggerDownFlag = false;

    public float PlayerRotate = 0.5f;

    private float moveX;
    private float moveY;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();

        Player = GameObject.Find("Player");
    }

    //private void OnMove(InputValue movement)
    //{
    //    var move = movement.Get<Vector2>();

    //    moveX = move.x;
    //    moveY = move.y;
    //}

    // Update is called once per frame
    void Update()
    {
        //  Player.transform.position = (new Vector3(Mathf.Clamp(Player.transform.position.x, -15f.transform.position.x, 15f.transform.position.x), Player.transform.position.y, Mathf.Clamp(Player.transform.position.z, -6f.transform.position.z, 6f.transform.position.z)));

       // print($"move: {moveX}");

        //�v���C���[���ړ�������
        CharacterController controller = GetComponent<CharacterController>();

        if (timer.CountDownTime <= 0)
        {
            if (normalFall.playerDistance > 0)
            {
                // ���Ɉړ�
                if (Input.GetAxis("Horizontal") == -1 || Input.GetKey(KeyCode.A))
                {
                    transform.Translate(playerMove, 0, 0, Space.World);
                }

                // �E�Ɉړ�
                if (Input.GetAxis("Horizontal") == 1 || Input.GetKey(KeyCode.D))
                {
                    transform.Translate(-playerMove, 0, 0, Space.World);
                }

                // ��Ɉړ�
                if (Input.GetAxis("Vertical") == 1 || Input.GetKey(KeyCode.W))
                {

                    transform.Translate(0, 0, -playerMove, Space.World);
                }

                // ���Ɉړ�
                if (Input.GetAxis("Vertical") == -1 || Input.GetKey(KeyCode.S))
                {
                    transform.Translate(0, 0, playerMove, Space.World);
                }

                //// ���͒l������3���x�N�g�����쐬
                //Vector3 movement = new Vector3(moveX * playerMove, 0.0f, moveY * playerMove);

                //transform.Translate(movement, Space.World);

                //A�{�^�������������̔���
                if (Input.GetButton("Abutton") && AbuttonDownFlag == false)
                {
                    transform.Rotate(0, -90, 0);

                    AbuttonDownFlag = true;
                }

                if (AbuttonDownFlag == true && Input.GetButton("Abutton") == false)
                {
                    AbuttonDownFlag = false;
                }
                //B�{�^�������������̔���
                if (Input.GetButton("Bbutton") && BbuttonDownFlag == false)
                {
                    Debug.Log("Bbutton");

                    BbuttonDownFlag = true;
                }
                if (Input.GetButton("Bbutton") == false && BbuttonDownFlag == true)
                {
                    BbuttonDownFlag = false;
                }

                //X�{�^�������������̔���
                if (Input.GetButton("Xbutton") && XbuttonDownFlag == false)
                {
                    Debug.Log("Xbutton");

                    XbuttonDownFlag = true;
                }

                if (Input.GetButton("Xbutton") == false && XbuttonDownFlag == true)
                {
                    XbuttonDownFlag = false;
                }

                float tri = Input.GetAxis("L_R_Trigger");
                if (tri == -1 && LTriggerDownFlag == false)
                {
                    transform.Rotate(0, -90, 0, Space.World);

                    LTriggerDownFlag = true;
                }
                else if (tri == 1 && RTriggerDownFlag == false)
                {
                    transform.Rotate(0, 90, 0, Space.World);

                    RTriggerDownFlag = true;
                }

                if(LTriggerDownFlag == true && tri != -1)
                {
                    LTriggerDownFlag = false;
                }

                if(RTriggerDownFlag == true && tri != 1)
                {
                    RTriggerDownFlag= false;
                }

                if (Input.GetButton("STARTbutton") || Input.GetButton("BACKbutton"))
                {
                    Debug.Log("START_BACK_button");
                }

            }
        }

    }
}
