using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource sushiEliminated;
    public void SushiEliminated()
    {
        sushiEliminated.Play();
    }

}
