using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject soundObject;
    public GameObject BGM;
    public GameObject SESceneChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            soundObject.GetComponent<SoundEffectManager>().playSE(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            soundObject.GetComponent<SoundEffectManager>().playSE(1);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            BGM.GetComponent<BGMManager>().playBGM(0);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            BGM.GetComponent<BGMManager>().playBGM(1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SESceneChange.GetComponent<SEAndSceneChange>().PlaySEAndSceneChange();
        }
    }
}
