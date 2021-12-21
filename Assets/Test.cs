using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    
    //関数の定義
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage+"のダメージを受けた");

        this.hp -= damage;
    }

    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;

            Debug.Log("魔法攻撃をした。残りのMPは" + this.mp + "です。");
        }

        else
        {
            Debug.Log("Mpが足りないため魔法が使えません。");
        }
    }

}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //クラス内からの関数呼び出し
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
