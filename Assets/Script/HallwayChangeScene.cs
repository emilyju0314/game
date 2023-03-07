using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayChangeScene : MonoBehaviour
{
    public GameObject player;
    public float hallwayLengh;

    // Start is called before the first frame update
    void Start()
    {
        hallwayLengh = GetComponent<BoxCollider2D>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //if(player.transform.position.x > hallwayLengh)
        //{
        //    Debug.Log("change scene");
        //}
    }
}
