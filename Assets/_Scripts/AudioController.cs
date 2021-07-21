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

    void Start()
    {
        volume.maxValue = 1;
        volume.minValue = 0.05f;
    }
    private void Update()
    {
        gameMusic.volume = volume.value;
    }
    public void SushiEliminated()
    {
        sushiEliminated.Play();
    }
    
    public void DiscoBall()
    {
        discoBall.Play();
    }

}
