using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public bool haveAnEnemy;
    public Enemy enemy;
    public PlayerPosition playerPosition;
    public string enemyTag;
    public int healthPoints, currentHealth;
    public void Start()
    {
        haveAnEnemy = false;
        currentHealth = healthPoints;
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag(enemyTag) && enemyTag == playerPosition.whatToDestroy)
        {
            haveAnEnemy = true;
            if(haveAnEnemy)
            {
                Destroy(other.gameObject);
                haveAnEnemy = false;
            }
        }
    }
}
