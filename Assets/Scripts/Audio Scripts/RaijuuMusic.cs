using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RaijuuMusic : MonoBehaviour
{
    public static Action raijuuStarted;
    // Start is called before the first frame update
    void Start()
    {
        raijuuStarted.Invoke();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
