using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DaidaraMusic : MonoBehaviour
{
    public static Action daidaraStarted;
    // Start is called before the first frame update
    void Start()
    {
        daidaraStarted?.Invoke();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
