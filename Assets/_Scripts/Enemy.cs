using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform[] enemyPosition;
    public GameObject[] enemyPrefabs;
    public float enemySpeed;
    public float initialTime, timeToEnd;
    public string[] tagsId;
    public int idToSpawn;
    public AudioController audioController;
    public float musicDuration;
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
        idToSpawn = (int)Random.Range(0, enemyPrefabs.Length);
        GameObject enemySpawned = Instantiate(enemyPrefabs[idToSpawn], enemyPosition[idToSpawn].position, Quaternion.identity);
        enemySpawned.tag = tagsId[idToSpawn];
    }
}
