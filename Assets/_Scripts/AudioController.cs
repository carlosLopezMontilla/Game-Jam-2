using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public AudioSource sushiEliminated;
    public AudioSource gameMusic;
    public AudioSource discoBall;
    
    public void SushiEliminated()
    {
        sushiEliminated.Play();
    }
    
    public void DiscoBall()
    {
        discoBall.Play();
    }

}
