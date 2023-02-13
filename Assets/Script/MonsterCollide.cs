using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCollide : MonoBehaviour
{
    private float MonsterGoBack = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision) //避免怪物碰不到牆壁的問題
    {
        if (collision.collider.tag == "Player")
        {
            transform.Translate(Vector2.left * MonsterGoBack);
        }
    }
    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player")
    //    {
    //        transform.Translate(Vector2.left * MonsterGoBack);
    //    }
    //}

}
