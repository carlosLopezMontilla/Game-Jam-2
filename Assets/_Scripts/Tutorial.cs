using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject[] tutorials;
    public int currentId;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        tutorials[1].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1;
        }
    }
}
