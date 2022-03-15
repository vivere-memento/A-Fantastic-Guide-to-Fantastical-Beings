using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip mainTheme;
	public AudioClip menuTheme;
	void OnEnable(){
		GoToJapan.MovingToMain +=changeMusic;
	}
	void OnDisable(){
		GoToJapan.MovingToMain -=changeMusic;
	}
	void Start() {
		AudioManager.instance.PlayMusic (menuTheme, 2);
	}
	void changeMusic(){
		AudioManager.instance.PlayMusic(mainTheme,3);
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			AudioManager.instance.PlayMusic (mainTheme, 3);
		}
	
	}
}