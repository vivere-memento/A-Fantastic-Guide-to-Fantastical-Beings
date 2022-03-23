using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundManager : MonoBehaviour
{
    public AudioClip ambientWind;
	public AudioClip ambientRain;
	void Start(){
		StartRain();
	}
	void StartRain(){
		AudioManager.instance.PlayAmbient(ambientRain, 5);
	}

    void StartWind()
    {
     	AudioManager.instance.PlayAmbient(ambientWind, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
