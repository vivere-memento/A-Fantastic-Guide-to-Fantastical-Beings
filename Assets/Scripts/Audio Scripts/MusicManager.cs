using UnityEngine;
using System.Collections;
using System;

public class MusicManager : MonoBehaviour {

	public AudioClip mainTheme;
	public AudioClip menuTheme;
	public AudioClip endTheme;
	public AudioClip backingTheme;
	public AudioClip finalTheme;
	bool stopRepeat= true;
	void OnEnable(){
		StartMusic2.menuStarted+= StartMainTheme;
		YogenMusic.yogenStarted+=StartBackingTheme;
		DaidaraMusic.daidaraStarted+=StartMenuTheme;
		OnibiMusic.onibiStarted+=StartBackingTheme;
		DaitenguMusic.daitenguStarted+=StartBackingTheme;
		RaijuuMusic.raijuuStarted+=StartBackingTheme;
		KitsuneMusic.kitsuneStarted+=StartFinalTheme;
	}
	void OnDisable(){
		StartMusic2.menuStarted-= StartMainTheme;
		YogenMusic.yogenStarted-=StartBackingTheme;
		DaidaraMusic.daidaraStarted-=StartMenuTheme;
		OnibiMusic.onibiStarted-=StartBackingTheme;
		DaitenguMusic.daitenguStarted-=StartBackingTheme;
		RaijuuMusic.raijuuStarted-=StartBackingTheme;
		KitsuneMusic.kitsuneStarted-=StartFinalTheme;
	}
	void Start(){
		StartBackingTheme();
	}
	public void StartFinalTheme(){
		AudioManager.instance.PlayMusic(finalTheme,0.5f);
	}
	public void StartMainTheme(){
		AudioManager.instance.PlayMusic(mainTheme,0.5f);
	}

    public void StartMenuTheme()
    {
     	AudioManager.instance.PlayMusic(menuTheme,0.5f);
    }

	public void StartEndTheme()
    {
     	AudioManager.instance.PlayMusic(endTheme,0.5f);
    }

	public void StartBackingTheme()
    {
     	AudioManager.instance.PlayMusic(backingTheme,0.5f);
    }
	void Update(){
	
	}
}