using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    public float speed, backSpeed;
    public float totalTime;
    public float timeToEnd;
    public bool buttonPressed;

    void Start()
    {
        totalTime = 10f;
        backSpeed = 4f;
        totalTime = timeToEnd;
        buttonPressed = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            buttonPressed = true;
        }
        if(buttonPressed)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * backSpeed * Time.deltaTime;
        }
    }
}
