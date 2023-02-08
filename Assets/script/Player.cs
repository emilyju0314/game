using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float HorizontInput;
    private float VerticalInput;
    private int run;
    private Vector3 startPosition = new Vector3(-15, 0, 0);
    public static Vector3 outPos;//�X�ж��ɯ��b���e

    Animator anime;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(outPos);
        if (outPos == new Vector3())
            transform.position = startPosition;
        else
            transform.position = outPos;


        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        anime.SetFloat("x", HorizontInput);//�P�wplayer�b�]��V

        if (HorizontInput == 0)
            anime.SetBool("x0", true);//�P�wplayer�¦V
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


    }

    void FixedUpdate()
    {
        transform.position += new Vector3(HorizontInput * run * Time.deltaTime, VerticalInput * run * Time.deltaTime);

    }


}
