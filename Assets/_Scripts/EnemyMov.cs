using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    public int speed;
    private void Start()
    {
    
    }
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
