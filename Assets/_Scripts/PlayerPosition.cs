using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public Transform[] playerPosition;
    public int positionId;
    public bool[] whereIsThePlayer;
    public string whatToDestroy;
    public KeyCode keyCode1, keyCode2, keyCode3, keyCode4;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(keyCode1))
        {
            positionId = 0;
            whatToDestroy = "Red";
            transform.position = playerPosition[positionId].position;
        } 
        if(Input.GetKey(keyCode2))
        {
            positionId = 1;
            whatToDestroy = "Green";
            transform.position = playerPosition[positionId].position;
        } if(Input.GetKey(keyCode3))
        {
            positionId = 2;
            whatToDestroy = "Yellow";
            transform.position = playerPosition[positionId].position;
        } if(Input.GetKey(keyCode4))
        {
            positionId = 3;
            whatToDestroy = "Blue";
            transform.position = playerPosition[positionId].position;
        }
    }
}
