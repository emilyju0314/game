using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{

    public GameObject monster;
    public GameObject life;
    public int Hp = 3;
    public bool gameover;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerStay2D(Collider2D collision)
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Monster")
        {
            HpManagement(-1);
        }
    }

    void HpManagement(int hp)
    {
        Hp += hp;
        if (Hp == 0)
        {
            Debug.Log("game over");
            gameover = true;
        }
        if (Hp <= 0)
        {
            Hp = 0;
            gameover = true;
        }
        life.transform.localScale = new Vector3(Hp, life.transform.localScale.y, life.transform.localScale.z);
    }
}
