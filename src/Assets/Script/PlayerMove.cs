using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float playerMove = 0.01f;
    private StartTimer timer;

    public NormalFall normalFall;

    GameObject Player;

    private float UpDown;

    private bool AbuttonDownFlag = false;
    private bool BbuttonDownFlag = false;
    private bool XbuttonDownFlag = false;

    public float PlayerRotate = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<StartTimer>();

        Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //  Player.transform.position = (new Vector3(Mathf.Clamp(Player.transform.position.x, -15f.transform.position.x, 15f.transform.position.x), Player.transform.position.y, Mathf.Clamp(Player.transform.position.z, -6f.transform.position.z, 6f.transform.position.z)));

        //プレイヤーを移動させる
        CharacterController controller = GetComponent<CharacterController>();

        if (timer.CountDownTime <= 0)
        {
            if (normalFall.playerDistance > 0)
            {
                // 左に移動
                if (Input.GetAxis("Horizontal") == -1 || Input.GetKey(KeyCode.A))
                {
                    transform.Translate(playerMove, 0, 0, Space.World);
                }

                // 右に移動
                if (Input.GetAxis("Horizontal") == 1 || Input.GetKey(KeyCode.D))
                {
                    transform.Translate(-playerMove, 0, 0, Space.World);
                }

                // 上に移動
                if (Input.GetAxis("Vertical") == 1 || Input.GetKey(KeyCode.W))
                {

                    transform.Translate(0, 0, -playerMove, Space.World);
                }

                // 下に移動
                if (Input.GetAxis("Vertical") == -1 || Input.GetKey(KeyCode.S))
                {
                    transform.Translate(0, 0, playerMove, Space.World);
                }

                //Aボタンを押した時の判定
                if (Input.GetButton("Abutton") && AbuttonDownFlag == false)
                {
                    transform.Rotate(0, -90, 0);

                    AbuttonDownFlag = true;
                }

                if (AbuttonDownFlag == true && Input.GetButton("Abutton") == false)
                {
                    AbuttonDownFlag = false;
                }
                //Bボタンを押した時の判定
                if (Input.GetButton("Bbutton") && BbuttonDownFlag == false)
                {
                    Debug.Log("Bbutton");

                    BbuttonDownFlag = true;
                }
                if (Input.GetButton("Bbutton") == false && BbuttonDownFlag == true)
                {
                    BbuttonDownFlag = false;
                }

                //Xボタンを押した時の判定
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
                if (tri == -1)
                {
                    transform.Rotate(0, -PlayerRotate, 0, Space.World);
                }
                else if (tri == 1)
                {
                    transform.Rotate(0, PlayerRotate, 0, Space.World);
                }

                if (Input.GetButton("STARTbutton") || Input.GetButton("BACKbutton"))
                {
                    Debug.Log("START_BACK_button");
                }

            }
        }

    }
}
