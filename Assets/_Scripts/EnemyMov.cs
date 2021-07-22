using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    public float speed, backSpeed;
    public float totalTime;
    public float timeToEnd;
    public bool buttonPressed;
    public GameObject discoLight;
    public Transform spawnPoint;
    public int uses = 1;
    public KeyCode keyCode;

    void Start()
    {
        totalTime = 10f;
        backSpeed = 4f;
        timeToEnd = totalTime;
        buttonPressed = false;
       
    }
    void Update()
    {
        if (Input.GetKey(keyCode))
        {
            buttonPressed = true;
        }
        if (buttonPressed)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            discoLight.SetActive(false);
            timeToEnd -= Time.deltaTime;
            if (timeToEnd <= 0)
            {
                buttonPressed = false;
                timeToEnd = totalTime;
            }
            if (Input.GetKeyUp(keyCode))
            {
                buttonPressed = false;
                discoLight.SetActive(false);
                
            }
        }
        else
        {
            transform.position += Vector3.left * backSpeed * Time.deltaTime;
        }
    }
}
