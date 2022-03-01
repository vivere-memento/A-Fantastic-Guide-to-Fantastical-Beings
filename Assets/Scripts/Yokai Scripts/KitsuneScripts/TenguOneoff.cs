using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TenguOneoff : MonoBehaviour
{
    public static Action<string> tenguCaptured;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
        tenguCaptured?.Invoke("Tengu Daoshi");
        this.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
