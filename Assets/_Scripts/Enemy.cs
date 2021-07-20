using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform[] enemyPosition;
    public int positionId;
    public GameObject[] enemyPrefabs;
    public float enemySpeed;
    public float initialTime, timeToEnd;
    // Start is called before the first frame update
    void Start()
    {
        timeToEnd = initialTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeToEnd -= Time.deltaTime;

        if (timeToEnd <= 0)
        {
            SpawnObject();
            timeToEnd = initialTime;
        }
    }

    void SpawnObject()
    {
        int idToSpawn = (int)Random.Range(0, enemyPosition.Length);
        GameObject enemySpawned = Instantiate(enemyPrefabs[idToSpawn], enemyPosition[idToSpawn].position, Quaternion.identity);
    }
}
