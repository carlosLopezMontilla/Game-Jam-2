using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject death, pause, GOtext;
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void Continue()
    {
        Time.timeScale = 1;
        GOtext.SetActive(false);
        pause.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
            {
            GOtext.SetActive(true);
            death.SetActive(true);
            text.text = "You died";
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            GOtext.SetActive(true);
            pause.SetActive(true);
            text.text = "Pause";
        }
    }
}
