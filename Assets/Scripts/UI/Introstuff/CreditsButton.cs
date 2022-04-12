using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 
    }

    public void StartCredits(){
        AudioManager.instance.PlaySound2D("ButtonPress");
        SceneManager.LoadSceneAsync("Credits",LoadSceneMode.Additive);
    }
    public void HowToPlay(){
        AudioManager.instance.PlaySound2D("ButtonPress");
        SceneManager.LoadSceneAsync("HowToPlay",LoadSceneMode.Additive);
    }
    public void ActuallyQuit(){
        AudioManager.instance.PlaySound2D("ButtonPress");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
