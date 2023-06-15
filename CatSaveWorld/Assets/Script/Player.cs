using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DialogueController DlgControl;
    // 회전 속도 
    public float rotSpeed = 200f;
    // 회전 값 변수 
    float mx = 0;
    //
    public float moveSpeed = 7f;
    public float rotateSpeed = 7.0f;
    // 캐릭터 컨트롤러 변수 
    CharacterController cc;
    // 중력 변수 
    float gravity = -20;
    // 수직 속력 변수 
    float yVelocity = 0;


    // Start is called before the first frame update
    void Start()
    {
        // 캐릭터 컨트롤러 변수 받아옴 
        cc = GetComponent<CharacterController>();

    }
   
    // Update is called once per frame
    void Update()
    {

        //마우스 입력 받기 
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        // 회전값 변수에 마우스 입력 값 만큼 누적 
        mx += mouse_X * rotSpeed * Time.deltaTime;

        float h = DlgControl.isAction ? 0 : Input.GetAxis("Horizontal");
        float v = DlgControl.isAction ? 0 : Input.GetAxis("Vertical");

        //
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotateSpeed);
        //transform.LookAt(this.transform);
        //if(h>0)
        //{
        //    transform.rotation = Quaternion.Euler(new Vector3(0f,0f , 0f));
        //}
        //else if(h<0)
        //{
        //    transform.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));

        //}
        //else if(v>0)
        //{
        //    transform.rotation = Quaternion.Euler(new Vector3(0f, 270f, 0f));

        //}
        //else if(v<0)
        //{
        //    transform.rotation = Quaternion.Euler(new Vector3(0f, 90f, 0f));

        //}
        // 카메라 기준으로 방향 변경
        dir = Camera.main.transform.TransformDirection(dir);


        //h = DlgControl.isAction ? 0 : Input.GetAxis("Horizontal");        // ??????
        //v = DlgControl.isAction ? 0 : Input.GetAxis("Vertical");          // ??????

        // 캐릭터 수직 속도에 중력 값 적용 
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        // 이동 속도 맞춰 이동 
        cc.Move(dir * moveSpeed * Time.deltaTime);
        //cc.transform.LookAt(cc.transform);

    }
    void OnCollisionStay(Collision collision)
    {
        if (Input.GetButtonDown("Jump"))
            DlgControl.Action(collision.gameObject);
    }
}
