using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AmbientSoundManager : MonoBehaviour
{
    public AudioClip ambientWind;
	public AudioClip ambientRain;
	void Start(){
		
	}

    void OnEnable(){
        StartRain.playRain+=PlayRain;
        StartRain.stopRain+=StopSound;
    }
    void OnDisable(){
        StartRain.playRain-=PlayRain;
        StartRain.stopRain-=StopSound;
    }
	void PlayRain(){
		AudioManager.instance.PlayAmbient(ambientRain, 5);
	}
    void StopSound(){
        AudioManager.instance.StopAmbient();
    }
    void PlayWind()
    {
     	AudioManager.instance.PlayAmbient(ambientWind, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
