using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SEAndSceneChange : MonoBehaviour
{
    public GameObject SEManager;
    public float waitTime = 3.0f;
    public string nextScene;
    public int seNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator WaitAndSceneChange()
    {
        SEManager.GetComponent<SoundEffectManager>().playSE(seNumber);

        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(nextScene);
    }

    public void PlaySEAndSceneChange()
    {
        StartCoroutine("WaitAndSceneChange");
    }

}
