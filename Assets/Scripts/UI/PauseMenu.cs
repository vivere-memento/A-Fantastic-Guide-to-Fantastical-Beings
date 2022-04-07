using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private Canvas pauseCanvas;
    private AudioSource menuSource;
    public Image quitBacking;
    private bool showingCanvas = false;
    // Start is called before the first frame update
    void Start()
    {
        menuSource = gameObject.GetComponent<AudioSource>();
        pauseCanvas = gameObject.GetComponentInChildren<Canvas>();
        pauseCanvas.enabled = false;
        menuSource.ignoreListenerPause= true;
        quitBacking.enabled=false;
    }
    void PlayButtonNoise(){
        menuSource.Play();
    }
    void Pause()
    {
        pauseCanvas.enabled = true;
        showingCanvas = true;
        AudioListener.pause = true;
        Time.timeScale = 0f;
    }
    void UnPause()
    {
        showingCanvas = false;
        pauseCanvas.enabled = false;
        AudioListener.pause = false;
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!showingCanvas)
            {
                Pause();
            }
            else
            {
                UnPause();
                CloseQuitBacking();
            }
        }
    }
    public void Resume()
    {
        PlayButtonNoise();
        UnPause();
    }
    public void ShowHowToPlay()
    {
        PlayButtonNoise();
        //ACTIVE HOW TO PLAY CANVAS
    }
    public void Quit()
    {
        PlayButtonNoise();
        quitBacking.enabled=true;
    }
    public void ReallyQuit(){
        Application.Quit();
    }
    public void CloseQuitBacking(){
        quitBacking.enabled=false;
    }
}