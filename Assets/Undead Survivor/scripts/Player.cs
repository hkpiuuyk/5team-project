using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    Rigidbody2D rigid;
    public float Speed;
    SpriteRenderer spriter;
    Animator anim;


    //�ʱ�ȭ
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }


    //�̵� �ڵ�
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * Speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
    }


    // �ִϸ��̼� ��ȭ
    private void LateUpdate()
    {
        anim.SetFloat("Speed", inputVec.magnitude);

        if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;

        }
    }
}
