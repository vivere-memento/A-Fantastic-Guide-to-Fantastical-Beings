using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip mainTheme;
	public AudioClip menuTheme;
	public AudioClip endTheme;
	void OnEnable(){
		
	}
	void OnDisable(){
		
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