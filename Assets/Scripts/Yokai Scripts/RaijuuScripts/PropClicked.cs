using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PropClicked : MonoBehaviour
{
    public static Action<string> propClicked;
    public string propName;
    private bool done = true;
    void OnMouseDown(){
        AudioManager.instance.PlaySound2D("Shift");
        Debug.Log("done.ToString()");
        if(done){
        Debug.Log(propName);
        propClicked?.Invoke(propName);
        this.GetComponent<TooltipTrigger>().isActive = false;
        done = false;
        Debug.Log(done.ToString());
        }
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
