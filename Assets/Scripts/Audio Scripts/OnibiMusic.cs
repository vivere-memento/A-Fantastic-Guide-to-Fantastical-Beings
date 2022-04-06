using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OnibiMusic : MonoBehaviour
{
    public static Action onibiStarted;
    // Start is called before the first frame update
    void Start()
    {
        onibiStarted?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
