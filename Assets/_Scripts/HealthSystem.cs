using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int totalHP, currentHp;
    public GameObject[] hp;
    // Start is called before the first frame update
    void Start()
    {
        currentHp = totalHP;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHp == 2)
        {
            hp[2].SetActive(false);
        }
        else if (currentHp == 1)
        {
            hp[1].SetActive(false);
        }
        else if(currentHp == 0)
        {
            hp[0].SetActive(false);
        }
    }

    
}
