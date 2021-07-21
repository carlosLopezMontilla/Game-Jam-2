using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public Enemy enemy;
    public GameObject WinScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.numbersOfEnemies <= 0 && SceneManager.GetActiveScene().name == "Scene7")
        {
            WinScreen.SetActive(true);
            Time.timeScale = 0; 
        }
    }
}
