using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DaitenguMusic : MonoBehaviour
{
    public static Action daitenguStarted;
    // Start is called before the first frame update
    void Start()
    {
        daitenguStarted?.Invoke();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
