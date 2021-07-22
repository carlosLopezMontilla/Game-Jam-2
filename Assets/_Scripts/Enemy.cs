using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

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
    public int numbersOfEnemiesLeft, numbersOfEnemies;
    public bool canChangeScene;
    public TextMeshProUGUI enemiesText;
    // Start is called before the first frame update
    void Start()
    {
        canChangeScene = false;
        timeToEnd = initialTime;
        numbersOfEnemiesLeft = numbersOfEnemies;
    }

    // Update is called once per frame
    void Update()
    {
        timeToEnd -= Time.deltaTime;
        enemiesText.text = numbersOfEnemies + " / " + numbersOfEnemiesLeft;
        if (timeToEnd <= 0)
        {
            SpawnObject();
            timeToEnd = initialTime;   
        }
        if(numbersOfEnemiesLeft <= 0)
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
        if(numbersOfEnemiesLeft >= 1)
        {
            idToSpawn = (int)Random.Range(0, enemyPrefabs.Length);
            GameObject enemySpawned = Instantiate(enemyPrefabs[idToSpawn], enemyPosition[idToSpawn].position, Quaternion.identity);
            enemySpawned.tag = tagsId[idToSpawn];
        }
    }
}
