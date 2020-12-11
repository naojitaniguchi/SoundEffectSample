using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public AudioClip[] BGMs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playBGM(int num)
    {
        gameObject.GetComponent<AudioSource>().Stop();
        gameObject.GetComponent<AudioSource>().clip = BGMs[num];
        gameObject.GetComponent<AudioSource>().Play();
    }
}
