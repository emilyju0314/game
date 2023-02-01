using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 劇情間player : MonoBehaviour
{
    private float HorizontInput;
    private float VerticalInput;
    private int run;
    private Vector3 startPosition = new Vector3(0, -4, 0);
    private bool ani = false;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        HorizontInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
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
        if (!ani)
            transform.position += new Vector3(HorizontInput * run * Time.deltaTime, VerticalInput * run * Time.deltaTime);
        else if (transform.position.y < 11)
            transform.position += new Vector3(-transform.position.x * Time.deltaTime, Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "door")
            ani = true;
        FixedUpdate();
    }

}
