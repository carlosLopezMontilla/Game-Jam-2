using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoBall : MonoBehaviour
{
    public GameObject discoLight;
    public AudioController audioController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            discoLight.SetActive(true);
            audioController.discoBall.Play();
            audioController.gameMusic.Pause();
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            discoLight.SetActive(false);
            audioController.gameMusic.Play();
            audioController.discoBall.Stop();
        }
    }
}
