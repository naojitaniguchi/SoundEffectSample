using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
    public AudioClip[] soundEffetts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSE(int num)
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(soundEffetts[num]);
    }
}
