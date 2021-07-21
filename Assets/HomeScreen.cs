using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreen : MonoBehaviour
{
    public AudioSource gameMusic;
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        gameMusic.Play();
        Time.timeScale = 1;

    }
    public void Quit()
    {
        Application.Quit();
    }
}
