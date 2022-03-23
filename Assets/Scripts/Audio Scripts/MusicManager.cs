using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip mainTheme;
	public AudioClip menuTheme;
	public AudioClip endTheme;
	void OnEnable(){
		GoToJapan.MovingToMain +=StartMainTheme;
	}
	void OnDisable(){
		GoToJapan.MovingToMain -=StartMainTheme;
	}
	void Start(){
		StartMenuTheme();
	}
	void StartMainTheme(){
		AudioManager.instance.PlayMusic(mainTheme,7);
	}

    void StartMenuTheme()
    {
     	AudioManager.instance.PlayMusic(menuTheme,1);
    }

	void StartEndTheme()
    {
     	AudioManager.instance.PlayMusic(endTheme,3);
    }

	void Update(){
	
	}
}