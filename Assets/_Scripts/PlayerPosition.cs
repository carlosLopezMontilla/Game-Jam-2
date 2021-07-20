using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public Transform[] playerPosition;
    public int positionId;
    public bool[] whereIsThePlayer;
    public string whatToDestroy;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            positionId = 0;
            whatToDestroy = "Red";
            transform.position = playerPosition[positionId].position;
        } 
        if(Input.GetKey(KeyCode.W))
        {
            positionId = 1;
            whatToDestroy = "Green";
            transform.position = playerPosition[positionId].position;
        } if(Input.GetKey(KeyCode.E))
        {
            positionId = 2;
            whatToDestroy = "Yellow";
            transform.position = playerPosition[positionId].position;
        } if(Input.GetKey(KeyCode.R))
        {
            positionId = 3;
            whatToDestroy = "Blue";
            transform.position = playerPosition[positionId].position;
        }
    }
}
