using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{
    private float monsterSpeed = 9.0f;
    public Vector3 startPosition;//在unity設置，所有房間共用同個script
    private Vector3 playerPos;
    private PlayerLife playerLifeSc;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
        playerLifeSc = GameObject.Find("player").GetComponent<PlayerLife>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerLifeSc.gameover)
        {
            playerPos = GameObject.FindWithTag("Player").transform.position;
            Vector3 nor=Vector3.Normalize(new Vector3((playerPos.x - transform.position.x), (playerPos.y - transform.position.y)));
            //將相差距離設為標準向量
            transform.position += new Vector3(monsterSpeed * Time.deltaTime * nor.x, monsterSpeed * Time.deltaTime * nor.y, 0);
        }
    }
}
