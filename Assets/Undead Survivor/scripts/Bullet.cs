
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;    //���ط� ����
    public int per;         //���� ����

    //���� �ʱ�ȭ �Լ�
    public void Init(float damage, int per)
    {
        this.damage = damage;
        this.per = per;
    }
}
