using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{
    private float monsterSpeed = 9.0f;
    private Vector3 startPosition = new Vector3(-25, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(monsterSpeed * Time.deltaTime, 0, 0);
    }
}
