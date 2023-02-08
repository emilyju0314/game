using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMonster : MonoBehaviour
{
    public GameObject monster;
    public Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = GameObject.Find("door").transform.position;
        Invoke("CreateMons", 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateMons()
    {
        Instantiate(monster, startPos,this.transform.rotation);
    }
}
