using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("background");
    }
    private void FixedUpdate()
    {
    }

    public void startClick()
    {
        background.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
        GameObject.Find("起始文字").GetComponent<Text>().enabled = true;
        Debug.Log("可以");
        GameObject.Find("exit").GetComponent<Button>().enabled = false;
        GameObject.Find("start").GetComponent<Button>().enabled = false;
        Invoke("changeScene", 2);
       // changeScene();
    }
    public void exitClick()
    {
        Debug.Log("肯定");
        Application.Quit();
    }
    void changeScene()
    {
        SceneManager.LoadScene("走廊");
    }
}
