using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100; 
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        if (this.mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        } else
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
    }

}

public class Test : MonoBehaviour
{
    void Start ()
    {
        int[] array = { 5, 10, 15, 20, 25 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }

        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);
        
        for(int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }

    void Update ()
    {

    }
}