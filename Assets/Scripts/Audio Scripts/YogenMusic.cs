using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class YogenMusic : MonoBehaviour
{
    public static Action yogenStarted;
    // Start is called before the first frame update
    void Start()
    {
        yogenStarted?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
