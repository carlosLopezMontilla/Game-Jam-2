using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiscoBall : MonoBehaviour
{
    public GameObject discoLight, discoBall;
    public AudioController audioController;
    public float totalTime, timeToEnd;
    public GameObject[] warningAlert;
    public KeyCode keyCode;

    // Start is called before the first frame update
    void Start()
    {
        totalTime = 25f;
        timeToEnd = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(keyCode))
        {
            discoLight.SetActive(true);
            discoBall.SetActive(true);
            audioController.gameMusic.Pause();
            timeToEnd-= Time.deltaTime;
            if (timeToEnd <= 20f)
            {
                warningAlert[0].SetActive(true);
                warningAlert[1].SetActive(false);
                warningAlert[2].SetActive(false);
                warningAlert[3].SetActive(false);
                warningAlert[4].SetActive(false);
            }
            if(timeToEnd <= 15f)
            {
                warningAlert[0].SetActive(false);
                warningAlert[1].SetActive(true);
                warningAlert[2].SetActive(false);
                warningAlert[3].SetActive(false);
                warningAlert[4].SetActive(false);

            }
            if(timeToEnd <= 10f)
            {
                warningAlert[0].SetActive(false);
                warningAlert[1].SetActive(false);
                warningAlert[2].SetActive(true);
                warningAlert[3].SetActive(false);
                warningAlert[4].SetActive(false);

            }
            if(timeToEnd <= 5f)
            {
                warningAlert[0].SetActive(false);
                warningAlert[1].SetActive(false);
                warningAlert[2].SetActive(false);
                warningAlert[3].SetActive(true);
                warningAlert[4].SetActive(false);

            }
            if(timeToEnd <= 0f)
            {
                warningAlert[0].SetActive(false);
                warningAlert[1].SetActive(false);
                warningAlert[2].SetActive(false);
                warningAlert[3].SetActive(false);
                warningAlert[4].SetActive(true);
                SceneManager.LoadScene(1);

            }
        }
        if(Input.GetKeyUp(keyCode))
        {
            discoLight.SetActive(false); 
            discoBall.SetActive(false); 
            warningAlert[0].SetActive(false);
            warningAlert[1].SetActive(false);
            warningAlert[2].SetActive(false);
            warningAlert[3].SetActive(false);
            warningAlert[4].SetActive(false);
            audioController.gameMusic.Play();
            audioController.discoBall.Stop();
            timeToEnd = totalTime;
            

        }
    }
}
