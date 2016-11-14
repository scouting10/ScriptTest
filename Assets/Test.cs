using UnityEngine;
using System.Collections;


public class Boss
{
    public int hp = 100;
    private int power = 25;
    public int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    //Lesson4発展課題：Magic関数
    public void Magic()
    {
        this.mp -= 5;
        if (this.mp > 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }else{
            this.mp += 5;
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }
        
}



public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Lesson4課題array宣言
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = new int[5];
        array2[0] = 10;
        array2[1] = 20;
        array2[2] = 30;
        array2[3] = 40;
        array2[4] = 50;

       //失敗１．引き算の演算子がおかしいのか？for文の条件で引き算は使えないのか？
       /*for (int i = 5; i > 0; i -) { }
            Debug.Log(array2[i]);
        }
        */
        
       
        for(int i = 0; i < 5; i++) {
             Debug.Log(array2[4 - i]);
        }
        
        Boss lastboss = new Boss();
        lastboss.Attack();

      //勝手にやりました。なぜかこの部分が2周します。
      /*for (int i = 0; i < 10; i++)
        {
            lastboss.Defence(30);
            Debug.Log(lastboss.hp);
            if (lastboss.hp < 0)
            {
                Debug.Log("Bossを倒した！！");
                return;
            }
        }*/


        //発展課題
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }

        Debug.Log("10回処理後、もう一度Magic関数を呼び出す");
        lastboss.Magic();


    }






    // Update is called once per frameC:\Users\user\Documents\Script test\Assets\Test.cs
    void Update()
    {

    }
}
