using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoBall : MonoBehaviour
{
    public GameObject[] lights;
    public int currentId;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            currentId += 1;
            lights[currentId].SetActive(true);
            if(currentId >= lights.Length)
            {
                currentId = 0;
            }
        }
    }
}
