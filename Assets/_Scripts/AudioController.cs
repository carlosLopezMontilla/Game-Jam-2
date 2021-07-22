using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioSource sushiEliminated;
    public AudioSource gameMusic;
    public AudioSource discoBall;
    public Slider volume;
    public KeyCode keyCode;

    void Start()
    {
        volume.maxValue = 1;
        volume.minValue = 0.05f;
    }
    private void Update()
    {
        gameMusic.volume = volume.value;

        if(Input.GetKeyDown(keyCode))
        {
            discoBall.Play();
        }
        if(Input.GetKeyUp(keyCode))
        {
            discoBall.Stop();
        }
    }
    public void SushiEliminated()
    {
        sushiEliminated.Play();
    }
    


}
