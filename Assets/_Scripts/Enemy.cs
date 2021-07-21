using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public int numbersOfEnemies;
    public bool canChangeScene;
    // Start is called before the first frame update
    void Start()
    {
        canChangeScene = false;
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
        if(numbersOfEnemies <= 0)
        {
            canChangeScene = true;
        }
        if(canChangeScene && SceneManager.GetActiveScene().name != "Scene7")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            canChangeScene = false;
        }

    }
    
    void SpawnObject()
    {
        if(numbersOfEnemies >= 0)
        {
            idToSpawn = (int)Random.Range(0, enemyPrefabs.Length);
            GameObject enemySpawned = Instantiate(enemyPrefabs[idToSpawn], enemyPosition[idToSpawn].position, Quaternion.identity);
            enemySpawned.tag = tagsId[idToSpawn];
        }
    }
}
