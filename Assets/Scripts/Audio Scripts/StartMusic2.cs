using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StartMusic2 : MonoBehaviour
{
    public static Action menuStarted;
    // Start is called before the first frame update
    void Start()
    {
        menuStarted?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
