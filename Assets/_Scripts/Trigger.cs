using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public bool haveAnEnemy;
    public Enemy enemy;
    public PlayerPosition playerPosition;
    public HealthSystem hp;
    public string enemyTag;
    public GameObject deathScreen;
    public AudioController audioController;
    
    
    public void Start()
    {
        haveAnEnemy = false;
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag(enemyTag) && enemyTag == playerPosition.whatToDestroy)
        {
            haveAnEnemy = true;
            if(haveAnEnemy)
            {
                Destroy(other.gameObject);
                enemy.numbersOfEnemies -= 1;
                audioController.SushiEliminated();
                haveAnEnemy = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        hp.currentHp -= 1;
        Destroy(other.gameObject);
        if(hp.currentHp <= 0)
        {
            Time.timeScale = 0;
            deathScreen.SetActive(true);
        }
    }
}
