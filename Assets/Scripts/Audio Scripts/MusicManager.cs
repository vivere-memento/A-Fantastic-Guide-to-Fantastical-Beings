using UnityEngine;
using System.Collections;
using System;

public class MusicManager : MonoBehaviour {

	public AudioClip titleTheme;
	public AudioClip menuTheme;
	public AudioClip sceneTranquil;
	public AudioClip sceneVibrant;
	public AudioClip sceneEpic;
	public AudioClip sceneIntrigue;
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
		AudioManager.instance.PlayMusic(sceneEpic,0.5f);
	}
	public void StartMainTheme(){
		AudioManager.instance.PlayMusic(titleTheme,0.5f);
	}

    public void StartMenuTheme()
    {
     	AudioManager.instance.PlayMusic(menuTheme,0.5f);
    }

	public void StartEndTheme()
    {
     	AudioManager.instance.PlayMusic(sceneTranquil,0.5f);
    }

	public void StartBackingTheme()
    {
     	AudioManager.instance.PlayMusic(sceneVibrant,0.5f);
    }
	void Update(){
	
	}
}