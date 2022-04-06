using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KitsuneMusic : MonoBehaviour
{
    public static Action kitsuneStarted;
    // Start is called before the first frame update
    void Start()
    {
        kitsuneStarted?.Invoke();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
