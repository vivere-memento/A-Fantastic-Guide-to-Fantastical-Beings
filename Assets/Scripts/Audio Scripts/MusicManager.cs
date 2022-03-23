using UnityEngine;
using System.Collections;
using System;

public class MusicManager : MonoBehaviour {

	public AudioClip mainTheme;
	public AudioClip menuTheme;
	public AudioClip endTheme;
	void OnEnable(){
		StartMusic2.menuStarted+= StartMainTheme;
	}
	void OnDisable(){
		StartMusic2.menuStarted-= StartMainTheme;
	}
	void Start(){
		StartMenuTheme();
	}
	public void StartMainTheme(){
		AudioManager.instance.PlayMusic(mainTheme,3);
	}

    public void StartMenuTheme()
    {
     	AudioManager.instance.PlayMusic(menuTheme,1);
    }

	public void StartEndTheme()
    {
     	AudioManager.instance.PlayMusic(endTheme,3);
    }

	void Update(){
	
	}
}