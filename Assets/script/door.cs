using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public string sceneName;
    public static bool out1 = true;//�P�_�O���O�i���Y 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (out1 == false)
                out1 = true;
            else
            {
                Player.outPos = GameObject.FindWithTag("Player").transform.position - new Vector3(1, 0, 0);//�x�s������e����m
                Debug.Log(GameObject.FindWithTag("Player").transform.position);
                out1 = false;
            }


            SceneManager.LoadScene(sceneName);
        }
    }
}
