using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    
    //�֐��̒�`
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage+"�̃_���[�W���󂯂�");

        this.hp -= damage;
    }

    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;

            Debug.Log("���@�U���������B�c���MP��" + this.mp + "�ł��B");
        }

        else
        {
            Debug.Log("Mp������Ȃ����ߖ��@���g���܂���B");
        }
    }

}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //�N���X������̊֐��Ăяo��
        lastboss.Attack();
        lastboss.Defence(3);

        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
