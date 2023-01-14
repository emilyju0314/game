using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float HorizontInput;
    float VerticalInput;
    Rigidbody2D Rig;
    int run;


    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();
        run = 1;
    }

    // Update is called once per frame
    void Update()
    {
        HorizontInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = 2;
            Debug.Log("2");
        }
        else
        {
            run = 1;
        }
        
            
    }

    void FixedUpdate()
    {
        //Physics.OverlapSphere(ground.position, 0.01f, LM).Length == 5 &&
        Rig.velocity = new Vector2(HorizontInput * 2.5f * run, Rig.velocity.y) ;
        Rig.velocity = new Vector2(Rig.velocity.x, VerticalInput * 2.5f * run) ;

    }


}
