using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedCintas : MonoBehaviour
{
    public float speedY;
    private float offsetY;
    // Start is called before the first frame update
    void Start()
    {
        offsetY = GetComponent<Renderer>().material.mainTextureOffset.y;
    }

    void Update()
    {
        offsetY += Time.deltaTime * speedY;
    }
    // Update is called once per frame

}
