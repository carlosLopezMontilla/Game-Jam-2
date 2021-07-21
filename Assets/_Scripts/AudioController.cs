using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }

}
