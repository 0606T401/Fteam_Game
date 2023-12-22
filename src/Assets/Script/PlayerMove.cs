using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    // InputActionAsset�ւ̎Q��
    [SerializeField] private InputActionReference _moveAction;


    public float playerMove = 0.01f;
    private StartTimer timer;

    public NormalFall normalFall;

    public CountUpTimer CUTimer;
    public CountUpTimer2 CUTimer2;

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

    public bool pauseFlag = false;

    public float beforeTimeS = 1;

    [SerializeField] GameObject FPCamera;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();

        Player = GameObject.Find("Player");
    }


    // �R�[���o�b�N�̓o�^�E����
    private void Awake()
    {
        // ���͒l��0�ȊO�̒l�ɕω������Ƃ��ɌĂяo�����R�[���o�b�N
        _moveAction.action.performed += OnMove;

        // ���͒l��0�ɖ߂����Ƃ��ɌĂяo�����R�[���o�b�N
        _moveAction.action.canceled += OnMove;
    }

    private void OnDestroy()
    {
        _moveAction.action.performed -= OnMove;
        _moveAction.action.canceled -= OnMove;
    }

    // InputAction�̗L�����E������
    private void OnEnable() => _moveAction.action.Enable();
    private void OnDisable() => _moveAction.action.Disable();

    // �R�[���o�b�N�̎���
    private void OnMove(InputAction.CallbackContext context)
    {
        // 2�����͂��󂯎��
        var move = context.ReadValue<Vector2>();

        moveX = -move.x;
        moveY = -move.y;

        // 2�����͂̒l��\��
        print($"move: {move}");
    }


    // Update is called once per frame
    void FixedUpdate()
    {


        //�v���C���[���ړ�������
        CharacterController controller = GetComponent<CharacterController>();

        if (timer.CountDownTime <= 0)
        {
            //if (normalFall.playerDistance > 0)
            //{
            //    // ���Ɉړ�
            //    if (Input.GetAxis("Horizontal") == -1 || Input.GetKey(KeyCode.A))
            //    {
            //        transform.Translate(playerMove, 0, 0, Space.World);
            //    }

            //    // �E�Ɉړ�
            //    if (Input.GetAxis("Horizontal") == 1 || Input.GetKey(KeyCode.D))
            //    {
            //        transform.Translate(-playerMove, 0, 0, Space.World);
            //    }

            //    // ��Ɉړ�
            //    if (Input.GetAxis("Vertical") == 1 || Input.GetKey(KeyCode.W))
            //    {

            //        transform.Translate(0, 0, -playerMove, Space.World);
            //    }

            //    // ���Ɉړ�
            //    if (Input.GetAxis("Vertical") == -1 || Input.GetKey(KeyCode.S))
            //    {
            //        transform.Translate(0, 0, playerMove, Space.World);
            //    }



            if (!CUTimer.end || !CUTimer2.end)
            {
                if (FPCamera.activeSelf == true)
                {
                    if (transform.eulerAngles.y == 180)
                    {
                        transform.Translate(moveX * playerMove, 0, moveY * playerMove, Space.World);
                    }
                    else if (transform.eulerAngles.y == 270)
                    {
                        transform.Translate(moveY * playerMove, 0, -moveX * playerMove, Space.World);
                    }
                    else if (transform.eulerAngles.y == 360 || transform.eulerAngles.y == 0)
                    {
                        transform.Translate(-moveX * playerMove, 0, -moveY * playerMove, Space.World);
                    }
                    else if (transform.eulerAngles.y == 90 || transform.eulerAngles.y == 450)
                    {
                        transform.Translate(-moveY * playerMove, 0, moveX * playerMove, Space.World);
                    }
                }
                else
                    transform.Translate(moveX * playerMove, 0, moveY * playerMove, Space.World);
            }




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

            if (LTriggerDownFlag == true && tri != -1)
            {
                LTriggerDownFlag = false;
            }

            if (RTriggerDownFlag == true && tri != 1)
            {
                RTriggerDownFlag = false;
            }

            if (Input.GetButton("STARTbutton") || Input.GetButton("BACKbutton"))
            {
                Debug.Log("START_BACK_button");
                beforeTimeS = Time.timeScale;
                pauseFlag = true;
            }

        }
    }

}
