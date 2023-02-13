using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float HorizontInput;
    private float VerticalInput;
    private int run;
    private Vector3 startPosition = new Vector3(-15, 0, 0);
    Animator anime;
    private PlayerLife PlayerLifeSC;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
        anime = GetComponent<Animator>();
        PlayerLifeSC = GameObject.Find("player").GetComponent<PlayerLife>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        if (!PlayerLifeSC.gameover)
        {
            anime.SetFloat("x", HorizontInput);//判定player奔跑方向
        }

        if (HorizontInput == 0)
            anime.SetBool("x0", true);//判定player朝向
        else
            anime.SetBool("x0", false);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = 12;
        }
        else
        {
            run = 10;
        }
        if (!PlayerLifeSC.gameover)
        {
            //player 移動
            transform.position += new Vector3(HorizontInput * run * Time.deltaTime, VerticalInput * run * Time.deltaTime);
        }

    }



}
