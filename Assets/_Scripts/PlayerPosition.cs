using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public Transform[] playerPosition;
    public int positionId;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            positionId = 0;
            transform.position = playerPosition[positionId].position;
        } 
        if(Input.GetKey(KeyCode.W))
        {
            positionId = 1;
            transform.position = playerPosition[positionId].position;
        } if(Input.GetKey(KeyCode.E))
        {
            positionId = 2;
            transform.position = playerPosition[positionId].position;
        } if(Input.GetKey(KeyCode.R))
        {
            positionId = 3;
            transform.position = playerPosition[positionId].position;
        }
    }

    
}
