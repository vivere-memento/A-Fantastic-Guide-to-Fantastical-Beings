using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StartRain : MonoBehaviour
{
    public static Action playRain;
    void OnEnable(){
        OneShotOnibi.movedScene+= Rain; 
    }
    void OnDisable(){
        OneShotOnibi.movedScene-= Rain; 
    }
    void Rain(){
        playRain?.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
