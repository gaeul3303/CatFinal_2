using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public DialogueController DlgControl;
    // 회전 속도 
    public float rotSpeed = 200f;
    //
    public float moveSpeed = 7f;
    public float rotateSpeed = 7.0f;
    // 캐릭터 컨트롤러 변수 
    CharacterController cc;
    // 중력 변수 
    float gravity = -20;
    // 수직 속력 변수 
    float yVelocity = 0;

    float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;


    // Start is called before the first frame update
    void Start()
    {
        // 캐릭터 컨트롤러 변수 받아옴 
        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        float h = DlgControl.isAction ? 0 : Input.GetAxis("Horizontal");
        float v = DlgControl.isAction ? 0 : Input.GetAxis("Vertical");

        
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;
        
        // 카메라 기준으로 방향 변경
        dir = Camera.main.transform.TransformDirection(dir);

        // 플레이어 방향 설정 수정사항 
        if (dir.magnitude >= 0.1f)
        {
            // 회전 값 계산 
            float Targetangle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            // 카메라 기준으로 플레이어 방향 변경  
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, Targetangle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }

        // 캐릭터 수직 속도에 중력 값 적용 
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        // 이동 속도 맞춰 이동 
        cc.Move(dir * moveSpeed * Time.deltaTime);
        cc.transform.LookAt(cc.transform);



    }
    void OnCollisionStay(Collision collision)
    {
        if (Input.GetButtonDown("Jump"))
            DlgControl.Action(collision.gameObject);
    }
}