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
	public AudioClip akemura;
	bool stopRepeat= true;
	private int timesCalled;
	void OnEnable(){
		StartMusic2.menuStarted+= Judgement;
		YogenMusic.yogenStarted+=StartTranquil;
		DaidaraMusic.daidaraStarted+=StartVibrantTheme;
		OnibiMusic.onibiStarted+=StartIntrigue;
		DaitenguMusic.daitenguStarted+=StartVibrantTheme;
		RaijuuMusic.raijuuStarted+=StartTranquil;
		KitsuneMusic.kitsuneStarted+=StartEpicTheme;
	}
	void OnDisable(){
		StartMusic2.menuStarted-= Judgement;
		YogenMusic.yogenStarted-=StartTranquil;
		DaidaraMusic.daidaraStarted-=StartVibrantTheme;
		OnibiMusic.onibiStarted-=StartIntrigue;
		DaitenguMusic.daitenguStarted-=StartVibrantTheme;
		RaijuuMusic.raijuuStarted-=StartTranquil;
		KitsuneMusic.kitsuneStarted-=StartEpicTheme;
	}
	void Start(){
		StartTranquil();
	}
	public void Judgement(){
		timesCalled++;
		if(timesCalled==2){
			//do nothing
		}
		if(timesCalled<2){
			StartMenuTheme();
		}
		if(timesCalled>2){
			StartMenuTheme();
		}
	}
	public void StartEpicTheme(){
		AudioManager.instance.PlayMusic(sceneEpic,0.5f);
	}
	public void StartTitleTheme(){
		AudioManager.instance.PlayMusic(titleTheme,0.5f);
	}

    public void StartMenuTheme()
    {
     	AudioManager.instance.PlayMusic(menuTheme,0.5f);
    }

	public void StartTranquil()
    {
     	AudioManager.instance.PlayMusic(sceneTranquil,0.5f);
    }

	public void StartVibrantTheme()
    {
     	AudioManager.instance.PlayMusic(sceneVibrant,0.5f);
    }
	public void StartAkemura()
    {
     	AudioManager.instance.PlayMusic(akemura,0.5f);
    }
	public void StartIntrigue(){
		AudioManager.instance.PlayMusic(sceneIntrigue,0.5f);
	}
	void Update(){
	
	}
}