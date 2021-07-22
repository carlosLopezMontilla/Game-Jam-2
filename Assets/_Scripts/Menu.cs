using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject death, pause, tutorial, volume, hp,fase,enemies
        ;
    public AudioController audioController;
    public Enemy enemy;

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        audioController.gameMusic.Play();
        Time.timeScale = 1;
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void Continue()
    {
        Time.timeScale = 1;
        audioController.gameMusic.Play();
        pause.SetActive(false);
        tutorial.SetActive(false);
        hp.SetActive(true);
        enemies.SetActive(true);
        fase.SetActive(true);
    }
    public void Tutorial()
    {
        tutorial.SetActive(true);
    }
    public void Volume()
    {
        volume.SetActive(true);
    }

    private void Update()
    {
       /* if(Input.GetKey(KeyCode.Space))
            {
            GOtext.SetActive(true);
            death.SetActive(true);
            text.text = "You died";
        }*/
        if(Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            audioController.gameMusic.Pause();
            hp.SetActive(false);
            hp.SetActive(false);
            fase.SetActive(false);
            enemies.SetActive(false);
            pause.SetActive(true);

        }
    }
}
