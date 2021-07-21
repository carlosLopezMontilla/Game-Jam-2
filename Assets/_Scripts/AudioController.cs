using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource sushiEliminated;
    public AudioSource gameMusic;
    public void SushiEliminated()
    {
        sushiEliminated.Play();
    }
    private void Update()
    {
        print(gameMusic.time.ToString("F0"));
    }

}
